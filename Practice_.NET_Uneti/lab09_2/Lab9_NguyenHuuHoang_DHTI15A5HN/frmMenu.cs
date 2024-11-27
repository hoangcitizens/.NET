using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_NguyenHuuHoang_DHTI15A5HN
{
    public partial class frmMenu : Form
    {
        private Form formCon;
        private void OpenForm(Form form)
        {
            if (formCon != null)
                formCon.Close();
            formCon = form; // Khởi tạo form con
            form.TopLevel = false; // Đặt TopLevel thành false để form có thể được nhúng vào Panel
            form.FormBorderStyle = FormBorderStyle.None; // Loại bỏ đường viền của form
            form.Dock = DockStyle.Fill; // Form con sẽ lấp đầy panel
            panelContainer.Controls.Add(form); // Thêm form con vào panel
            panelContainer.Tag = form;
            formCon.BringToFront();
            formCon.Show(); // Hiển thị form con
        }
        public frmMenu()
        {
            InitializeComponent();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new frmKhachHang());
        }

        private void thôngTinMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new frmMatHang());
        }

        private void quảnLýHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new frmHopDong());
        }

        private void quảnLýHợpĐồngVàMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new frmHopDong_MatHang());
        }
    }
}
