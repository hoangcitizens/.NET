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

namespace QuanLyThueNhaNhom9
{
    public partial class FormQuanLyHopDong : Form
    {
        SqlConnection conn = new KetNoiCSDL().getCon();
        DataTable dt = new DataTable();
        public FormQuanLyHopDong()
        {
            InitializeComponent();
        }
        public void loaddl()
        {
            txtMaHopDong.DataBindings.Clear();
            txtMaQuanLy.DataBindings.Clear();
            txtTenQuanLy.DataBindings.Clear();
            txtSDTQuanLy.DataBindings.Clear();
            txtEmailQuanLy.DataBindings.Clear();          
            txtTenKhach.DataBindings.Clear();
            txtMaKhach.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtSDTKhach.DataBindings.Clear();
            txtEmail.DataBindings.Clear();

            SqlCommand cmd = new SqlCommand(@"select HopDong.MaHopDong, QuanLy.MaQuanLy,
            HoTenQL, SoDienThoaiQL, EmailQL, KhachHang.MaKhachHang,
            HoTenKH, DiaChiKH, SoDienThoaiKH, EmailKH, DieuKhoanHopDong
            from KhachHang, QuanLy, HopDong
            where HopDong.MaKhachHang = KhachHang.MaKhachHang and HopDong.MaQuanLy = QuanLy.MaQuanLy", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // gắn dữ liệu lên datagridview
            txtMaHopDong.DataBindings.Add("Text", dt,"MaHopDong");
            txtMaQuanLy.DataBindings.Add("Text", dt, "MaQuanLy");
            txtTenQuanLy.DataBindings.Add("Text", dt, "HoTenQL");
            txtSDTQuanLy.DataBindings.Add("Text", dt, "SoDienThoaiQL");
            txtEmailQuanLy.DataBindings.Add("Text", dt, "EmailQL");
            txtTenKhach.DataBindings.Add("Text", dt, "HoTenKH");
            txtMaKhach.DataBindings.Add("Text", dt, "MaKhachHang");
            txtDiaChi.DataBindings.Add("Text", dt, "DiaChiKH");
            txtSDTKhach.DataBindings.Add("Text", dt, "SoDienThoaiKH");
            txtEmail.DataBindings.Add("Text", dt, "EmailKH");
            txtDieuKhoan.DataBindings.Add("Text", dt, "DieuKhoanHopDong");
        }
        private void FormQuanLyHopDong_Load(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(@"select HopDong.MaHopDong, QuanLy.MaQuanLy,
            HoTenQL, SoDienThoaiQL, EmailQL, KhachHang.MaKhachHang,
            HoTenKH, DiaChiKH, SoDienThoaiKH, EmailKH, DieuKhoanHopDong
            from KhachHang, QuanLy, HopDong
            where HopDong.MaKhachHang = KhachHang.MaKhachHang and HopDong.MaQuanLy = QuanLy.MaQuanLy", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            loaddl();
            dataGridView1.DataSource = dt;  
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO HopDong(MaHopDong,MaQuanLy,MaKhachHang,DieuKhoanHopDong) " +
                    "VALUES(@MaHopDong,@MaQuanLy,@MaKhachHang,@DieuKhoanHopDong)", conn);
                cmd.Parameters.AddWithValue("@MaHopDong", txtMaHopDong.Text);
                cmd.Parameters.AddWithValue("@MaQuanLy", txtMaQuanLy.Text);
                cmd.Parameters.AddWithValue("@MaKhachHang", txtMaKhach.Text);
                cmd.Parameters.AddWithValue("@DieuKhoanHopDong", txtDieuKhoan.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    loaddl();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int dongchon = -1;
                dongchon = dataGridView1.CurrentCellAddress.Y;
                if (dongchon >= 0)
                {
                    if (MessageBox.Show("Bạn có muốn sửa hợp đồng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand
                        ("UPDATE HopDong MaHopDong=@MaHopDong,MaQuanLy=@MaQuanLy,MaKhachHang=@MaKhachHang,DieuKhoanHopDong=@DieuKhoanHopDong" +
                        "WHERE MaHopDong = @MaHopDongCu", conn);
                        cmd.Parameters.AddWithValue("@MaHopDong", txtMaHopDong.Text);
                        cmd.Parameters.AddWithValue("@MaQuanLy", txtMaQuanLy.Text);
                        cmd.Parameters.AddWithValue("@MaKhachHang", txtMaKhach.Text);
                        cmd.Parameters.AddWithValue("@DieuKhoanHopDong", txtDieuKhoan.Text);
                        cmd.Parameters.AddWithValue("@MaHopDongCu", dataGridView1.Rows[dongchon].Cells["MaHopDong"].Value.ToString());

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Hợp đồng được sửa thành công");
                            loaddl();
                        }
                        else
                            MessageBox.Show("Sửa hợp đồng thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int dongchon = -1;
                dongchon = dataGridView1.CurrentCellAddress.Y;
                if (dongchon >= 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn xóa hợp đồng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM HopDong WHERE MaHopDong = @MaHopDongCu", conn);
                        cmd.Parameters.AddWithValue("@MaHopDongCu", dataGridView1.Rows[dongchon].Cells["MaHopDong"].Value.ToString());

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Hợp đồng đã xóa khỏi danh sách");
                            loaddl();
                        }
                        else
                            MessageBox.Show("Xóa thất bại");
                    }
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }            
        }
    }
}
