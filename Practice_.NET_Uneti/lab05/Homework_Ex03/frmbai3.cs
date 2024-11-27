using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Ex03
{
    public partial class frmbai3 : Form
    {
        public frmbai3()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnVeHinh_Click(object sender, EventArgs e)
        {
            // Lấy giá trị màu từ các thanh HScrollBar
            int red = hScrollBarRed.Value;
            int green = hScrollBarGreen.Value;
            int blue = hScrollBarBlue.Value;

            // Tạo màu mới từ các giá trị màu
            Color selectedColor = Color.FromArgb(red, green, blue);

            // Vẽ hình dựa trên lựa chọn
            using (Graphics g = pnlHinhVe.CreateGraphics())
            {
                g.Clear(pnlHinhVe.BackColor); // Xóa hình cũ
                Brush brush = new SolidBrush(selectedColor);

                if (rdoHinhTron.Checked)
                {
                    g.FillEllipse(brush, 10, 10, 150, 150); // Vẽ hình tròn
                }
                else if (rdoHinhVuong.Checked)
                {
                    g.FillRectangle(brush, 10, 10, 150, 150); // Vẽ hình vuông
                }
                else if (rdoHinhChuNhat.Checked)
                {
                    g.FillRectangle(brush, 10, 10, 200, 100); // Vẽ hình chữ nhật
                }
                else if (rdoHinhEllipse.Checked)
                {
                    g.FillEllipse(brush, 10, 10, 200, 100); // Vẽ hình ellipse
                }
            }
        }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            // Cập nhật giá trị màu sắc hiển thị khi người dùng cuộn thanh HScrollBar
            lblRedValue.Text = hScrollBarRed.Value.ToString();
            lblGreenValue.Text = hScrollBarGreen.Value.ToString();
            lblBlueValue.Text = hScrollBarBlue.Value.ToString();
        }

        private void lblRedValue_Click(object sender, EventArgs e)
        {

        }
    }
}
