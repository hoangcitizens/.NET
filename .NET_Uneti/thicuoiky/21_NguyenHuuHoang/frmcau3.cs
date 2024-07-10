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

namespace _21_NguyenHuuHoang
{
    public partial class frmcau3 : Form
    {
        SqlConnection con = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\qlsinhvien_NguyenHuuHoang.mdf;
                Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        
        public frmcau3()
        {
            InitializeComponent();
            con.Open();
        }

        public void loaddl()
        {
            txtMaSinhVien.DataBindings.Clear();
            txtTenSinhVien.DataBindings.Clear();
            rbNam.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            cbLop.DataBindings.Clear();

            SqlCommand cmd = new SqlCommand
            ($@"SELECT maSv, tenSv, gioiTinh, ngaySinh, Lop.maLop, tenLop FROM sinhvien, Lop 
                WHERE Lop.maLop = sinhvien.maLop", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand cmd1 = new SqlCommand
            ($@"SELECT maLop, tenLop FROM Lop", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);         
            da1.Fill(dt1);
            cbLop.DataSource = dt1;
            cbLop.DisplayMember = "tenLop";
            cbLop.ValueMember = "maLop";

            txtMaSinhVien.DataBindings.Add("Text",dt,"maSv");
            txtTenSinhVien.DataBindings.Add("Text", dt, "tenSv");
            rbNam.DataBindings.Add("Checked", dt, "gioiTinh");
            dateTimePicker1.DataBindings.Add("Value", dt, "ngaySinh");
            cbLop.DataBindings.Add("SelectedValue", dt, "maLop");
        }

        private void frmcau3_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            loaddl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaSinhVien.Text) || string.IsNullOrEmpty(txtTenSinhVien.Text) 
                    || cbLop.SelectedValue == null || rbNam.Checked == false && rbNu.Checked == false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                SqlCommand cmd = new SqlCommand
                    ("INSERT INTO sinhvien(maSv, tenSv, gioiTinh, ngaySinh, maLop)" +
                    "VALUES(@maSv, @tenSv, @gioiTinh, @ngaySinh, @maLop)", con);
                cmd.Parameters.AddWithValue("@maSv", txtMaSinhVien.Text);
                cmd.Parameters.AddWithValue("@tenSv", txtTenSinhVien.Text);
                cmd.Parameters.AddWithValue("@gioiTinh", rbNam.Checked);
                cmd.Parameters.AddWithValue("@ngaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@maLop", cbLop.SelectedValue);
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
                MessageBox.Show("Có lỗi xảy ra "+ ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaSinhVien.Text) || string.IsNullOrEmpty(txtTenSinhVien.Text)
                    || cbLop.SelectedValue == null || rbNam.Checked == false && rbNu.Checked == false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                else
                {
                    int dongchon = -1;
                    dongchon = dataGridView1.CurrentCellAddress.Y;
                    if (dongchon >= 0)
                    {
                        SqlCommand cmd = new SqlCommand
                        ("UPDATE sinhvien set maSv=@maSv, tenSv=@tenSv, gioiTinh=@gioiTinh, ngaySinh=@ngaySinh, " +
                        "maLop=@maLop WHERE maSv = @maSvCu", con);
                        cmd.Parameters.AddWithValue("@maSv", txtMaSinhVien.Text);
                        cmd.Parameters.AddWithValue("@tenSv", txtTenSinhVien.Text);
                        cmd.Parameters.AddWithValue("@gioiTinh", rbNam.Checked);
                        cmd.Parameters.AddWithValue("@ngaySinh", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@maLop", cbLop.SelectedValue);
                        cmd.Parameters.AddWithValue("@maSvCu", dataGridView1.Rows[dongchon].Cells["maSv"].Value.ToString());
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Sửa thành công");
                            loaddl();
                        }
                        else
                            MessageBox.Show("Sửa thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn 1 dòng cần sửa");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
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
                    SqlCommand cmd = new SqlCommand
                    ("DELETE FROM sinhvien WHERE maSv = @maSvCu", con);
                    cmd.Parameters.AddWithValue("@maSvCu", dataGridView1.Rows[dongchon].Cells["maSv"].Value.ToString());
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        loaddl();
                    }
                    else
                        MessageBox.Show("Xóa thất bại");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 dòng cần xóa");
                } 
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaSinhVien.DataBindings.Clear();
                txtTenSinhVien.DataBindings.Clear();
                rbNam.DataBindings.Clear();
                dateTimePicker1.DataBindings.Clear();
                cbLop.DataBindings.Clear();

                SqlCommand cmd = new SqlCommand
                ($@"SELECT maSv, tenSv, gioiTinh, ngaySinh, Lop.maLop, tenLop 
                FROM sinhvien, Lop 
                WHERE Lop.maLop = sinhvien.maLop
                and tenSv LIKE '%{txtTimKiem.Text}'", con); // tìm kiếm theo tên
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand cmd1 = new SqlCommand
                ($@"SELECT maLop, tenLop FROM Lop", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                da1.Fill(dt1);
                cbLop.DataSource = dt1;
                cbLop.DisplayMember = "tenLop";
                cbLop.ValueMember = "maLop";

                txtMaSinhVien.DataBindings.Add("Text", dt, "maSv");
                txtTenSinhVien.DataBindings.Add("Text", dt, "tenSv");
                rbNam.DataBindings.Add("Checked", dt, "gioiTinh");
                dateTimePicker1.DataBindings.Add("Value", dt, "ngaySinh");
                cbLop.DataBindings.Add("SelectedValue", dt, "maLop");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position = 0;
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position = dt.Rows.Count - 1;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position--;
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position++;
        }
    }
}
