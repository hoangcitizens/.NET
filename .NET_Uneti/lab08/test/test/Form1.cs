using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = txtTenPhong.Text;
      
            item.SubItems.Add(txtSoLuong.Text);
            item.SubItems.Add(txtDiaChi.Text);
            item.ImageIndex = 3;
            listView1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa không?","Xác thực xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
                else
                {
                    MessageBox.Show("Mời chọn 1 phần tử", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }                 
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                OpenFileDialog f = new OpenFileDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Image im = Image.FromFile(f.FileName);
                    pictureBox1.Image = im;
                    imageListLarge.Images.Add(im);
                    imageListSmall.Images.Add(im);
                    listView1.SelectedItems[0].ImageIndex = imageListSmall.Images.Count - 1;
                }    
            }  
                
        }
    }
}
