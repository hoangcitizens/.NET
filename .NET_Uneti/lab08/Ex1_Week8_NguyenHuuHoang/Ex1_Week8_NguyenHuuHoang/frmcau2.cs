using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Week8_NguyenHuuHoang
{
    public partial class frmcau2 : Form
    {
        public frmcau2()
        {
            InitializeComponent();
        }

        // Thêm nút cha (thêm khoa được nhập trên Textbox Tên khoa vào Treeview)
        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode();
            node.Text = txtTenKhoa.Text;
            treeView1.Nodes.Add(node);
        }
        // Thêm nút con (thêm lớp được nhập trên Textbox Tên lớp vào nút con của nút Tên khoa)
        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                TreeNode node = new TreeNode(treeView1.SelectedNode.Text);
                node.Text = txtTenLop.Text;
                treeView1.SelectedNode.Nodes.Add(node);
            }    
        }
        /* Code cho nút” xóa nút chọn” để xóa nút đang chọn trên treeview (chú ý khi xóa cần
           hiển thị hộp thoại cảnh báo: bạn có thực sự muốn xóa không với 2 nút YES và NO,
           nếu người dùng chọn YES thì mới xóa, nếu người dùng chọn NO thì không xóa) */
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
        /*
            Viết code cho nút thêm cho phép người dùng nhập thông tin mã sinh viên, họ tên vào textbox,
            ngày sinh vào DateTimePicker(để lấy giá trị người dùng nhập trên đk này dùng 
            dateTimePicker1.Value), và chọn tên lớp trên treeview. Sau khi nhập chọn dữ liệu đầy đủ gồm
            mã sinh viên, họ tên, ngày sinh, tên lớp thì tiến hành thêm vào listview một dòng dữ liệu
         */
        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = txtMsv.Text;
            item.SubItems.Add(txtHoten.Text);
            item.SubItems.Add(dateTimePicker1.Text);
            item.SubItems.Add(txtTenLop.Text);
            listView1.Items.Add(item);
        }
        /*
            Viết code cho sự kiện SelectedIndexChanged của listView cho phép người dùng chọn một
            dòng dữ liệu trên listview sẽ đưa dữ liệu đó lên các textbox mã sinh viên, họ tên và 
            datetimepicker ngày sinh
         */
        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thay đổi lựa chọn này không", "Xác thực thay đổi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    // Lấy dữ liệu từ các cột trong dòng được chọn
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    string maSinhVien = selectedItem.SubItems[0].Text; // Cột 1 chứa mã sinh viên
                    string hoVaTen = selectedItem.SubItems[1].Text; // Cột 2 chứa họ và tên
                    string ngaySinh = selectedItem.SubItems[2].Text; // Cột 3 chứa ngày sinh
                    string tenLop = selectedItem.SubItems[3].Text; // Cột 4 chứa tên lớp
                    // Hiển thị dữ liệu lên các Textbox và DateTimePiker tương ứng
                    txtMsv.Text = maSinhVien;
                    txtHoten.Text = hoVaTen;
                    txtTenLop.Text = tenLop;
                    dateTimePicker1.Text = ngaySinh;
                }
                else
                    MessageBox.Show("Mời bạn chọn 1 phần tử", "Thông báo",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        // Viết code cho nút sửa , xóa để tiến hành sửa, xóa thông tin của sinh viên chọn trên listview
        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nút đã chọn không", "Xác thực xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (listView1.SelectedItems.Count > 0)
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                else
                    MessageBox.Show("Mời bạn chọn 1 phần tử", "Thông báo",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
    }
}
