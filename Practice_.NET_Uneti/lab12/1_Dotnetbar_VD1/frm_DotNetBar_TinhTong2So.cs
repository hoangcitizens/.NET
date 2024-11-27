using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Dotnetbar_VD1
{
    public partial class frm_DotNetBar_TinhTong2So : Form
    {
        public frm_DotNetBar_TinhTong2So()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ hai TextBox
                double soThuNhat = Convert.ToDouble(txtSoThuNhat.Text);
                double soThuHai = Convert.ToDouble(txtSoThuHai.Text);

                // Tính tổng
                double tong = soThuNhat + soThuHai;

                // Hiển thị kết quả
                txtKetQua.Text = tong.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong TextBox
            txtSoThuNhat.Clear();
            txtSoThuHai.Clear();
            txtKetQua.Clear();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_DotNetBar_TinhTong2So_Load(object sender, EventArgs e)
        {
            txtKetQua.ReadOnly = true;
        }
    }
}
