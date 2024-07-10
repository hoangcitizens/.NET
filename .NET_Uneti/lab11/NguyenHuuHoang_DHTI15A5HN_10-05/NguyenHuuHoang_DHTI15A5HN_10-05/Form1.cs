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

namespace NguyenHuuHoang_DHTI15A5HN_10_05
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(
            $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\QLNV.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        public Form1()
        {
            InitializeComponent();
            con.Open();
        }
        void loaddl()
        {
            txtMaNhanVien.DataBindings.Clear();
            txtHoVaTen.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            rabNam.DataBindings.Clear();
            cbPhong.DataBindings.Clear();
            txtChucVu.DataBindings.Clear();
            txtDiaChiPhong.DataBindings.Clear();

            SqlCommand cmd = new SqlCommand
            (@"select MaNhanVien, HoTen, NgaySinh, GioiTinh, HeSoLuong, ChucVu, Phong.MaPhong, TenPhong, DiaChi
            from Phong, NhanVien where Phong.MaPhong = NhanVien.MaPhong", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand cmd1 = new SqlCommand(@"select MaPhong, TenPhong from Phong", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            cbPhong.DataSource = dt1;
            cbPhong.DisplayMember = "TenPhong";
            cbPhong.ValueMember = "MaPhong";

            txtMaNhanVien.DataBindings.Add("Text", dt, "MaNhanVien");
            txtHoVaTen.DataBindings.Add("Text", dt, "HoTen");
            dateTimePicker1.DataBindings.Add("Value", dt, "NgaySinh");         
            rabNam.DataBindings.Add("Checked", dt, "GioiTinh");
            if (rabNam.Checked == false)
                rabNu.Checked = true;
            else
                rabNu.Checked = false;
            cbPhong.DataBindings.Add("SelectedValue", dt, "MaPhong");
            txtChucVu.DataBindings.Add("Text", dt, "ChucVu");
            txtDiaChiPhong.DataBindings.Add("Text", dt, "DiaChi");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // nút thêm
            SqlCommand cmd = new SqlCommand
                ("INSERT INTO NhanVien(MaNhanVien,HoTen,NgaySinh,GioiTinh,HeSoLuong,ChucVu,MaPhong) " +
                "VALUES(@MaNhanVien,@HoTen,@NgaySinh,@GioiTinh,@HeSoLuong,@ChucVu,@MaPhong)", con);
            cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
            cmd.Parameters.AddWithValue("@HoTen", txtHoVaTen.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@GioiTinh", rabNam.Checked);
            cmd.Parameters.AddWithValue("@HeSoLuong", txtMaNhanVien.Text);
            cmd.Parameters.AddWithValue("@ChucVu", txtChucVu.Text);
            cmd.Parameters.AddWithValue("@MaPhong", cbPhong.SelectedValue);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm thành công");
                loaddl();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) // nếu trạng thái đang đóng
                con.Open();
            SqlCommand cmd = new SqlCommand
            (@"select MaNhanVien, HoTen, NgaySinh, GioiTinh, HeSoLuong, ChucVu, Phong.MaPhong, TenPhong, DiaChi 
            from Phong, NhanVien where Phong.MaPhong = NhanVien.MaPhong", con);
            loaddl();         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentCellAddress.Y;
            if (dongchon >= 0)
            {
                SqlCommand cmd = new SqlCommand
                ("UPDATE NhanVien set MaNhanVien=@MaNhanVien, HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, ChucVu=@ChucVu, MaPhong=@MaPhong " +
                "WHERE MaNhanVien=@MaNhanVienCu", con);
                cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoVaTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", rabNam.Checked);         
                cmd.Parameters.AddWithValue("@MaPhong", cbPhong.SelectedValue);            
                cmd.Parameters.AddWithValue("@ChucVu", txtChucVu.Text);
                cmd.Parameters.AddWithValue("@MaNhanVienCu", dataGridView1.Rows[dongchon].Cells["MaNhanVien"].Value.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    loaddl();
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentCellAddress.Y;
            if (dongchon >= 0)
            {
                SqlCommand cmd = new SqlCommand
                    ("DELETE FROM NhanVien where MaNhanVien=@MaNhanVienCu", con);
                cmd.Parameters.AddWithValue("@MaNhanVienCu", dataGridView1.Rows[dongchon].Cells["MaNhanVien"].Value.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    loaddl();
                }
                else
                    MessageBox.Show("Xóathất bại");
            }
        }
        private void btnTìmKiem_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.DataBindings.Clear();
            txtHoVaTen.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            rabNam.DataBindings.Clear();
            cbPhong.DataBindings.Clear();
            txtChucVu.DataBindings.Clear();
            txtDiaChiPhong.DataBindings.Clear();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand($@"select MaNhanVien, HoTen, NgaySinh, GioiTinh, HeSoLuong, ChucVu, Phong.MaPhong, TenPhong, DiaChi 
            from Phong, NhanVien where Phong.MaPhong = NhanVien.MaPhong 
            and HoTen LIKE '%{txtTimKiem.Text}'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand cmd1 = new SqlCommand(@"select MaPhong, TenPhong from Phong", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            cbPhong.DataSource = dt1;
            cbPhong.DisplayMember = "TenPhong";
            cbPhong.ValueMember = "MaPhong";

            txtMaNhanVien.DataBindings.Add("Text", dt, "MaNhanVien");
            txtHoVaTen.DataBindings.Add("Text", dt, "HoTen");
            dateTimePicker1.DataBindings.Add("Value", dt, "NgaySinh");
            rabNam.DataBindings.Add("Checked", dt, "GioiTinh");
            if (rabNam.Checked == false)
                rabNu.Checked = true;
            else
                rabNu.Checked = false;
            cbPhong.DataBindings.Add("SelectedValue", dt, "MaPhong");
            txtChucVu.DataBindings.Add("Text", dt, "ChucVu");
            txtDiaChiPhong.DataBindings.Add("Text", dt, "DiaChi");
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position = 0;
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position = dt.Rows.Count - 1;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position--;
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position++;
        }
    }
}
