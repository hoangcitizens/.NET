using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._1_Form_VD1
{
    public partial class frmVD1 : Form
    {
        public frmVD1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhap.Text);
            long S = 0;
            for (int i = 1; i < n; i++)
            {
                S += i;
            }
            txtTong.Text = S.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
