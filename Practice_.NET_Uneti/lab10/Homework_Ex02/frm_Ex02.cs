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

namespace Homework_Ex02
{
    public partial class frm_Ex02 : Form
    {
        SqlConnection con = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QuanLyHangHoa_Ex02_LAB10.mdf;
                Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        public frm_Ex02()
        {
            InitializeComponent();
            con.Open();
        }
        public void loaddl()
        {
            txtMaHang.DataBindings.Clear();
            txtTenHang.DataBindings.Clear();
            txtDonViTinh.DataBindings.Clear();
            txtDonGia.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();

            SqlCommand cmd = new SqlCommand
             ($@"SELECT * FROM tbHangHoa", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            txtMaHang.DataBindings.Add("Text", dt, "MaHang");
            txtTenHang.DataBindings.Add("Text", dt, "TenHang");
            txtDonViTinh.DataBindings.Add("Text", dt, "DonViTinh");
            txtDonGia.DataBindings.Add("Text", dt, "DonGia");
            txtSoLuong.DataBindings.Add("Text", dt, "SoLuong");
        }

        private void frm_Ex02_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            loaddl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô nhập liệu
            if (string.IsNullOrWhiteSpace(txtMaHang.Text) ||
                string.IsNullOrWhiteSpace(txtTenHang.Text) ||
                string.IsNullOrWhiteSpace(txtDonViTinh.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu vào các ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kết nối và thực hiện câu lệnh thêm dữ liệu
                SqlCommand cmd = new SqlCommand(@"INSERT INTO tbHangHoa 
                                         (MaHang, TenHang, DonViTinh, DonGia, SoLuong) 
                                         VALUES (@MaHang, @TenHang, @DonViTinh, @DonGia, @SoLuong)", con);
                {
                    // Gán giá trị từ các ô nhập liệu vào tham số của câu lệnh SQL
                    cmd.Parameters.AddWithValue("@MaHang", txtMaHang.Text);
                    cmd.Parameters.AddWithValue("@TenHang", txtTenHang.Text);
                    cmd.Parameters.AddWithValue("@DonViTinh", txtDonViTinh.Text);
                    cmd.Parameters.AddWithValue("@DonGia", decimal.Parse(txtDonGia.Text)); // Chuyển đổi sang kiểu decimal
                    cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text)); // Chuyển đổi sang kiểu int

                    // Kiểm tra xem lệnh thêm có thành công hay không
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
            if (string.IsNullOrWhiteSpace(txtMaHang.Text) ||
                string.IsNullOrWhiteSpace(txtTenHang.Text) ||
                string.IsNullOrWhiteSpace(txtDonViTinh.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu vào các ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kết nối và thực hiện câu lệnh cập nhật dữ liệu
                SqlCommand cmd = new SqlCommand(@"UPDATE tbHangHoa 
                                         SET TenHang = @TenHang, 
                                             DonViTinh = @DonViTinh, 
                                             DonGia = @DonGia, 
                                             SoLuong = @SoLuong 
                                         WHERE MaHang = @MaHang", con);

                // Gán giá trị từ các ô nhập liệu vào tham số của câu lệnh SQL
                cmd.Parameters.AddWithValue("@MaHang", txtMaHang.Text);
                cmd.Parameters.AddWithValue("@TenHang", txtTenHang.Text);
                cmd.Parameters.AddWithValue("@DonViTinh", txtDonViTinh.Text);
                cmd.Parameters.AddWithValue("@DonGia", decimal.Parse(txtDonGia.Text));
                cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));

                // Kiểm tra xem lệnh cập nhật có thành công hay không
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
            // Kiểm tra xem mã hàng đã được nhập hay chưa
            if (string.IsNullOrWhiteSpace(txtMaHang.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi người dùng xác nhận trước khi xóa
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                // Kết nối và thực hiện câu lệnh xóa dữ liệu
                SqlCommand cmd = new SqlCommand("DELETE FROM tbHangHoa WHERE MaHang = @MaHang", con);
                cmd.Parameters.AddWithValue("@MaHang", txtMaHang.Text);

                // Kiểm tra xem lệnh xóa có thành công hay không
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddl(); // Tải lại dữ liệu để cập nhật lên DataGridView
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
