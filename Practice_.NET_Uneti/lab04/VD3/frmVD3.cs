using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD3
{
    public partial class frmVD3 : Form
    {
        public frmVD3()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txthoten.Text))
            {
                lsthienthi.Items.Add(txthoten.Text);
                txttongso.Text =
                lsthienthi.Items.Count.ToString();
                txthoten.Clear();
                txthoten.Focus();
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
        }

        private void btnxoachon_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txttongso.Text);
            if (lsthienthi.SelectedItems.Count != 0)
            {
                lsthienthi.Items.Remove(lsthienthi.SelectedItems[0]);
            }
            txttongso.Text = (a - 1).ToString();
        }

        private void btnxoabandau_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txttongso.Text);
            lsthienthi.Items.RemoveAt(0);
            txttongso.Text = (a - 1).ToString();
        }

        private void btnxoacuoi_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txttongso.Text);
            lsthienthi.Items.RemoveAt(lsthienthi.Items.Count - 1);
            txttongso.Text = (a - 1).ToString();
        }

        private void btnxoaall_Click(object sender, EventArgs e)
        {
            lsthienthi.Items.Clear();
            txttongso.Text = "0";
        }
    }
}
