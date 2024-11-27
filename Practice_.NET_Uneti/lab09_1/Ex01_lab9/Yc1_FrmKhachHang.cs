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

namespace Ex01_lab9
{
    public partial class Yc1_FrmKhachHang : Form
    {
        SqlConnection con = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QLBH_LAB9.mdf;
                Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();      
        public Yc1_FrmKhachHang()
        {
            InitializeComponent();
            //con.Open();
        }
        public void loaddl()
        {
            txt_makh.DataBindings.Clear();
            txt_hoten.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            txt_dienthoai.DataBindings.Clear();
            combo_gioitinh.DataBindings.Clear();

            SqlCommand cmd = new SqlCommand
            ($@"SELECT * FROM tblKhachHang", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            txt_makh.DataBindings.Add("Text", dt, "MaKH");
            txt_hoten.DataBindings.Add("Text", dt, "HoTen");
            txt_diachi.DataBindings.Add("Text", dt, "DiaChi");
            txt_dienthoai.DataBindings.Add("Text", dt, "DienThoai");
            combo_gioitinh.DataBindings.Add("Text", dt, "gioiTinh");
        }
        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            loaddl();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_hoten.Text) || string.IsNullOrEmpty(txt_makh.Text) || string.IsNullOrEmpty(txt_dienthoai.Text) || string.IsNullOrEmpty(txt_diachi.Text)
                    || combo_gioitinh.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                SqlCommand cmd = new SqlCommand
                    ("INSERT INTO tblKhachHang(MaKH, HoTen, gioiTinh, DiaChi, DienThoai)" +
                    "VALUES(@MaKH, @HoTen, @gioiTinh, @DiaChi, @DienThoai)", con);
                cmd.Parameters.AddWithValue("@MaKH", txt_makh.Text);
                cmd.Parameters.AddWithValue("@HoTen", txt_hoten.Text);
                cmd.Parameters.AddWithValue("@gioiTinh", combo_gioitinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txt_diachi.Text);
                cmd.Parameters.AddWithValue("@DienThoai", txt_dienthoai.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    loaddl();
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_hoten.Text) || string.IsNullOrEmpty(txt_makh.Text) || string.IsNullOrEmpty(txt_dienthoai.Text) || string.IsNullOrEmpty(txt_diachi.Text)
                    || combo_gioitinh.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    "UPDATE tblKhachHang SET HoTen = @HoTen, gioiTinh = @gioiTinh, DiaChi = @DiaChi, DienThoai = @DienThoai WHERE MaKH = @MaKH", con);

                cmd.Parameters.AddWithValue("@MaKH", txt_makh.Text);
                cmd.Parameters.AddWithValue("@HoTen", txt_hoten.Text);
                cmd.Parameters.AddWithValue("@gioiTinh", combo_gioitinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txt_diachi.Text);
                cmd.Parameters.AddWithValue("@DienThoai", txt_dienthoai.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    loaddl();
                }
                else
                    MessageBox.Show("Cập nhật thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_makh.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã khách hàng để xóa!");
                    return;
                }

                // Hiển thị thông báo xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM tblKhachHang WHERE MaKH = @MaKH", con);
                cmd.Parameters.AddWithValue("@MaKH", txt_makh.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    loaddl();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại hoặc không tìm thấy khách hàng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                txt_makh.DataBindings.Clear();
                txt_hoten.DataBindings.Clear();
                txt_diachi.DataBindings.Clear();
                txt_dienthoai.DataBindings.Clear();
                combo_gioitinh.DataBindings.Clear();

                SqlCommand cmd = new SqlCommand("SELECT * FROM tblKhachHang WHERE HoTen LIKE @HoTen", con);
                cmd.Parameters.AddWithValue("@HoTen", "%" + txt_hoten.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand cmd1 = new SqlCommand
                ($@"SELECT gioiTinh FROM tblKhachHang", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);              

                txt_makh.DataBindings.Add("Text", dt, "MaKH");
                txt_hoten.DataBindings.Add("Text", dt, "HoTen");
                txt_diachi.DataBindings.Add("Text", dt, "DiaChi");
                txt_dienthoai.DataBindings.Add("Text", dt, "DienThoai");
                combo_gioitinh.DataBindings.Add("Text", dt, "gioiTinh");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
        }

     
    }
}
