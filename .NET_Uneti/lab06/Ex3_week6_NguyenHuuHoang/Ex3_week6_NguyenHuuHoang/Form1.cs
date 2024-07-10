using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3_week6_NguyenHuuHoang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textn.Clear();
            textSoNguyenTo.Clear();
            textSoChinhPhuong.Clear();
            textn.Focus();
        }

        // SỐ NGUYÊN TỐ & SỐ CHÍNH PHƯƠNG
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textn.Text);
            if ((textn.Text).Equals(""))
                MessageBox.Show("Bạn chưa nhập n. Vui lòng nhập n");
            else
            {
                // in số nguyên tố
                for (int i = 2; i <= n; i++)
                {
                    bool kt = true;
                    for (int j = 2; j * j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            kt = false;
                            break;
                        }    
                    }    
                    if (kt == true && i != 1)
                    {
                        textSoNguyenTo.Text += i.ToString() + ", ";
                    }    
                }  
                // in số chính phương
                for (int i = 1; i <= n; i++)
                {
                    int sqrt = (int)Math.Sqrt(i);
                    if (Math.Pow(sqrt,2) == i)
                    {
                        textSoChinhPhuong.Text += i.ToString() + ", ";
                    }    
                }    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
