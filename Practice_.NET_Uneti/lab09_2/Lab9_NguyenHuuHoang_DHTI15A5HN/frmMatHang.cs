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
    public partial class frmMatHang : Form
    {
        SqlConnection con = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QuanLyBanHang_2024_v3.mdf;
                Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        public frmMatHang()
        {
            InitializeComponent();
        }
        public void loaddl()
        {
            txt_mamh.DataBindings.Clear();
            txt_tenmh.DataBindings.Clear();
            txt_dvtinh.DataBindings.Clear();
            txt_dongia.DataBindings.Clear();
           
            SqlCommand cmd = new SqlCommand
            ($@"SELECT * FROM MatHang", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            txt_mamh.DataBindings.Add("Text", dt, "MaMH");
            txt_tenmh.DataBindings.Add("Text", dt, "TenMH");
            txt_dvtinh.DataBindings.Add("Text", dt, "DonViTinh");
            txt_dongia.DataBindings.Add("Text", dt, "DonGia");         
        }

        private void Form2_Load(object sender, EventArgs e)
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
                if (string.IsNullOrEmpty(txt_mamh.Text) || string.IsNullOrEmpty(txt_tenmh.Text) || string.IsNullOrEmpty(txt_dvtinh.Text) || string.IsNullOrEmpty(txt_dongia.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                SqlCommand cmd = new SqlCommand
                    ("INSERT INTO MatHang(MaMH, TenMH, DonViTinh, DonGia)" +
                    "VALUES(@MaMH, @TenMH, @DonViTinh, @DonGia)", con);
                cmd.Parameters.AddWithValue("@MaMH", txt_mamh.Text);
                cmd.Parameters.AddWithValue("@TenMH", txt_tenmh.Text);
                cmd.Parameters.AddWithValue("@DonViTinh", txt_dvtinh.Text);
                cmd.Parameters.AddWithValue("@DonGia", txt_dongia.Text);               
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
                if (string.IsNullOrEmpty(txt_mamh.Text) || string.IsNullOrEmpty(txt_tenmh.Text) || string.IsNullOrEmpty(txt_dvtinh.Text) || string.IsNullOrEmpty(txt_dongia.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                SqlCommand cmd = new SqlCommand
                    ("UPDATE MatHang " +
                    "SET TenMH = @TenMH, DonViTinh = @DonViTinh, DonGia = @DonGia " +
                    "WHERE MaMH = @MaMH", con);

                cmd.Parameters.AddWithValue("@MaMH", txt_mamh.Text);
                cmd.Parameters.AddWithValue("@TenMH", txt_tenmh.Text);
                cmd.Parameters.AddWithValue("@DonViTinh", txt_dvtinh.Text);
                cmd.Parameters.AddWithValue("@DonGia", txt_dongia.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    loaddl();
                }
                else
                    MessageBox.Show("Cập nhật thất bại. Vui lòng kiểm tra mã mặt hàng.");
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
                if (string.IsNullOrEmpty(txt_mamh.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã mặt hàng để xóa!");
                    return;
                }

                // Xác nhận người dùng có chắc chắn muốn xóa hay không
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM MatHang WHERE MaMH = @MaMH", con);
                    cmd.Parameters.AddWithValue("@MaMH", txt_mamh.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        loaddl(); // Cập nhật lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại. Vui lòng kiểm tra mã mặt hàng.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_tenmh.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên mặt hàng để tìm kiếm!");
                    return;
                }

                SqlCommand cmd = new SqlCommand
                    ("SELECT * FROM MatHang WHERE TenMH LIKE @TenMH", con);
                cmd.Parameters.AddWithValue("@TenMH", "%" + txt_tenmh.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt; // dgvMatHang là DataGridView để hiển thị kết quả
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mặt hàng nào phù hợp.");
                    dataGridView1.DataSource = null; // Xóa dữ liệu cũ
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
