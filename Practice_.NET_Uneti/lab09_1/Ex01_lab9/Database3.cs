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
    public class Database3
    {
        private SqlConnection conn;

        public Database3()
        {
            conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QLBH_LAB9.mdf;
                Integrated Security=True;Connect Timeout=30");
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

        // Phương thức danhSachChitietMathang lấy chi tiết mặt hàng theo số hóa đơn
        public DataTable danhSachChitietMathang(string soHoadon)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM tblChiTietBanHang WHERE SoHieuHD = @shd";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@shd", soHoadon);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        // Phương thức kiểm tra tồn tại số hóa đơn
        public bool kiemTraSoHoadon(string soHieuHoadon)
        {
            bool kiemTra = false;
            openConnect();
            string sql = "SELECT * FROM tblBanHang WHERE SoHieuHD = @sh";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@sh", soHieuHoadon);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                kiemTra = true;
            }
            closeConnect();
            return kiemTra;
        }

        // Phương thức thêm mới hóa đơn bán hàng
        public void themBanhang(string soHieuHoadon, string maKH, DateTime ngayMua)
        {
            openConnect();
            string sql = "INSERT INTO tblBanHang (SoHieuHD, MaKH, NgayMuaBan) VALUES (@sh, @maKH, @ngay)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@sh", soHieuHoadon);
            cmd.Parameters.AddWithValue("@maKH", maKH);
            cmd.Parameters.AddWithValue("@ngay", ngayMua);
            cmd.ExecuteNonQuery();
            closeConnect();
        }

        // Phương thức thêm chi tiết bán hàng
        public void themChitietBanhang(string soHieuHoadon, string mamh, int soLuong, float donGia)
        {
            openConnect();
            string sql = "INSERT INTO tblChiTietBanHang (SoHieuHD, MaMH, SoLuong, DonGia) VALUES (@sh, @mamh, @sl, @dg)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@sh", soHieuHoadon);
            cmd.Parameters.AddWithValue("@mamh", mamh);
            cmd.Parameters.AddWithValue("@sl", soLuong);
            cmd.Parameters.AddWithValue("@dg", donGia);
            cmd.ExecuteNonQuery();
            closeConnect();
        }

        // Phương thức sửa chi tiết bán hàng
        public void suaChitietBanhang(int soLuong, float donGia, string mamh)
        {
            openConnect();
            string sql = "UPDATE tblChiTietBanHang SET SoLuong = @sl, DonGia = @dg WHERE MaMH = @ma";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@sl", soLuong);
            cmd.Parameters.AddWithValue("@dg", donGia);
            cmd.Parameters.AddWithValue("@ma", mamh);
            cmd.ExecuteNonQuery();
            closeConnect();
        }

        // Phương thức xóa chi tiết bán hàng
        public void xoaChitietBanHang(int soHieuHD, string mamh)
        {
            openConnect();
            string sql = "DELETE FROM tblChiTietBanHang WHERE SoHieuHD = @sh AND MaMH = @ma";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@sh", soHieuHD);
            cmd.Parameters.AddWithValue("@ma", mamh);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
    }
}
