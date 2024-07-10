using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode();
            node.Text = txtTenKhoa.Text;
            treeView1.Nodes.Add(node);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                TreeNode node = new TreeNode(treeView1.SelectedNode.Text);
                node.Text = txtTenLop.Text;
                treeView1.SelectedNode.Nodes.Add(node);
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nút đã chọn không", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    treeView1.SelectedNode.Remove();
                else
                    MessageBox.Show("Đã hủy xóa");
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = txtMsv.Text;
            item.SubItems.Add(txtHoten.Text);
            item.SubItems.Add(txtTenLop.Text);
            item.SubItems.Add(dateTimePicker1.Text);
            listView1.Items.Add(item);
        }

        private void button5_Click(object sender, EventArgs e)
        {         
                if (MessageBox.Show("Bạn có thực sự muốn thay đổi lựa chọn này không?", "Xác thực thay đổi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {        
                    if (listView1.SelectedItems.Count > 0)
                    {
                        ListViewItem selectedItem = listView1.SelectedItems[0];
                        // Lấy dữ liệu từ các cột trong dòng được chọn
                        string maSinhVien = selectedItem.SubItems[0].Text; // Giả sử cột 1 chứa mã sinh viên
                        string hoTen = selectedItem.SubItems[1].Text; // Giả sử cột thứ hai chứa họ tên
                        string tenlop = selectedItem.SubItems[2].Text; // Giả sử cột thứ ba chứa tên lớp
                        string ngaySinhStr = selectedItem.SubItems[3].Text; 
                        // Hiển thị dữ liệu lên các TextBox và DateTimePicker tương ứng
                        txtMsv.Text = maSinhVien;
                        txtHoten.Text = hoTen;
                        txtTenLop.Text = tenlop;
                        dateTimePicker1.Text = ngaySinhStr;
                    }
                    else
                    {
                        MessageBox.Show("Mời chọn 1 phần tử", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa không?","Xác thực xóa",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
                else
                {
                    MessageBox.Show("Mời chọn 1 phần tử", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }    
        }

    }
}
