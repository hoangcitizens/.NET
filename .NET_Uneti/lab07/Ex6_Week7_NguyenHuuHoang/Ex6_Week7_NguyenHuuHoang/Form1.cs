using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6_Week7_NguyenHuuHoang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Nút THÊM dùng để thêm một mục mới vào Listbox chứa thông tin của một giáo viên mới vừa nhập ở các textbox.
        private void button1_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (radNam.Checked == true)
                gioitinh = "Nam";
            else if (radNu.Checked == true)
                gioitinh = "Nữ";
            string thongtin = txtHoTen.Text + ": " + gioitinh + "; " + txtNamSinh.Text + "; " + comboBox1.Text;
            lst.Items.Add(thongtin);
        }

        // Nút TIẾP TỤC thực hiện xóa trắng các Textbox và combobox
        private void button2_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtNamSinh.Clear();
            comboBox1.SelectedIndex = -1;
            txtHoTen.Focus();
        }

        // Nút XÓA thực hiện xóa các mục được chọn của Listbox chứa thông tin của các giáo viên
        private void button3_Click(object sender, EventArgs e)
        {
            int sophantu = lst.SelectedItems.Count;
            if (sophantu == 0)
                MessageBox.Show("Mời chọn 1 phần tử");
            else
            {
                ArrayList mangchon = new ArrayList(); // xóa nhiều
                foreach (string s in lst.SelectedItems)
                {
                    mangchon.Add(s); // thêm vào 1 mảng tạm thời
                }
                foreach (string s in mangchon)
                    lst.Items.Remove(s);
            }
        }
    }
}
