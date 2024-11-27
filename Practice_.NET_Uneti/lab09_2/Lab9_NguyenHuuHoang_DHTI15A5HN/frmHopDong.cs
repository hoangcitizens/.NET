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
    public partial class frmHopDong : Form
    {
        SqlConnection con = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QuanLyBanHang_2024_v3.mdf;
                Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        public frmHopDong()
        {
            InitializeComponent();
        }
        public void loaddl()
        {
            txtSoHieuHopDong.DataBindings.Clear();
            txtMaKH.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            

            SqlCommand cmd = new SqlCommand
            ($@"SELECT * FROM HopDong, KhachHang", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            txtSoHieuHopDong.DataBindings.Add("Text", dt, "SoHieuHD");
            txtMaKH.DataBindings.Add("Text", dt, "MaKh");
            dateTimePicker1.DataBindings.Add("Text", dt, "NgayLap");
        }

        private void Form3_Load(object sender, EventArgs e)
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
                if (string.IsNullOrEmpty(txtSoHieuHopDong.Text) || string.IsNullOrEmpty(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                // Kiểm tra Mã khách hàng tồn tại
                SqlCommand checkCmd = new SqlCommand
                    ($@"SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH", con);
                checkCmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);

                int customerCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (customerCount == 0)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại. Vui lòng kiểm tra lại.");
                    return;
                }

                // Thực hiện thêm mới hợp đồng
                SqlCommand cmd = new SqlCommand
                    ($@"INSERT INTO HopDong (SoHieuHD, MaKH, NgayLap)
                VALUES (@SoHieuHD, @MaKH, @NgayLap)", con);

                cmd.Parameters.AddWithValue("@SoHieuHD", txtSoHieuHopDong.Text);
                cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                cmd.Parameters.AddWithValue("@NgayLap", dateTimePicker1.Value);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm hợp đồng thành công!");
                    loaddl(); // Cập nhật lại danh sách hợp đồng
                }
                else
                {
                    MessageBox.Show("Thêm hợp đồng thất bại.");
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
                if (string.IsNullOrEmpty(txtSoHieuHopDong.Text) || string.IsNullOrEmpty(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                // Kiểm tra xem mã khách hàng tồn tại
                SqlCommand checkCmd = new SqlCommand
                    ($@"SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH", con);
                checkCmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);

                int customerCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (customerCount == 0)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại. Vui lòng kiểm tra lại.");
                    return;
                }

                // Thực hiện cập nhật hợp đồng
                SqlCommand cmd = new SqlCommand
                    ($@"UPDATE HopDong 
                SET MaKH = @MaKH, NgayLap = @NgayLap 
                WHERE SoHieuHD = @SoHieuHD", con);

                cmd.Parameters.AddWithValue("@SoHieuHD", txtSoHieuHopDong.Text);
                cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                cmd.Parameters.AddWithValue("@NgayLap", dateTimePicker1.Value);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    loaddl(); // Cập nhật danh sách
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Số hiệu hợp đồng để cập nhật.");
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
                if (string.IsNullOrEmpty(txtSoHieuHopDong.Text))
                {
                    MessageBox.Show("Vui lòng nhập Số hiệu hợp đồng để xóa!");
                    return;
                }

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand
                        ($@"DELETE FROM HopDong WHERE SoHieuHD = @SoHieuHD", con);
                    cmd.Parameters.AddWithValue("@SoHieuHD", txtSoHieuHopDong.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        loaddl(); // Cập nhật danh sách
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Số hiệu hợp đồng để xóa.");
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
                string query = "SELECT * FROM HopDong WHERE 1 = 1"; // Câu lệnh SQL động
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                if (!string.IsNullOrEmpty(txtMaKH.Text))
                {
                    query += " AND MaKH LIKE @MaKH";
                    cmd.Parameters.AddWithValue("@MaKH", "%" + txtMaKH.Text + "%");
                }

                if (dateTimePicker1.Checked) // Nếu người dùng chọn ngày
                {
                    query += " AND NgayLap = @NgayLap";
                    cmd.Parameters.AddWithValue("@NgayLap", dateTimePicker1.Value.Date);
                }

                cmd.CommandText = query;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable searchResult = new DataTable();
                da.Fill(searchResult);

                if (searchResult.Rows.Count > 0)
                {
                    dataGridView1.DataSource = searchResult; // Hiển thị kết quả tìm kiếm
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hợp đồng nào phù hợp.");
                    dataGridView1.DataSource = null; // Xóa dữ liệu hiển thị cũ
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
