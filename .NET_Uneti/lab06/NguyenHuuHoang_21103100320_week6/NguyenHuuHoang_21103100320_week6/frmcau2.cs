using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHuuHoang_21103100320_week6
{
    public partial class frmcau2 : Form
    {
        public frmcau2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(texta.Text);
            b = int.Parse(textb.Text);
            c = int.Parse(textc.Text);
            textPhuongtrinh.Text = $"{a}x^2 + {b}x + {c} = 0";
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        textNghiem.Text = "Phương trình có vô số nghiệm";
                    else
                        textNghiem.Text = "Phương trình vô nghiệm";
                }
                else
                {
                    textNghiem.Text = "Phương trình có nghiệm x = " + (-(float)c / b).ToString();
                }    
            }    
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                    textNghiem.Text = "Phương trình vô nghiệm";
                else if (delta == 0)
                {
                    textNghiem.Text = "Phương trình có  nghiệm kép x = " + (-(float)b / (2*a)).ToString();
                }    
                else
                {
                    textNghiem.Text = "Phương trình có 2 nghiệm phân biệt x1 = " + (((double)-b+Math.Sqrt(delta)) / (2 * a)).ToString()
                        + "x2 = " + (((double)-b - Math.Sqrt(delta)) / (2 * a)).ToString();           
                }    
            }    
        }
        private void button2_Click(object sender, EventArgs e)
        {
            texta.Clear();
            textb.Clear();
            textc.Clear();
            textNghiem.Clear();
            textPhuongtrinh.Clear();
        }
    }
}
