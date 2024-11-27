using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._4_TongHopForm_VD3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_a.ResetText();
            txt_b.ResetText();
            txt_c.ResetText();
            txt_d.ResetText();
            txt_e.ResetText(); txt_f.ResetText();
            txt_a.Focus();
        }

        // Viết mã lệnh cho hàm kiểm tra chuỗi rỗng
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }

        // Viết mã lệnh cho hàm kiểm tra dữ liệu nhập vào
        bool kiemtra_dulieu(string s)
        {
            double so;
            if (kiemtra(txt_a.Text) || kiemtra(txt_b.Text) ||
            kiemtra(txt_c.Text) || kiemtra(txt_d.Text) || kiemtra(txt_e.Text
            ) || kiemtra(txt_f.Text)) return false;
            if (!double.TryParse(txt_a.Text, out so)) return false;
            if (!double.TryParse(txt_b.Text, out so)) return false;
            if (!double.TryParse(txt_c.Text, out so)) return false;
            if (!double.TryParse(txt_d.Text, out so)) return false;
            if (!double.TryParse(txt_e.Text, out so)) return false;
            if (!double.TryParse(txt_f.Text, out so)) return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kiemtra_dulieu(""))
            {
                double a, b, c, d, ex, f;
                a = double.Parse(txt_a.Text);
                b = double.Parse(txt_b.Text);
                c = double.Parse(txt_c.Text);
                d = double.Parse(txt_d.Text);
                ex = double.Parse(txt_e.Text);
                f = double.Parse(txt_f.Text);
                txt_ketqua.Text = "";
                double D, Dx, Dy;
                D = a * d - b * c;
                Dx = ex * d - b * f;
                Dy = a * f - ex * c;
                if (D != 0)
                    txt_ketqua.Text += "\nHệ phương trình có nghiệm duy nhất:\nx = "
                        + (Dx / D).ToString() + "\ny = " + (Dy / D).ToString();
                else if 
                    (Dx == 0 && Dy == 0) txt_ketqua.Text += "\nHệ phương trình vô số nghiệm";
                else
                    txt_ketqua.Text += "\nHệ phương trình vô nghiệm";
            }
            else 
                MessageBox.Show("Nhập hệ số không thỏa mãn");
        }
    }
}
