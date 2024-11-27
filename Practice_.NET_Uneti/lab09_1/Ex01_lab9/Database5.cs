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
    public class Database5
    {
        private SqlConnection conn;

        // Hàm khởi tạo với kết nối SQL
        public Database5()
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
        // Phương thức để tìm kiếm mặt hàng dựa trên cột (maMH hoặc tenMH) và giá trị tìm kiếm
        public DataTable timKiemMathang(string columnName, string searchValue)
        {
            DataTable bangKetqua = new DataTable();

            try
            {
                openConnect();
                string query = $"SELECT * FROM tblMatHang WHERE {columnName} LIKE @searchValue";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(bangKetqua);

                if (bangKetqua.Rows.Count == 0)
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi tìm kiếm");
                return null;
            }
            finally
            {
                closeConnect();
            }
            return bangKetqua;
        }    
    }
}

