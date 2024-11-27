using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._4_TongHopForm_VD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (diemden.SelectedItem != null && diemdi.SelectedItem != null)
            {
                txtdetail.Clear();
                txtdetail.Text += "Khách hàng: " + txtten.Text + '\n';
                txtdetail.Text += "Ngày sinh: " +
                ngaythang2.Value.Day + "/" + ngaythang1.Value.Month + "/" + ngaythang1.Value.Year + '\n';
                txtdetail.Text += "Địa chỉ: " + txtdc.Text + '\n';
                txtdetail.Text += "Điểm xuất phát: " + diemdi.SelectedItem + '\n';
                txtdetail.Text += "Điểm đến: " + diemden.SelectedItem + '\n';
                DateTime inTime = ngaythang2.Value;
                DateTime outTime = ngaythang3.Value;
                if (outTime >= inTime)
                {
                    tongso.Text = outTime.Subtract(inTime).Days.ToString();
                }
                else
                {
                    MessageBox.Show("Chọn đầy đủ điểm khởi hành, xuất phát");
                }
            }
            else
            {
                MessageBox.Show("Nhập đủ thông tin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtten.Clear();
            txtdc.Clear();
            txtdetail.Clear();
            txtten.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
