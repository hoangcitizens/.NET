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

namespace Homework_Ex03
{
    public partial class frm_Ex03 : Form
    {
        SqlConnection con = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QuanLyDiemHocSinh_Ex03_LAB10.mdf;
                Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        public frm_Ex03()
        {
            InitializeComponent();
            con.Open();
        }
        public void loaddl()
        {
            txtMaHocSinh.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtDiemToan.DataBindings.Clear();
            txtDiemViet.DataBindings.Clear();

            SqlCommand cmd = new SqlCommand
             ($@"SELECT * FROM tbDiemHocSinh", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            txtMaHocSinh.DataBindings.Add("Text", dt, "MaHocSinh");
            txtHoTen.DataBindings.Add("Text", dt, "TenHocSinh");
            txtDiemToan.DataBindings.Add("Text", dt, "DiemToan");
            txtDiemViet.DataBindings.Add("Text", dt, "DiemViet");
        }

        private void frm_Ex03_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            loaddl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô nhập liệu để đảm bảo không có ô nào bị bỏ trống
            if (string.IsNullOrWhiteSpace(txtMaHocSinh.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiemToan.Text) ||
                string.IsNullOrWhiteSpace(txtDiemViet.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu vào các ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Chuyển đổi điểm toán và điểm viết sang kiểu số
                double diemToan = double.Parse(txtDiemToan.Text);
                double diemViet = double.Parse(txtDiemViet.Text);

                // Tạo câu lệnh SQL thêm bản ghi mới vào tbDiemHocSinh
                SqlCommand cmd = new SqlCommand(@"INSERT INTO tbDiemHocSinh 
                                          (MaHocSinh, TenHocSinh, DiemToan, DiemViet) 
                                          VALUES (@MaHocSinh, @TenHocSinh, @DiemToan, @DiemViet)", con);

                // Gán giá trị cho các tham số
                cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHocSinh.Text);
                cmd.Parameters.AddWithValue("@TenHocSinh", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@DiemToan", diemToan);
                cmd.Parameters.AddWithValue("@DiemViet", diemViet);

                // Thực thi câu lệnh và kiểm tra kết quả
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddl(); // Tải lại dữ liệu để cập nhật DataGridView
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có mã học sinh nào được chọn
            if (string.IsNullOrWhiteSpace(txtMaHocSinh.Text))
            {
                MessageBox.Show("Vui lòng chọn học sinh để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận việc xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa học sinh này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Tạo câu lệnh SQL để xóa bản ghi khỏi tbDiemHocSinh dựa trên MaHocSinh
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbDiemHocSinh WHERE MaHocSinh = @MaHocSinh", con);
                    cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHocSinh.Text);

                    // Thực thi câu lệnh và kiểm tra kết quả
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddl(); // Tải lại dữ liệu để cập nhật DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
