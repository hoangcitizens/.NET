using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueNhaNhom9
{
    public partial class FormDangNhap : Form
    {
        TaiKhoanDangNhap tk = new TaiKhoanDangNhap("admin","123");
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tk.DangNhap(txtTaiKhoan.Text,txtMatKhau.Text))
            {
                this.Hide();
                FormTrangChu f1 = new FormTrangChu();             
                f1.Show();           
            }    
            else
            {
                MessageBox.Show("Sai mật khẩu vui lòng đăng nhập lại !!!");
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
