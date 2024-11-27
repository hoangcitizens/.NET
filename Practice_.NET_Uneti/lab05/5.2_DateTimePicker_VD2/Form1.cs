using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2_DateTimePicker_VD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (txthang.Text != "" && txtxx.Text != "" && txtgia.Text != "")
            {
                if (ngaythang.Value.Year < 1990)
                {
                    MessageBox.Show("Hàng đã cũ,cần thanh lý");
                }
                else if (ngaythang.Value.Year < 2023)
                {
                    MessageBox.Show("Hàng còn dùng được");
                }

                else
                {
                    MessageBox.Show("Hàng mới");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }
    }
}
