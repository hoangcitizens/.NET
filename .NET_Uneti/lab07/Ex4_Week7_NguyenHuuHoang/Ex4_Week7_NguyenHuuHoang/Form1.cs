using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4_Week7_NguyenHuuHoang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Button Tính(btnTinh): Tính toán và xuất kết quả ra TextBox txtKQ.
        // TÌM UCLN VÀ BCNN
        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int m = int.Parse(txtM.Text);
            // Tìm ước chung của n và m
            if (rad1.Checked == true)
            {
                txtKQ.Clear();
                for (int i = 1; i <= Math.Min(n,m); i++)
                {
                    if (n % i == 0 && m % i == 0)
                    {
                        txtKQ.Text += i.ToString() + ", ";
                    }    
                }    
            }   
            // Tìm UCLN của n và m
            else if (rad2.Checked)
            {
                txtKQ.Clear();
                if (n == 0 || m == 0)
                    txtKQ.Text = (n + m).ToString();
                while (n != m)
                {
                    if (n > m)
                        n -= m;
                    else
                        m -= n;
                }
                txtKQ.Text += n.ToString();
            }    
        }

        // Button Xóa: Xóa trống tất cả các TextBox, đưa con trỏ vào ô txtN.
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtM.Clear();
            txtKQ.Clear();
            txtN.Focus();
        }

        // Button Thoát: Dừng chương trình.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
