using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_Lab03
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            lblResult.Visible = false;
            btnSolve.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtA.Text) || string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ a và b.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Check if the input is valid
                if (double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b))
                {
                    MessageBox.Show("Dữ liệu hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSolve.Enabled = true;
                    btnCheck.Enabled = false; // Disable check button after validation
                }
                else
                {
                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập số thực.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            lblResult.Visible = true;

            if (a == 0)
            {
                if (b < 0)
                {
                    lblResult.Text = "Bất phương trình luôn đúng.";
                }
                else
                {
                    lblResult.Text = "Bất phương trình vô nghiệm.";
                }
            }
            else
            {
                double solution = -b / a;
                if (a > 0)
                {
                    lblResult.Text = $"Bất phương trình có nghiệm x < {solution}.";
                }
                else
                {
                    lblResult.Text = $"Bất phương trình có nghiệm x > {solution}.";
                }
            }
        }
    }
}
