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
    public partial class FormQuanLyChuNha : Form
    {
        SqlConnection conn = new KetNoiCSDL().getCon();
        DataTable dt = new DataTable();
        public FormQuanLyChuNha()
        {
            InitializeComponent();
        }
        public void loaddl()
        {
            txtMaNha.DataBindings.Clear();
            txtMaChuNha.DataBindings.Clear();
            txtTenChuNha.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Clear();
            txtThongTinChiTiet.DataBindings.Clear();
            SqlCommand cmd = new SqlCommand(@"Select Nha.MaNha, MaChuNha, HoTenCN, SoDienThoaiCN, EmailCN, ThongTinNha
            from ChuNha, Nha where Nha.MaNha = ChuNha.MaNha", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // gắn dữ liệu DataBindings lên các điều khiển nhập liệu
            txtMaNha.DataBindings.Add("Text", dt, "MaNha");
            txtMaChuNha.DataBindings.Add("Text", dt, "MaChuNha");
            txtTenChuNha.DataBindings.Add("Text", dt, "HoTenCN");
            txtEmail.DataBindings.Add("Text", dt, "EmailCN");
            txtSoDienThoai.DataBindings.Add("Text", dt, "SoDienThoaiCN");
            txtThongTinChiTiet.DataBindings.Add("Text", dt, "ThongTinNha");
        }

        private void FormQuanLyNha_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) // nếu trạng thái đang đóng
                conn.Open();
            // hiển thị dữ liệu lên datagridview
            SqlCommand cmd = new SqlCommand(@"Select Nha.MaNha, MaChuNha, HoTenCN, SoDienThoaiCN, EmailCN, ThongTinNha
            from ChuNha, Nha where Nha.MaNha = ChuNha.MaCNha", conn);
            loaddl();

            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Nha", conn); ;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txtMaChuNha.Text) ||
                string.IsNullOrEmpty(txtTenChuNha.Text) ||
                string.IsNullOrEmpty(txtSoDienThoai.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtMaNha.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            try
            {
                // Tạo SqlCommand và gán các tham số
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO ChuNha(MaChuNha, HoTenCN, SoDienThoaiCN, EmailCN, MaNha) " +
                    "VALUES(@MaChuNha, @HoTenCN, @SoDienThoaiCN, @EmailCN, @MaNha)", conn);
                cmd.Parameters.AddWithValue("@MaChuNha", txtMaChuNha.Text);
                cmd.Parameters.AddWithValue("@HoTenCN", txtTenChuNha.Text);
                cmd.Parameters.AddWithValue("@SoDienThoaiCN", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@EmailCN", txtEmail.Text);
                cmd.Parameters.AddWithValue("@MaNha", txtMaNha.Text);

                // Thực hiện câu truy vấn INSERT
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    loaddl(); // Gọi hàm để tải lại dữ liệu
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentCellAddress.Y;
            if (dongchon >= 0)
            {
                SqlCommand cmd = new SqlCommand
                ("UPDATE ChuNha set MaChuNha = @MaChuNha, HoTenCN=@HoTenCN, SoDienThoaiCN=@SoDienThoaiCN, EmailCN=@EmailCN, MaNha=@MaNha" +
                " WHERE MaChuNha=@MaChuNhaCu", conn);
                cmd.Parameters.AddWithValue("@MaChuNha", txtMaChuNha.Text);
                cmd.Parameters.AddWithValue("@HoTenCN", txtTenChuNha.Text);
                cmd.Parameters.AddWithValue("@SoDienThoaiCN", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@EmailCN", txtEmail.Text);
                cmd.Parameters.AddWithValue("@MaNha", txtMaNha.Text);
                cmd.Parameters.AddWithValue("@MaChuNhaCu", dataGridView1.Rows[dongchon].Cells["MaChuNha"].Value.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    loaddl();
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // nút xóa thông tin
            SqlCommand cmd = new SqlCommand("DELETE FROM ChuNha WHERE MaChuNha = @MaChuNha", conn);
            cmd.Parameters.AddWithValue("@MaChuNha", txtMaChuNha.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa thành công");
                loaddl();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // nút tìm kiếm
            // Kiểm tra xem ô nhập liệu mã nhà có bị trống không
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhà để tìm kiếm.");
                return;
            }

            try
            {
                // Tạo SqlCommand và gán tham số
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM ChuNha WHERE MaNha = @MaNha", conn);
                cmd.Parameters.AddWithValue("@MaNha", txtTimKiem.Text);
                // Tạo DataTable để chứa kết quả truy vấn
                DataTable dt = new DataTable();
                // Sử dụng SqlDataAdapter để lấy dữ liệu
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                // Hiển thị dữ liệu lên DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
