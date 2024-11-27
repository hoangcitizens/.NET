using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._1_Form_VD2
{
    public partial class frmVD2 : Form
    {
        public frmVD2()
        {
            InitializeComponent();
        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }
        bool kiemtra_dulieu()
        {
            int n;
            if (kiemtra(txtSoThuNhat.Text) || kiemtra(txtSoThuHai.Text)) return
            false;
            if (!int.TryParse(txtSoThuNhat.Text, out n) || n < 0) return
            false;
            if (!int.TryParse(txtSoThuHai.Text, out n) || n < 0) return
            false;
            return true;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtSoThuNhat.Enabled = true;
            txtSoThuHai.Enabled = true;
            txtSoThuNhat.Focus();
            btnBCNN.Enabled = true;
            btnUCLN.Enabled = true;
        }
        int ucln(int a, int b)
        {
            while (a != b)
                if (a > b) a = a - b;
                else b = b - a;
            return a;
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            btnNhap.Enabled = false;
            if (kiemtra_dulieu())
            {
                txtUCLN.Text = ucln(int.Parse(txtSoThuNhat.Text),
                int.Parse(txtSoThuHai.Text)).ToString();
            }
            else MessageBox.Show("Nhập sai dữ liệu", "Thông báo");
        }

        private void btnBCNN_Click(object sender, EventArgs e)
        {
            btnNhap.Enabled = false;
            if (kiemtra_dulieu())
            {
                int s1, s2;
                s1 = int.Parse(txtSoThuNhat.Text);
                s2 = int.Parse(txtSoThuHai.Text);
                int n = ucln(s1, s2);
                txtBCNN.Text = ((s1 * s2) / n).ToString();
            }
            else MessageBox.Show("Nhập sai dữ liệu", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
