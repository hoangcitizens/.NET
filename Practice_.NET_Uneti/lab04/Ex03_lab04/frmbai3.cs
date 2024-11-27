using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03_lab04
{
    public partial class frmbai3 : Form
    {
        public frmbai3()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtHoTen.Text)) // Kiểm tra nếu TextBox không rỗng
            {
                lstLopA.Items.Add(txtHoTen.Text); // Thêm tên vào ListBox Lớp A
                txtHoTen.Clear(); // Xóa nội dung TextBox
                txtHoTen.Focus(); // Đưa con trỏ về lại TextBox
            }
        }

        // Di chuyển các mục được chọn từ Lớp A sang Lớp B
        private void btnRight_Click(object sender, EventArgs e)
        {
            foreach (var item in lstLopA.SelectedItems)
            {
                lstLopB.Items.Add(item); // Thêm mục đã chọn vào ListBox Lớp B
            }

            // Xóa các mục đã chuyển đi từ ListBox Lớp A
            for (int i = lstLopA.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopA.Items.Remove(lstLopA.SelectedItems[i]);
            }
        }

        // Di chuyển các mục được chọn từ Lớp B sang Lớp A
        private void btnLeft_Click(object sender, EventArgs e)
        {
            foreach (var item in lstLopB.SelectedItems)
            {
                lstLopA.Items.Add(item); // Thêm mục đã chọn vào ListBox Lớp A
            }

            // Xóa các mục đã chuyển đi từ ListBox Lớp B
            for (int i = lstLopB.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopB.Items.Remove(lstLopB.SelectedItems[i]);
            }
        }

        // Di chuyển tất cả các mục từ Lớp A sang Lớp B
        private void btnRightAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstLopA.Items)
            {
                lstLopB.Items.Add(item); // Thêm tất cả mục từ Lớp A sang Lớp B
            }

            lstLopA.Items.Clear(); // Xóa toàn bộ mục trong Lớp A
        }

        // Di chuyển tất cả các mục từ Lớp B sang Lớp A
        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstLopB.Items)
            {
                lstLopA.Items.Add(item); // Thêm tất cả mục từ Lớp B sang Lớp A
            }

            lstLopB.Items.Clear(); // Xóa toàn bộ mục trong Lớp B
        }

        // Xóa mục được chọn trong ListBox Lớp A
        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = lstLopA.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopA.Items.Remove(lstLopA.SelectedItems[i]); // Xóa mục đã chọn
            }
        }

        // Thoát khỏi chương trình
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng ứng dụng
        }
    }
}
