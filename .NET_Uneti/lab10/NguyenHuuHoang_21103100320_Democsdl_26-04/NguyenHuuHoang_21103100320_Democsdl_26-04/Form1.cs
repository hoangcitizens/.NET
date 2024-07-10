using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace NguyenHuuHoang_21103100320_Democsdl_26_04
{
    public partial class Form1 : Form
    {
        // kết nối csdl
        SqlConnection con = new SqlConnection(
            $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\QLSV.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
            //con.Open(); // mở kết nối
        }

        void loaddl() // thêm sửa xóa để xóa dữ liệu
        {
            txtMaSv.DataBindings.Clear();
            txtHoVaTen.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            radNam.DataBindings.Clear();
            cbKhoa.DataBindings.Clear();
            SqlCommand cmd = new SqlCommand(@"select MaSV, HoTen, NgaySinh, GioiTinh, 
            Khoa.MaKhoa, TenKhoa, DiemTB, HocBong from Khoa,
            SinhVien where Khoa.MaKhoa = SinhVien.MaKhoa", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // gắn dữ liệu DataBindings lên các điều khiển nhập liệu
            txtMaSv.DataBindings.Add("Text", dt, "MaSV");
            txtHoVaTen.DataBindings.Add("Text", dt, "HoTen");
            dateTimePicker1.DataBindings.Add("Value", dt, "NgaySinh");
            radNam.DataBindings.Add("Checked", dt, "GioiTinh");
            if (radNam.Checked == false)
                radNu.Checked = true;
            else
                radNu.Checked = false;
            //cbKhoa.DataBindings.Add("SelectedValue", dt, "MaKhoa");

            SqlDataAdapter da1 = new SqlDataAdapter("select MaKhoa, TenKhoa from Khoa", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbKhoa.DataSource = dt1;
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) // nếu trạng thái đang đóng
                con.Open();
            // hiển thị dữ liệu lên datagridview
            SqlCommand cmd = new SqlCommand(@"select MaSV, HoTen, NgaySinh, GioiTinh, Khoa.MaKhoa, TenKhoa from Khoa, SinhVien where Khoa.MaKhoa = SinhVien.MaKhoa", con);
            loaddl();

            SqlDataAdapter da1 = new SqlDataAdapter("select MaKhoa, TenKhoa from Khoa", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbKhoa.DataSource = dt1;
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // bắt người dùng nhập đầy đủ
            if (radNam.Checked == false && radNu.Checked == false)
            {

            }    
            // nút thêm
            SqlCommand cmd = new SqlCommand
                ("INSERT INTO SinhVien(MaSV,HoTen,NgaySinh,GioiTinh,MaKhoa) " +
                "VALUES(@MaSV,@HoTen,@NgaySinh,@GioiTinh,@MaKhoa)", con);
            cmd.Parameters.AddWithValue("@MaSV", txtMaSv.Text);
            cmd.Parameters.AddWithValue("@HoTen", txtHoVaTen.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@GioiTinh", radNam.Checked);
            cmd.Parameters.AddWithValue("@MaKhoa", cbKhoa.SelectedValue);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm thành công");
                loaddl();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }
        /*
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongchon = 1;
            dongchon = dataGridView1.CurrentCellAddress.Y;
            if (dongchon >= 0)
            {
                txtMaSv.Text = dataGridView1.Rows[dongchon].Cells["MaSV"].Value.ToString();
                txtHoVaTen.Text = dataGridView1.Rows[dongchon].Cells["HoTen"].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[dongchon].Cells["NgaySinh"].Value.ToString());
                bool gt = bool.Parse(dataGridView1.Rows[dongchon].Cells["GioiTinh"].Value.ToString());
                if (gt == true)
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
                cbKhoa.SelectedValue = dataGridView1.Rows[dongchon].Cells["MaKhoa"].Value;
            }
        }
        */
        private void button3_Click(object sender, EventArgs e)
        {
            // sửa
            int dongchon = -1;
            dongchon = dataGridView1.CurrentCellAddress.Y;
            if (dongchon >= 0)
            {
                SqlCommand cmd = new SqlCommand
                ("UPDATE SinhVien set MaSV = @MaSV, HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, MaKhoa=@MaKhoa WHERE MaSV=@MaSVCu", con);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSv.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoVaTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", radNam.Checked);
                cmd.Parameters.AddWithValue("@MaKhoa", cbKhoa.SelectedValue);
                cmd.Parameters.AddWithValue("@MaSVCu", dataGridView1.Rows[dongchon].Cells["MaSV"].Value.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    loaddl();
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // xóa
        }

        // Thống kê tìm kiếm theo cột (Dùng GROUP BY)
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"select SinhVien.MaKhoa, TenKhoa,
            count(MaSV) as SoSV
            from SinhVien, Khoa
            where SinhVien.MaKhoa = Khoa.MaKhoa
            group by SinhVien.MaKhoa, TenKhoa having count(MaSV)>1", con);
            DataTable dttk = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dttk);
            dataGridView2.DataSource = dttk;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        // Thêm học bổng bằng UPDATE
        private void button10_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE SinhVien set HocBong = case
            when DiemTB >= 7 and DiemTB<8 then 1000000
            when DiemTB >= 8 and DiemTB<9 then 2000000
            when DiemTB >= 9 and DiemTB<10 then 5000000
            else 0
            End ", con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật học bổng thành công");
                loaddl();
            }
            else
                MessageBox.Show("Cập nhật thất bại");
        }
    }
}
