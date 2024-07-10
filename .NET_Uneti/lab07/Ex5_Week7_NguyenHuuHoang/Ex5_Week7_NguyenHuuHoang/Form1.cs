using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5_Week7_NguyenHuuHoang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng phải nhập đủ dữ liệu cho Mã hàng, đơn hàng và số lượng
            if ((txtMaHang.Text).Equals("") || (txtDonGia.Text).Equals("") || (txtSoLuong.Text).Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                txtMaHang.Focus();
            }
            else
            {
                double dongia = double.Parse(txtDonGia.Text);
                int soluong = int.Parse(txtSoLuong.Text);
                double tongtien = 0;
                // Nếu giảm giá được chọn thì hiển thị 2 điều khiển giảm giá 5% và 10%, ngược lại không hiển thị 2 điều khiển này
                if (checkBox1.Checked == true)
                {
                    if (rad1.Checked == true)
                    {
                        // Tổng tiền= đơn giá * số lượng
                        tongtien = (dongia * soluong) - 0.05 * (dongia * soluong);
                    }
                    else if (rad2.Checked == true)
                    {
                        tongtien = (dongia * soluong) - 0.1 * (dongia * soluong);
                    }    
                }    
                else
                {
                    tongtien = dongia * soluong;
                }
                txtTongTien.Text = tongtien.ToString();
            }
        }

        // ẩn hiện giảm giá
        private void Form1_Load(object sender, EventArgs e)
        {
            rad1.Visible = false;
            rad2.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                rad1.Visible = true;
                rad2.Visible = true;
            }    
            else
            {
                rad1.Visible = false;
                rad2.Visible = false;
            }    
        }
    }
}
