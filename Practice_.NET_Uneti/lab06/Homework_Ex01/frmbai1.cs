using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Homework_Ex01
{
    public partial class frmbai1 : Form
    {
        public frmbai1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedItem.ToString() == "Hiển thị thời gian")
            {
                // Display current time
                lbThoiGian.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            else if (toolStripComboBox1.SelectedItem.ToString() == "Hiển thị ngày tháng năm")
            {
                // Display current date
                lbNgayThangNam.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }
    }
}
