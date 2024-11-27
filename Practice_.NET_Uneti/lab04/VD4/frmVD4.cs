using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD4
{
    public partial class frmVD4 : Form
    {
        public frmVD4()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            thanhtoan();
        }
        private void thanhtoan()
        {
            // Check if the customer name is provided
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize total amount
            double total = 0;

            // Add service charges based on selected options
            if (chkClean.Checked)
            {
                total += 100000; // Cạo vôi
            }

            if (chkWhitening.Checked)
            {
                total += 1200000; // Tẩy trắng
            }

            if (chkXRay.Checked)
            {
                total += 200000; // Chụp hình răng
            }

            // Calculate the cost of filling based on the number of teeth
            int soRangTram;
            if (int.TryParse(numFilling.Text, out soRangTram))
            {
                total += soRangTram * 80000; // Trám răng (80.000/cái)
            }

            // Display the total amount in the Total TextBox
            txtTotal.Text = total.ToString("C0"); // C0 for currency formatting
        }
    }
}
