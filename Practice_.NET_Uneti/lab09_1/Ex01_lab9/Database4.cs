using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_lab9
{
    public class Database4
    {
        private SqlConnection conn;

        // Hàm khởi tạo với kết nối SQL
        public Database4()
        {
            conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QLBH_LAB9.mdf;
                Integrated Security=True;Connect Timeout=30");
        }

        // Mở kết nối
        private void openConnect()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        // Đóng kết nối
        private void closeConnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // Phương thức tìm kiếm khách hàng theo tiêu chí (cột tìm kiếm và nội dung)
        public DataTable timKiemKhachhang(string column, string keyword)
        {
            DataTable bangKetqua = new DataTable();
            try
            {
                openConnect();

                // Câu truy vấn với tham số để tìm kiếm dữ liệu
                string sql = $"SELECT * FROM tblKhachHang WHERE {column} LIKE @keyword";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(bangKetqua);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm khách hàng: " + ex.Message, "Thông báo lỗi");
            }
            finally
            {
                closeConnect();
            }

            return bangKetqua;
        }
    }
}
