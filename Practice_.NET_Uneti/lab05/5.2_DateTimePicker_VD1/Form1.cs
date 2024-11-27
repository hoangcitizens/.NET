using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2_DateTimePicker_VD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtten.Text != "" && txtqq.Text != "")
            {
                if (ngaysinh.Value.Year <= 2006)
                {
                    MessageBox.Show("Đăng ký thành công");
                }
                else
                {
                    MessageBox.Show("Bạn phải từ 18 tuổi trở lên để đăng ký");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }
    }
}
