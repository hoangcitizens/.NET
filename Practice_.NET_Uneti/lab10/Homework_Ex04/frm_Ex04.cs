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

namespace Homework_Ex04
{
    public partial class frm_Ex04 : Form
    {
        SqlConnection con = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QuanLyHoaDonDien_Ex04_LAB10.mdf;
                Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        public frm_Ex04()
        {
            InitializeComponent();
            con.Open();
        }
        public void loaddl()
        {
            txtSoCongTo.DataBindings.Clear();
            txtTenChuHo.DataBindings.Clear();
            txtSoCu.DataBindings.Clear();
            txtSoMoi.DataBindings.Clear();
            txtDonGia.DataBindings.Clear();

            SqlCommand cmd = new SqlCommand
             ($@"SELECT * FROM tbHoaDon", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            txtSoCongTo.DataBindings.Add("Text", dt, "SoCongTo");
            txtTenChuHo.DataBindings.Add("Text", dt, "TenChuHo");
            txtSoCu.DataBindings.Add("Text", dt, "SoCu");
            txtSoMoi.DataBindings.Add("Text", dt, "SoMoi");
            txtDonGia.DataBindings.Add("Text", dt, "DonGia");
        }

        private void frm_Ex04_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            loaddl();
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô nhập liệu
            if (string.IsNullOrWhiteSpace(txtSoCongTo.Text) ||
                string.IsNullOrWhiteSpace(txtTenChuHo.Text) ||
                string.IsNullOrWhiteSpace(txtSoCu.Text) ||
                string.IsNullOrWhiteSpace(txtSoMoi.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu vào các ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kết nối và thực hiện câu lệnh thêm dữ liệu
                SqlCommand cmd = new SqlCommand(@"INSERT INTO tbHoaDon 
                                          (SoCongTo, TenChuHo, SoCu, SoMoi, DonGia) 
                                          VALUES (@SoCongTo, @TenChuHo, @SoCu, @SoMoi, @DonGia)", con);

                // Gán giá trị từ các ô nhập liệu vào tham số của câu lệnh SQL
                cmd.Parameters.AddWithValue("@SoCongTo", txtSoCongTo.Text);
                cmd.Parameters.AddWithValue("@TenChuHo", txtTenChuHo.Text);
                cmd.Parameters.AddWithValue("@SoCu", int.Parse(txtSoCu.Text));
                cmd.Parameters.AddWithValue("@SoMoi", int.Parse(txtSoMoi.Text));
                cmd.Parameters.AddWithValue("@DonGia", decimal.Parse(txtDonGia.Text));

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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaDoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô nhập liệu
            if (string.IsNullOrWhiteSpace(txtSoCongTo.Text) ||
                string.IsNullOrWhiteSpace(txtTenChuHo.Text) ||
                string.IsNullOrWhiteSpace(txtSoCu.Text) ||
                string.IsNullOrWhiteSpace(txtSoMoi.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu vào các ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kết nối và thực hiện câu lệnh cập nhật dữ liệu
                SqlCommand cmd = new SqlCommand(@"UPDATE tbHoaDon 
                                          SET TenChuHo = @TenChuHo, 
                                              SoCu = @SoCu, 
                                              SoMoi = @SoMoi, 
                                              DonGia = @DonGia 
                                          WHERE SoCongTo = @SoCongTo", con);

                // Gán giá trị từ các ô nhập liệu vào tham số của câu lệnh SQL
                cmd.Parameters.AddWithValue("@SoCongTo", txtSoCongTo.Text);
                cmd.Parameters.AddWithValue("@TenChuHo", txtTenChuHo.Text);
                cmd.Parameters.AddWithValue("@SoCu", int.Parse(txtSoCu.Text));
                cmd.Parameters.AddWithValue("@SoMoi", int.Parse(txtSoMoi.Text));
                cmd.Parameters.AddWithValue("@DonGia", decimal.Parse(txtDonGia.Text));

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
    }
}
