using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_NguyenHuuHoang
{
    public partial class frmcau1 : Form
    {
        public frmcau1()
        {
            InitializeComponent();
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcau2 f = new frmcau2();
            f.MdiParent = this;
            f.Show();
        }

        private void câu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcau3 f = new frmcau3();
            f.MdiParent = this;
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
