using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_lab9
{
    public partial class FrmMain : Form
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
        public FrmMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {          
            OpenForm(new Yc1_FrmKhachHang());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenForm(new Yc2_FrmMatHang());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenForm(new Yc3_FrmBanHang());
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            OpenForm(new Yc4a_FrmTimKiemKH());
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            OpenForm(new Yc4b_FrmTimKiemMH());
        }
    }
}
