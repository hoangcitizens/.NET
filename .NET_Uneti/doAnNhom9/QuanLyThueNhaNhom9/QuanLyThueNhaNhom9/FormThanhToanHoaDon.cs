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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyThueNhaNhom9
{
    public partial class FormThanhToanHoaDon : Form
    {
        SqlConnection conn = new KetNoiCSDL().getCon();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public FormThanhToanHoaDon()
        {
            InitializeComponent();
        }
        public void loaddl()
        {
            txtMaHoaDon.DataBindings.Clear();
            txtTienThanhToan.DataBindings.Clear();
            txtMaKhachHang.DataBindings.Clear();
            txtTenKhachHang.DataBindings.Clear();
            SqlCommand cmd = new SqlCommand(@"select MaHoaDon,HoaDon.MaKhachHang,HoTenKH,SoDienThoaiKH,TienThanhToan
            from HoaDon,KhachHang 
            where KhachHang.MaKhachHang = HoaDon.MaKhachHang;", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            txtMaHoaDon.DataBindings.Add("Text", dt, "MaHoaDon");
            txtTienThanhToan.DataBindings.Add("Text", dt, "TienThanhToan");
            txtTenKhachHang.DataBindings.Add("Text", dt, "HoTenKH");
            txtMaKhachHang.DataBindings.Add("Text", dt, "MaKhachHang");
        }

        private void FormThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(@"select MaHoaDon,HoaDon.MaKhachHang,HoTenKH ,TienThanhToan from HoaDon,KhachHang where KhachHang.MaKhachHang = HoaDon.MaKhachHang;", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            loaddl();
            dataGridView1.DataSource = dt;                           
        }
  
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO HoaDon values (@MaHoaDon,@MaKhachHang,@TienThanhToan)", conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", txtMaHoaDon.Text);
            cmd.Parameters.AddWithValue("@MaKhachHang", txtMaKhachHang.Text);
            cmd.Parameters.AddWithValue("@TienThanhToan", txtTienThanhToan.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm thành công");
                loaddl();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thanh toán hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", txtMaHoaDon.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thanh toán thành công ! Hóa đơn đã xóa khỏi danh sách");
                    loaddl();
                }
                else
                    MessageBox.Show("Thanh toán thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE HoaDon" +
                                   "SET MaKhachHang = @MaKhachHang, TienThanhToan = @TienThanhToan " +
                                   "WHERE MaHoaDon = @MaHoaDon", conn);
            cmd.Parameters.AddWithValue("@MaKhachHang", txtMaKhachHang.Text);
            cmd.Parameters.AddWithValue("@TienThanhToan", txtTienThanhToan.Text);
            cmd.Parameters.AddWithValue("@MaHoaDon", txtMaHoaDon.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Sửa thành công");
                loaddl();
            }
            else
                MessageBox.Show("Sửa thất bại");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT HoaDon.MaHoaDon, KhachHang.MaKhachHang, KhachHang.HoTenKH, KhachHang.DiaChiKH, KhachHang.SoDienThoaiKH, KhachHang.EmailKH, HoaDon.TienThanhToan " +
                                           "FROM HoaDon " +
                                           "INNER JOIN KhachHang ON HoaDon.MaKhachHang = KhachHang.MaKhachHang " +
                                           "WHERE KhachHang.HoTenKH LIKE @HoTenKH + '%'", conn);
            cmd.Parameters.AddWithValue("@HoTenKH", txtTimKiem.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtResult = new DataTable();
            da.Fill(dtResult);
            dataGridView2.DataSource = dtResult;

            if (dtResult.Rows.Count > 0)
            {
                dataGridView2.Visible = true;
                label7.Text = dtResult.Rows[0]["HoTenKH"].ToString();
            }
            else
            {
                dataGridView2.Visible = false;
                MessageBox.Show("Không tìm thấy dữ liệu");
            }

            // Tính tổng tiền thanh toán và hiển thị lên label9
            SqlCommand cmdTongTien = new SqlCommand("SELECT SUM(HoaDon.TienThanhToan) AS TongTienThanhToan " +
                                                   "FROM HoaDon " +
                                                   "INNER JOIN KhachHang ON HoaDon.MaKhachHang = KhachHang.MaKhachHang " +
                                                   "WHERE KhachHang.HoTenKH LIKE @HoTenKH + '%'", conn);
            cmdTongTien.Parameters.AddWithValue("@HoTenKH", txtTimKiem.Text);

            object result = cmdTongTien.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                label9.Text = "" + ((decimal)result).ToString("N0") + " VND";
            }
            else
            {
                label9.Text = "Tổng tiền thanh toán: 0 VND";
            }
            conn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
