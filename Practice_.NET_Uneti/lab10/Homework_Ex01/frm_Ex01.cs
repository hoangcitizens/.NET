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

namespace Homework_Ex01
{
    public partial class frm_Ex01 : Form
    {
        SqlConnection con = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QuanLySinhVien_Ex01_LAB10.mdf;
                Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        public frm_Ex01()
        {
            InitializeComponent();
            con.Open();
        }
        public void loaddl()
        {
            txtMaSV.DataBindings.Clear();
            txtTenSV.DataBindings.Clear();
            txtGioiTinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtMaSC.DataBindings.Clear();
            txtMaLop.DataBindings.Clear();

            SqlCommand cmd = new SqlCommand
             ($@"SELECT tbSinhVien.MaSV, tbSinhVien.Ten, tbSinhVien.GioiTinh, tbSinhVien.NgaySinh, 
                       tbSinhVien.SDT, tbSinhVien.DiaChi, tbChinhSach.MaCS, tbLop.MaLop 
                FROM tbSinhVien
                INNER JOIN tbChinhSach ON tbChinhSach.MaCS = tbSinhVien.MaCS
                INNER JOIN tbLop ON tbLop.MaLop = tbSinhVien.MaLop", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            txtMaSV.DataBindings.Add("Text", dt, "MaSV");
            txtTenSV.DataBindings.Add("Text", dt, "Ten");
            txtGioiTinh.DataBindings.Add("Text", dt, "GioiTinh");
            txtNgaySinh.DataBindings.Add("Text", dt, "NgaySinh");
            txtSDT.DataBindings.Add("Text", dt, "SDT");
            txtDiaChi.DataBindings.Add("Text", dt, "DiaChi");
            txtMaSC.DataBindings.Add("Text", dt, "MaCS");
            txtMaLop.DataBindings.Add("Text", dt, "MaLop");

            // Hiển thị số lượng sinh viên
            lbSiSo.Text = "Sĩ số: " + dt.Rows.Count.ToString();
        }

        private void frm_Ex01_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            loaddl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô nhập liệu
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtTenSV.Text) ||
                string.IsNullOrWhiteSpace(txtGioiTinh.Text) ||
                string.IsNullOrWhiteSpace(txtNgaySinh.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtMaSC.Text) ||
                string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu vào các ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kết nối và thực hiện câu lệnh thêm dữ liệu
                SqlCommand cmd = new SqlCommand(@"INSERT INTO tbSinhVien 
                                                 (MaSV, Ten, GioiTinh, NgaySinh, SDT, DiaChi, MaCS, MaLop) 
                                                 VALUES (@MaSV, @Ten, @GioiTinh, @NgaySinh, @SDT, @DiaChi, @MaCS, @MaLop)", con);
                {
                    // Gán giá trị từ các ô nhập liệu vào tham số của câu lệnh SQL
                    cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                    cmd.Parameters.AddWithValue("@Ten", txtTenSV.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(txtNgaySinh.Text)); // Đảm bảo định dạng ngày tháng chính xác
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@MaCS", txtMaSC.Text);
                    cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddl(); // Tải lại dữ liệu để cập nhật lên DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Thêm dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô nhập liệu
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtTenSV.Text) ||
                string.IsNullOrWhiteSpace(txtGioiTinh.Text) ||
                string.IsNullOrWhiteSpace(txtNgaySinh.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtMaSC.Text) ||
                string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu vào các ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kết nối và thực hiện câu lệnh cập nhật dữ liệu
                SqlCommand cmd = new SqlCommand(@"UPDATE tbSinhVien 
                                          SET Ten = @Ten, 
                                              GioiTinh = @GioiTinh, 
                                              NgaySinh = @NgaySinh, 
                                              SDT = @SDT, 
                                              DiaChi = @DiaChi, 
                                              MaCS = @MaCS, 
                                              MaLop = @MaLop 
                                          WHERE MaSV = @MaSV", con);

                // Gán giá trị từ các ô nhập liệu vào tham số của câu lệnh SQL
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@Ten", txtTenSV.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);

                DateTime ngaySinh;
                if (DateTime.TryParse(txtNgaySinh.Text, out ngaySinh))
                {
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                }
                else
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@MaCS", txtMaSC.Text);
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddl(); // Tải lại dữ liệu để cập nhật lên DataGridView
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô MaSV trống
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận từ người dùng trước khi xóa
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }

            try
            {
                // Đảm bảo kết nối đã mở
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Tạo lệnh SQL cho câu lệnh DELETE
                SqlCommand cmd = new SqlCommand(@"DELETE FROM tbSinhVien WHERE MaSV = @MaSV", con);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);

                // Thực thi câu lệnh
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddl(); // Tải lại dữ liệu để cập nhật lên DataGridView
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng kết nối
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
