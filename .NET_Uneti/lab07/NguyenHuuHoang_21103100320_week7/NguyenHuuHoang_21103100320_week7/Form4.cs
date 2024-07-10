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

namespace NguyenHuuHoang_21103100320_week7
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lst1.SelectedIndex == -1)
                MessageBox.Show("Mời chọn 1 phần tử");
            else
            {              
                // thêm vào bên phải
                lstkq1.Items.Add(lst1.SelectedItem);
                // xóa vào bên trái
                lst1.Items.Remove(lst1.SelectedItem);
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lst1.Items.Add(textBox1.Text);
            lst2.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstkq1.SelectedIndex == -1)
                MessageBox.Show("Mời chọn 1 phần tử");
            else
            {
                // thêm vào bên trái
                lst1.Items.Add(lstkq1.SelectedItem);
                // xóa vào bên trái
                lstkq1.Items.Remove(lstkq1.SelectedItem);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int soptuchon = lst2.SelectedItems.Count;
            if (soptuchon == 0)
                MessageBox.Show("Mời chọn 1 phần tử");
            else
            {
                ArrayList mangchon = new ArrayList();
                // thêm vào bên phải
                foreach (string s in lst2.SelectedItems)
                {
                    lstkq2.Items.Add(s);
                    mangchon.Add(s);
                }
                foreach (string s in mangchon)
                    lst2.Items.Remove(s);
                // xóa khỏi bên trái
                foreach (string s in lstkq2.SelectedItems)
                {
                    lst2.Items.Remove(s);
                    mangchon.Remove(s);
                }
                foreach (string s in mangchon)
                    lst2.Items.Remove(s);
            }    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int soptuchon = lstkq2.SelectedItems.Count;
            if (soptuchon == 0)
                MessageBox.Show("Mời chọn 1 phần tử");
            else
            {
                ArrayList mangchon = new ArrayList();
                // thêm vào bên trái
                foreach (string s in lstkq2.SelectedItems)
                {
                    lst2.Items.Add(s);
                    mangchon.Add(s);
                }
                foreach (string s in mangchon)
                    lstkq2.Items.Remove(s);
                // xóa khỏi bên phải
                foreach (string s in lst2.SelectedItems)
                {
                    lstkq2.Items.Remove(s);
                    mangchon.Remove(s);
                }
                foreach (string s in mangchon)
                    lstkq2.Items.Remove(s);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lst1.Items.Remove(textBox1.Text);
            lst2.Items.Remove(textBox1.Text);
        }
    }
}
