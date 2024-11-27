using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD1
{
    public partial class frmVD1 : Form
    {
        public frmVD1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbomau.Text == "Yellow")
            {
                this.BackColor = Color.Yellow;
            }
            if (cbomau.Text == "Red")
            {
                this.BackColor = Color.Red;
            }
            if (cbomau.Text == "Blue")
            {
                this.BackColor = Color.Blue;
            }
            if (cbomau.Text == "Green")
            {
                this.BackColor = Color.Green;
            }
        }
    }
}
