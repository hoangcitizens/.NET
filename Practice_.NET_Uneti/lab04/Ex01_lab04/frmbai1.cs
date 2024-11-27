using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn trong ListBox
            if (lstWeb.SelectedItem != null)
            {
                // Hiển thị kết quả vào TextBox
                txtKQ.Text = "Bạn đã chọn website " + lstWeb.SelectedItem.ToString();
            }
            else
            {
                // Nếu không chọn mục nào
                MessageBox.Show("Vui lòng chọn một website.", "Thông báo");
            }
        }
    }
}
