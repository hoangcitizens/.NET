using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHuuHoang_21103100320_week7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void rbXanh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbXanh.Checked) txtvbm.ForeColor = Color.Green;
        }

        private void rbDo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDo.Checked) txtvbm.ForeColor = Color.Red;
        }

        private void rbDen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDen.Checked) txtvbm.ForeColor = Color.Black;
        }

        private void chbDam_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDam.Checked) // thêm hiệu ứng đậm
                txtvbm.Font = new Font(txtvbm.Font, txtvbm.Font.Style | FontStyle.Bold);
            else
                txtvbm.Font = new Font(txtvbm.Font, txtvbm.Font.Style ^ FontStyle.Bold);
        }

        private void chbNghieng_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNghieng.Checked) // thêm hiệu ứng nghiêng
                txtvbm.Font = new Font(txtvbm.Font, txtvbm.Font.Style | FontStyle.Italic);
            else
                txtvbm.Font = new Font(txtvbm.Font, txtvbm.Font.Style ^ FontStyle.Italic);
        }

        private void chbGachChan_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGachChan.Checked) // thêm hiệu ứng gạch chân
                txtvbm.Font = new Font(txtvbm.Font, txtvbm.Font.Style | FontStyle.Underline);
            else
                txtvbm.Font = new Font(txtvbm.Font, txtvbm.Font.Style ^ FontStyle.Underline);
        }
    }
}
