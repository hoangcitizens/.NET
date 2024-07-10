using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Ex5_Week6_NguyenHuuHoang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Viết thủ tục Nhapmang() thực hiện lưu 5 số nguyên ngẫu nhiên từ 1 đến 100 
        private int[] a = new int[5];
        private Random random = new Random();
        private void nhapMang()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1,101);
            }    
        }
        // Thủ tục xuấtmang() gán 5 giá trị từ mảng vào 5 Textbox 
        private void xuatMang()
        {
            text1.Text = a[0].ToString();
            text2.Text = a[1].ToString();
            text3.Text = a[2].ToString();
            text4.Text = a[3].ToString();
            text5.Text = a[4].ToString();
        }

        // Sự kiện Click của nút Nhập gọi 2 thủ tục trên
        private void button1_Click(object sender, EventArgs e)
        {
            nhapMang();
            xuatMang();
            textSoLonNhat.Clear();
            textTong.Clear();
            textVitri.Clear();
        }
        // Thủ tục Timmax() để Tìm giá trị lơn nhất và vị trí 
        private void timMax()
        {
            int max = a[0];
            int pos = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    pos = i + 1;
                }    
            }    
            textSoLonNhat.Text = max.ToString();
            textVitri.Text = pos.ToString();
        }
        // Viết hàm Tong() để tính tổng các phần tử trong mảng 
        private void tinhTong()
        {
            int S = 0;
            for (int i = 0; i < a.Length; i++)
            {
                S += a[i];
            }    
            textTong.Text = S.ToString();
        }
        // Sự kiện Click của nút thực hiện Gọi thủ tục Timmax() và hàm Tong() 
        private void button2_Click(object sender, EventArgs e)
        {
            timMax();
            tinhTong();
        }
    }
}
