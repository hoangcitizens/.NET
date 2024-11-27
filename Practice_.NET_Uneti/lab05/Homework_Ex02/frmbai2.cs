using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Ex02
{
    public partial class frmbai2 : Form
    {
        // Dictionary để lưu từ điển Anh-Việt
        Dictionary<string, string> tuDien = new Dictionary<string, string>();
        public frmbai2()
        {
            InitializeComponent();
        }

        private void btnThemTu_Click(object sender, EventArgs e)
        {
            // Lấy từ và nghĩa từ TextBox
            string tuTiengAnh = txtTiengAnh.Text.Trim();
            string nghiaTiengViet = txtTiengViet.Text.Trim();

            // Kiểm tra nếu từ và nghĩa không rỗng
            if (!string.IsNullOrEmpty(tuTiengAnh) && !string.IsNullOrEmpty(nghiaTiengViet))
            {
                // Thêm từ vào Dictionary
                if (!tuDien.ContainsKey(tuTiengAnh))
                {
                    tuDien.Add(tuTiengAnh, nghiaTiengViet);
                    cboDanhSach.Items.Add(tuTiengAnh); // Thêm từ vào ComboBox
                    MessageBox.Show("Đã thêm từ thành công!");
                }
                else
                {
                    MessageBox.Show("Từ này đã tồn tại trong từ điển.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ tiếng Anh và nghĩa tiếng Việt.");
            }
        }

        private void btnXoaTu_Click(object sender, EventArgs e)
        {
            // Xóa từ được chọn trong ComboBox
            string tuDuocChon = cboDanhSach.SelectedItem?.ToString();
            if (tuDuocChon != null)
            {
                tuDien.Remove(tuDuocChon);
                cboDanhSach.Items.Remove(tuDuocChon);
                txtTiengViet.Clear(); // Xóa phần nghĩa hiển thị
                MessageBox.Show("Đã xóa từ thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn từ cần xóa.");
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            // Xóa toàn bộ từ trong ComboBox và Dictionary
            tuDien.Clear();
            cboDanhSach.Items.Clear();
            txtTiengViet.Clear(); // Xóa phần nghĩa hiển thị
            MessageBox.Show("Đã xóa tất cả từ.");
        }

        private void cboDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiển thị nghĩa của từ khi người dùng chọn từ trong ComboBox
            string tuDuocChon = cboDanhSach.SelectedItem?.ToString();
            if (tuDuocChon != null && tuDien.ContainsKey(tuDuocChon))
            {
                txtTiengViet.Text = tuDien[tuDuocChon];
            }
        }
    }
}
