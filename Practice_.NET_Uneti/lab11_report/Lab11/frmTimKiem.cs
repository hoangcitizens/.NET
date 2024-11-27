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

namespace Lab11
{
    public partial class frmTimKiem : Form
    {
        SqlConnection con = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QuanLySinhVien_LAB11.mdf;
                Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        public void loaddl()
        {         
            SqlCommand cmd = new SqlCommand
             ($@"SELECT * FROM tbSinhVien", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dgvsinhvien.DataSource = dt;
        }
        public frmTimKiem()
        {
            InitializeComponent();
            con.Open();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
            txttk.Focus();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmTimKiem_Load(sender, e);
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            //loaddl();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            // Lấy từ khóa từ ô tìm kiếm
            string keyword = txttk.Text.Trim();

            // Câu lệnh SQL với điều kiện tìm kiếm
            SqlCommand cmd = new SqlCommand($@"SELECT * FROM tbSinhVien WHERE DiaChi LIKE @keyword", con);

            // Sử dụng tham số để tránh SQL Injection
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            // Khởi tạo SqlDataAdapter và đổ dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);

            // Gán DataTable vào DataGridView để hiển thị kết quả
            dgvsinhvien.DataSource = dt;
        }
    }
}
