using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4_Week6_NguyenHuuHoang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // GIẢI HỆ PHƯƠNG TRÌNH
        private void button1_Click(object sender, EventArgs e)
        {
            double a1 = double.Parse(texta1.Text);
            double b1 = double.Parse(textb1.Text);
            double c1 = double.Parse(textc1.Text);
            double a2 = double.Parse(texta2.Text);
            double b2 = double.Parse(textb2.Text);
            double c2 = double.Parse(textc2.Text);

            double n = a1 * b2 - a2 * b1;
            if (n == 0)
            {
                textx.Text = "Vô số nghiệm hoặc vô nghiệm";
                texty.Text = "Vô số nghiệm hoặc vô nghiệm";
            }
            else
            {
                double x = (c1 * b2 - c2 * b1) / n;
                double y = (a1 * c2 - a2 * c1) / n;
                textx.Text = x.ToString();
                texty.Text = y.ToString();
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            texta1.Clear();
            textb1.Clear();
            textc1.Clear();
            texta2.Clear();
            textb2.Clear();
            textc2.Clear();
            textx.Clear();
            texty.Clear();
            texta1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
