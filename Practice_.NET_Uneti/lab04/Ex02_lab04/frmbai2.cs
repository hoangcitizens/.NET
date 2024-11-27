using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02_lab04
{
    public partial class frmbai2 : Form
    {
        public frmbai2()
        {
            InitializeComponent();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn trong ListBox
            if (cbWeb.SelectedIndex != -1)
            {
                // Hiển thị kết quả vào TextBox
                txtKQ.Text = "Bạn đã chọn website " + cbWeb.SelectedItem.ToString();
            }
            else
            {
                // Nếu không chọn mục nào
                MessageBox.Show("Vui lòng chọn một website.", "Thông báo");
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            cbWeb.SelectedIndex = -1;
            txtKQ.Clear();
        }
    }
}
