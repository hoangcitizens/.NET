using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex04_lab04
{
    public partial class frmbai4 : Form
    {
        public frmbai4()
        {
            InitializeComponent();
        }

        private void frmbai4_Load(object sender, EventArgs e)
        {
            // Chỉ cho nhập số vào TextBox
            txtSoNguyen.KeyPress += TxtSoNguyen_KeyPress;
            txtSoNguyen.KeyDown += TxtSoNguyen_KeyDown;
            btnCapNhat.Click += btnCapNhat_Click;
        }

        // Chỉ cho phép nhập số vào TextBox
        private void TxtSoNguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các chữ số và các phím điều khiển
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Xử lý khi nhấn phím Enter để thêm số vào ListBox
        private void TxtSoNguyen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThemSoVaoListBox();
            }
        }  

        // Phương thức thêm số vào ListBox
        private void ThemSoVaoListBox()
        {
            if (!string.IsNullOrEmpty(txtSoNguyen.Text))
            {
                lstSoNguyen.Items.Add(txtSoNguyen.Text);
                txtSoNguyen.Clear();
                txtSoNguyen.Focus(); // Đưa con trỏ về lại TextBox sau khi thêm số
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ThemSoVaoListBox();
        }

        // Tăng mỗi phần tử trong ListBox lên 2
        private void btnTangLen2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSoNguyen.Items.Count; i++)
            {
                int so = int.Parse(lstSoNguyen.Items[i].ToString());
                lstSoNguyen.Items[i] = (so + 2).ToString();
            }
        }

        // Chọn các số chẵn đầu tiên
        private void btnChonSoChanDau_Click(object sender, EventArgs e)
        {
            lstSoNguyen.ClearSelected(); // Xóa các lựa chọn hiện tại
            for (int i = 0; i < lstSoNguyen.Items.Count; i++)
            {
                int so = int.Parse(lstSoNguyen.Items[i].ToString());
                if (so % 2 == 0)
                {
                    lstSoNguyen.SetSelected(i, true); // Chọn các số chẵn
                }
            }
        }

        // Chọn các số lẻ cuối cùng
        private void btnChonSoLeCuoi_Click(object sender, EventArgs e)
        {
            lstSoNguyen.ClearSelected(); // Xóa các lựa chọn hiện tại
            for (int i = 0; i < lstSoNguyen.Items.Count; i++)
            {
                int so = int.Parse(lstSoNguyen.Items[i].ToString());
                if (so % 2 != 0)
                {
                    lstSoNguyen.SetSelected(i, true); // Chọn các số lẻ
                }
            }
        }

        // Xóa phần tử đang chọn trong ListBox
        private void btnXoaPhanTuChon_Click(object sender, EventArgs e)
        {
            if (lstSoNguyen.SelectedItem != null)
            {
                lstSoNguyen.Items.Remove(lstSoNguyen.SelectedItem);
            }
        }

        // Xóa phần tử đầu tiên trong ListBox
        private void btnXoaPhanTuDau_Click(object sender, EventArgs e)
        {
            if (lstSoNguyen.Items.Count > 0)
            {
                lstSoNguyen.Items.RemoveAt(0);
            }
        }

        // Xóa phần tử cuối cùng trong ListBox
        private void btnXoaPhanTuCuoi_Click(object sender, EventArgs e)
        {
            if (lstSoNguyen.Items.Count > 0)
            {
                lstSoNguyen.Items.RemoveAt(lstSoNguyen.Items.Count - 1);
            }
        }

        // Kết thúc chương trình
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
