using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Ex01
{
    public partial class frmbai1 : Form
    {
        public frmbai1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            lbn.Text = txtn.Text;
            try
            {
                int n = int.Parse(txtn.Text);
                double sum = tinhTong(n);
                lbkq.Text = $"S = {sum}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập vào số nguyên !");
            }

        }
        private double tinhTong(int n)
        {
            double sum = 1.0; 
            double f = 1.0;

            for (int i = 2; i <= n; i++)
            {
                f *= i;
                sum += 1.0 / f; 
            }
            return sum;
        }
    }
}
