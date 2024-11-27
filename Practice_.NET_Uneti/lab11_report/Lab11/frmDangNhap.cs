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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab11
{
    public partial class frmDangNhap : Form
    {
        SqlConnection con = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QuanLySinhVien_LAB11.mdf;
                Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        public frmDangNhap()
        {
            InitializeComponent();
            txtPassWord.UseSystemPasswordChar = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtPassWord.Text = "";
            txtUserName.Clear();
            txtUserName.Focus();
        }

        private void chkhienan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhienan.Checked == true)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text;
            string pass = txtPassWord.Text;
            if (user == "")
            {
                MessageBox.Show("Bạn phải nhập username vào!", "Đăng nhập");
                txtUserName.Focus();
            }
            else if (pass == "")
            {
                MessageBox.Show("Bạn phải nhập Password vào!", "Đăng nhập");
                txtPassWord.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "SELECT * FROM login WHERE username = '" + user + "' AND password = '" + pass + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.Read() == true)
                    {
                        MessageBox.Show("Bạn đăng nhập thành công!", "Đăng nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        frmQuanLySinhVien f = new frmQuanLySinhVien();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản chưa có, hoặc bạn nhập sai Username hoặc Password", "Đăng nhập");
                        txtUserName.Text = "";
                        txtPassWord.Text = "";
                        txtUserName.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}

