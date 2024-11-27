using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_NguyenHuuHoang_DHTI15A5HN
{
    public partial class frmHopDong_MatHang : Form
    {
        SqlConnection con = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QuanLyBanHang_2024_v3.mdf;
                Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        public frmHopDong_MatHang()
        {
            InitializeComponent();
        }
        public void loaddl()
        {
            txtSoHieuHopDong.DataBindings.Clear();
            txtMaMH.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();


            SqlCommand cmd = new SqlCommand
            ($@"SELECT HopDong.SoHieuHD AS [Số hiệu hợp đồng], 
            HopDong_MatHang.MaMH AS [Mã mặt hàng], 
            MatHang.TenMH AS [Tên mặt hàng], 
            MatHang.DonViTinh AS [Đơn vị tính], 
            MatHang.DonGia AS [Đơn giá], 
            HopDong_MatHang.SoLuong AS [Số lượng]
            FROM HopDong
            INNER JOIN HopDong_MatHang ON HopDong.SoHieuHD = HopDong_MatHang.SoHieuHD
            INNER JOIN MatHang ON HopDong_MatHang.MaMH = MatHang.MaMH", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            txtSoHieuHopDong.DataBindings.Add("Text", dt, "Số hiệu hợp đồng");
            txtMaMH.DataBindings.Add("Text", dt, "Mã mặt hàng");
            txtSoLuong.DataBindings.Add("Text", dt, "Số lượng");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            loaddl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO HopDong_MatHang (SoHieuHD, MaMH, SoLuong) 
                         VALUES (@SoHieuHD, @MaMH, @SoLuong)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SoHieuHD", txtSoHieuHopDong.Text);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Thêm mới thành công!");
                loaddl(); // Tải lại dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"UPDATE HopDong_MatHang 
                         SET SoLuong = @SoLuong
                         WHERE SoHieuHD = @SoHieuHD AND MaMH = @MaMH";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SoHieuHD", txtSoHieuHopDong.Text);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Sửa thành công!");
                loaddl(); // Tải lại dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"DELETE FROM HopDong_MatHang 
                         WHERE SoHieuHD = @SoHieuHD AND MaMH = @MaMH";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SoHieuHD", txtSoHieuHopDong.Text);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Xóa thành công!");
                loaddl(); // Tải lại dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT HopDong.SoHieuHD AS [Số hiệu hợp đồng], 
                                HopDong_MatHang.MaMH AS [Mã mặt hàng], 
                                MatHang.TenMH AS [Tên mặt hàng], 
                                MatHang.DonViTinh AS [Đơn vị tính], 
                                MatHang.DonGia AS [Đơn giá], 
                                HopDong_MatHang.SoLuong AS [Số lượng]
                         FROM HopDong
                         INNER JOIN HopDong_MatHang ON HopDong.SoHieuHD = HopDong_MatHang.SoHieuHD
                         INNER JOIN MatHang ON HopDong_MatHang.MaMH = MatHang.MaMH
                         WHERE HopDong.SoHieuHD LIKE @SoHieuHD OR HopDong_MatHang.MaMH LIKE @MaMH";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SoHieuHD", "%" + txtSoHieuHopDong.Text + "%");
                cmd.Parameters.AddWithValue("@MaMH", "%" + txtMaMH.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtSearch = new DataTable();
                da.Fill(dtSearch);

                dataGridView1.DataSource = dtSearch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
