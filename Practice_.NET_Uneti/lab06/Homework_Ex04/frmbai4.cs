using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Ex04
{
    public partial class frmbai4 : Form
    {
        public frmbai4()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnSinhVien_Click(object sender, EventArgs e)
        {
            formphu frmcau2 = new formphu();
            frmcau2.MdiParent = this;
            // Tính toán vị trí để đặt form phụ ở giữa form chính
            frmcau2.StartPosition = FormStartPosition.Manual; // Đặt chế độ khởi động là Manual
            frmcau2.Location = new Point(
                this.Location.X + (this.Width - frmcau2.Width) / 2,
                this.Location.Y + (this.Height - frmcau2.Height) / 2
            );
            frmcau2.Show();
            this.Show();
        }
    }
}
