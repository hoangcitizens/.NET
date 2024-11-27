using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._3_Menu_VD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCau2 frmCau2 = new FormCau2();
            this.Hide();
            frmCau2.ShowDialog();
            this.Show();
        }

        private void câu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCau3 frmCau3 = new FormCau3();
            this.Hide();
            frmCau3.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
