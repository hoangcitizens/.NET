using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._4_TongHopForm_VD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Viết mã lệnh cho hàm kiểm tra chuỗi rỗng
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }
        // Viết mã lệnh cho hàm kiểm tra dữ liệu nhập vào
        bool kiemtra_dulieu(string s)
        {
            double so;
            if (kiemtra(txt_so1.Text) || kiemtra(txt_so2.Text) || kiemtra(combo_pheptoan.Text)) 
                return false;
            if (!double.TryParse(txt_so1.Text, out so))
                return false;
            if (!double.TryParse(txt_so2.Text, out so)) 
                return false;
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_so1.ResetText();
            txt_so2.ResetText();
            txt_so1.Focus();
        }

        private void bt_tinhtoan_Click(object sender, EventArgs e)
        {
            if (!kiemtra_dulieu("")) 
                MessageBox.Show("Dữ liệu không hợp lệ");
            else
            {
                float kq = 0;
                float th1 = float.Parse(txt_so1.Text);
                float th2 = float.Parse(txt_so2.Text);
                bool kt = true;
                switch (combo_pheptoan.Text.Trim())
                {
                    case "+": kq = th1 + th2; break;
                    case "-": kq = th1 - th2; break;
                    case "*": kq = th1 * th2; break;
                    case "/":
                        if (th2 != 0) kq = th1 / th2;
                        else kt = false; break;
                    default: kt = false; break;
                }
                if (kt)
                    lb_ketqua.Text = " " + kq.ToString();
                else MessageBox.Show("Không thực hiện tính toán được");
}
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
