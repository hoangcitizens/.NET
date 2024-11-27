using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03_Lab03
{
    public partial class frmBai : Form
    {
        public frmBai()
        {
            InitializeComponent();
        }
        // Sự kiện khi form load
        private void frmBai_Load(object sender, EventArgs e)
        {
            txtNhapN.Text = "";  // Textbox để trống khi form load
            lblKetQua.Visible = false; // Ẩn nhãn kết quả
        }

        // Hàm kiểm tra số nguyên tố
        private bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2) return false; // Số nhỏ hơn 2 không phải số nguyên tố
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        // Hàm tính tổng các chữ số của một số nguyên dương
        private int TinhTongCacChuSo(int n)
        {
            int tong = 0;
            while (n > 0)
            {
                tong += n % 10; // Lấy chữ số cuối cùng
                n /= 10;        // Loại bỏ chữ số cuối cùng
            }
            return tong;
        }

        // Sự kiện khi người dùng nhấn nút "Tính tổng"
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem textbox có trống không
            if (string.IsNullOrWhiteSpace(txtNhapN.Text))
            {
                MessageBox.Show("Vui lòng nhập số n!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem người dùng nhập vào có phải là số nguyên hay không
            if (!int.TryParse(txtNhapN.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính tổng các chữ số của n
            int tong = TinhTongCacChuSo(n);

            // Hiển thị kết quả trên nhãn
            lblKetQua.Text = "Tổng các chữ số của n là: " + tong.ToString();
            lblKetQua.Visible = true; // Hiện nhãn kết quả
        }

        // Sự kiện khi người dùng nhấn nút "Kiểm tra số nguyên tố"
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem textbox có trống không
            if (string.IsNullOrWhiteSpace(txtNhapN.Text))
            {
                MessageBox.Show("Vui lòng nhập số n!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem người dùng nhập vào có phải là số nguyên hay không
            if (!int.TryParse(txtNhapN.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem n có phải là số nguyên tố hay không
            if (KiemTraSoNguyenTo(n))
            {
                MessageBox.Show(n + " là số nguyên tố.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(n + " không phải là số nguyên tố.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
