using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_lab9
{
    public class Database2
    {
        private SqlConnection conn;    
        public Database2()
        {
            // Khởi tạo chuỗi kết nối
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB; 
            AttachDbFilename={Application.StartupPath}\QLBH_LAB9.mdf; 
            Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(connectionString);
        }

        private void openConnect()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        private void closeConnect()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable danhSachMathang()
        {
            DataTable bang = new DataTable();
            try
            {
                openConnect();
                string sql = "SELECT * FROM tblMatHang";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    bang.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi lấy dữ liệu: " + ex.Message);
            }
            finally
            {
                closeConnect();
            }

            return bang;
        }     

        public void themMathang(string maMH, string tenMH, string dvt)
        {
            // Thực hiện thêm mặt hàng vào cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB; 
                    AttachDbFilename={Application.StartupPath}\QLBH_LAB9.mdf;
                    Integrated Security=True;Connect Timeout=30")) // Thay đổi connection string của bạn
            {
                conn.Open();
                string sqlInsert = "INSERT INTO tblMatHang (MaMH, TenMatHang, DVT) VALUES (@MaMH, @TenMatHang, @DVT)";
                using (SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@MaMH", maMH);
                    cmdInsert.Parameters.AddWithValue("@TenMatHang", tenMH);
                    cmdInsert.Parameters.AddWithValue("@DVT", dvt);
                    cmdInsert.ExecuteNonQuery(); // Thực hiện câu lệnh INSERT
                }
            }

        }

        public void suaMathang(string tenMh, string dvt, string maMh)
        {
            // Thực hiện sửa mặt hàng
            using (SqlConnection conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB; 
                    AttachDbFilename={Application.StartupPath}\QLBH_LAB9.mdf;
                    Integrated Security=True;Connect Timeout=30")) // Thay đổi connection string của bạn
            {
                conn.Open();
                string sqlUpdate = "UPDATE tblMatHang SET TenMatHang = @TenMatHang, DVT = @DVT WHERE MaMH = @MaMH";
                using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@TenMatHang", tenMh);
                    cmdUpdate.Parameters.AddWithValue("@DVT", dvt);
                    cmdUpdate.Parameters.AddWithValue("@MaMH", maMh);
                    cmdUpdate.ExecuteNonQuery(); // Thực hiện câu lệnh UPDATE
                }
            }
        }

        public void xoaMathang(string maMh)
        {
            // Thực hiện xóa mặt hàng
            using (SqlConnection conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB; 
                    AttachDbFilename={Application.StartupPath}\QLBH_LAB9.mdf;
                    Integrated Security=True;Connect Timeout=30")) // Thay đổi connection string của bạn
            {
                conn.Open();
                string sqlDelete = "DELETE FROM tblMatHang WHERE MaMH = @MaMH";
                using (SqlCommand cmdDelete = new SqlCommand(sqlDelete, conn))
                {
                    cmdDelete.Parameters.AddWithValue("@MaMH", maMh);
                    cmdDelete.ExecuteNonQuery(); // Thực hiện câu lệnh DELETE
                }
            }
        }

        public DataTable timKiemMathang(string maMh)
        {
            // Thực hiện tìm kiếm mặt hàng
            DataTable bang = new DataTable();

            using (SqlConnection conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB; 
                    AttachDbFilename={Application.StartupPath}\QLBH_LAB9.mdf;
                    Integrated Security=True;Connect Timeout=30")) // Thay đổi connection string của bạn
            {
                conn.Open();
                string sqlTimKiem = "SELECT * FROM tblMatHang WHERE MaMH = @MaMH";
                using (SqlCommand cmd = new SqlCommand(sqlTimKiem, conn))
                {
                    cmd.Parameters.AddWithValue("@MaMH", maMh);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        bang.Load(reader); // Tải dữ liệu từ SqlDataReader vào DataTable
                    }
                }
            }

            return bang; // Trả về DataTable chứa kết quả tìm kiếm
        }

        public bool kiemTraMaMathang(string maMH)
        {
            bool kiemTra = false; // Khởi tạo biến kiemTra là false
            try
            {
                openConnect(); // Mở kết nối

                // Câu truy vấn kiểm tra mã mặt hàng
                string sql = "SELECT COUNT(*) FROM tblMatHang WHERE MaMH = @MaMH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMH", maMH); // Thêm tham số vào câu truy vấn

                // Thực thi câu truy vấn và lấy số lượng kết quả
                int count = (int)cmd.ExecuteScalar(); // Sử dụng ExecuteScalar để lấy giá trị duy nhất

                // Nếu số lượng lớn hơn 0, nghĩa là mã mặt hàng đã tồn tại
                if (count > 0)
                {
                    kiemTra = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi kiểm tra mã mặt hàng: " + ex.Message);
            }
            finally
            {
                closeConnect(); // Đóng kết nối
            }

            return kiemTra; // Trả về kết quả kiểm tra
        }
    }
}
