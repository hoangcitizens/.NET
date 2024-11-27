using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._1_Form_VD3
{
    public partial class frmVD3 : Form
    {
        public frmVD3()
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
            double n; if (kiemtra(txtCanh1.Text) ||
            kiemtra(txtCanh2.Text) || kiemtra(txtCanh3.Text)) return
            false;
            if (!double.TryParse(txtCanh1.Text, out n) || n < 0)
                return false;
            if (!double.TryParse(txtCanh2.Text, out n) || n < 0)
                return false;
            if (!double.TryParse(txtCanh3.Text, out n) || n < 0)
                return false;
            return true;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtCanh1.Enabled = true;
            txtCanh2.Enabled = true;
            txtCanh3.Enabled = true;
            groupNhap.Enabled = true;
            txtCanh1.Focus();
        }
        bool kt_tamgiac(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else return false;
        }

        private void rabDienTich_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh1.Enabled = false;
            txtCanh2.Enabled = false; 
            txtCanh3.Enabled = false;
            btnNhap.Enabled = false;
            lbKetQua.Visible = true;
            if (kiemtra_dulieu())
            {
                double a, b, c;
                a = double.Parse(txtCanh1.Text);
                b = double.Parse(txtCanh2.Text);
                c = double.Parse(txtCanh3.Text);
                if (kt_tamgiac(a, b, c))
                {
                    Double p = (a + b + c) / 2;
                    lbKetQua.Text = "Diện tích của tam giác: " +
                    Math.Sqrt(p * (p - a) * (p - b) * (p - c)).ToString("F3");
                }
                else lbKetQua.Text = "Ba cạnh không lập thành tam giác";
            }
            else MessageBox.Show("Dữ liệu chưa hợp lệ", "Thông báo");
        }

        private void rabChuVi_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh1.Enabled = false;
            txtCanh2.Enabled = false;
            txtCanh3.Enabled = false;
            btnNhap.Enabled = false;
            lbKetQua.Visible = true;
            if (kiemtra_dulieu())
            {
                double a, b, c;
                a = double.Parse(txtCanh1.Text); b = double.Parse(txtCanh2.Text);
                c = double.Parse(txtCanh3.Text);
                if (kt_tamgiac(a, b, c))
                    lbKetQua.Text = "Chu vi của tam giác:" +
                    (a + b + c).ToString("F3");
                else lbKetQua.Text = "Ba cạnh không lập thành tam giác";
            }
            else MessageBox.Show("Dữ liệu chưa hợp lệ", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
