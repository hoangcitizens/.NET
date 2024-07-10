using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHuuHoang_21103100320_week7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNam.Checked == true)
                MessageBox.Show("Giới tính Nam");
            else if (rbNu.Checked)
                MessageBox.Show("Giới tính Nữ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (chbDabong.Checked) // <=> == true
                textBox1.Text += $"{chbDabong.Text}, ";
            if (chbXemPhim.Checked) 
                textBox1.Text += chbXemPhim.Text + " ";
            if (chbCauLong.Checked)
                textBox1.Text += chbCauLong.Text + " ";
        }
    }
}
