using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._1_Form_VD4
{
    public partial class frmVD4 : Form
    {
        public frmVD4()
        {
            InitializeComponent();
        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }
        // Viết mã lệnh cho hàm kiểm tra sự hợp lệ của dữ liệu nhập vào
        bool kiemtra_dulieu()
        {
            int n;
            if (kiemtra(txtNhap.Text)) return false;
            if (!int.TryParse(txtNhap.Text, out n) || n <= 0) return
            false;
            return true;
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            groupLuaChon.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (kiemtra_dulieu())
            {
                int S = 0, r; 
                lbKetQua.Enabled = true;
                int n = int.Parse(txtNhap.Text);
                while (n != 0)
                {
                    r = n % 10;
                    S += r;
                    n = n / 10;
                }
                lbKetQua.Text = "Tổng các chữ số của n là : " +
                S.ToString();
            }
            else
            {
                MessageBox.Show("Nhập sai n", "Thông báo");
                txtNhap.Focus();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (kiemtra_dulieu())
            {
                float S = 0; lbKetQua.Enabled = true; int n = int.Parse(txtNhap.Text);
                for (int i = 1; i <= n; i++) S += 1.0f / i;
                lbKetQua.Text = "Tổng các chữ số của n là : " +
                S.ToString("F3");
            }
            else
            {
                MessageBox.Show("Nhập sai n", "Thông báo");
                txtNhap.Focus();
            }
        }
    }
}
