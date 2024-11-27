using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD2
{
    public partial class frmVD2 : Form
    {
        public frmVD2()
        {
            InitializeComponent();
        }

        private void cbopt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((txtso1.Text == "") || (txtso2.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập vào một số", "Nhập liệu");
                txtso1.Focus();
            }
            else
            {
                double so1, so2, cong, tru, nhan, chia;
                int pt;
                so1 = Convert.ToDouble(txtso1.Text);
                so2 = Convert.ToDouble(txtso2.Text);
                pt = cbopt.SelectedIndex; //Lấy chỉ số mục được chọn
            switch (pt)
                {
                    case 0:
                        cong = so1 + so2;
                        txtkq.Text = cong.ToString();
                        break;
                    case 1:
                        tru = so1 - so2;
                        txtkq.Text = tru.ToString();
                        break;
                    case 2:
                        nhan = so1 * so2;
                        txtkq.Text = nhan.ToString();
                        break;
                    case 3:
                        if (so2 != 0)
                        {
                            chia = so1 / so2;
                            txtkq.Text = chia.ToString();
                            break;
                        }
                        else
                            MessageBox.Show("Không chia được do mẫu số = 0");
                        break;
                }
            }
        }
    }
}
