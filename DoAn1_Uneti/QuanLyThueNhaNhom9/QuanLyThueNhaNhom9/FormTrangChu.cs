using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueNhaNhom9
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
            var e = this.PointToScreen(label6.Location);
            e = panel3.PointToClient(e);
            label6.Parent = panel3;
            label6.Location = e;
            label6.BackColor = Color.Transparent;

            var a = this.PointToScreen(label2.Location);
            a = panel3.PointToClient(a);
            label2.Parent = panel3;
            label2.Location = a;
            label2.BackColor = Color.Transparent;

            var b = this.PointToScreen(label3.Location);
            b = panel3.PointToClient(b);
            label3.Parent = panel3;
            label3.Location = b;
            label3.BackColor = Color.Transparent;

            var c = this.PointToScreen(label4.Location);
            c = panel3.PointToClient(c);
            label4.Parent = panel3;
            label4.Location = c;
            label4.BackColor = Color.Transparent;

            var d = this.PointToScreen(label5.Location);
            d = panel3.PointToClient(d);
            label5.Parent = panel3;
            label5.Location = d;
            label5.BackColor = Color.Transparent;
        }
        private Form formTrangChu;
        private void OpenForm(Form form)
        {
            if (formTrangChu != null)
                formTrangChu.Close();
            formTrangChu = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            panel3.Tag = form;
            formTrangChu.BringToFront();
            formTrangChu.Show();
        }

        private void btnQuanLyNha_Click(object sender, EventArgs e)
        {
            OpenForm(new FormQuanLyChuNha());
        }

        private void btnQuanLyHopDong_Click(object sender, EventArgs e)
        {
            OpenForm(new FormQuanLyHopDong());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            OpenForm(new FormThanhToanHoaDon());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenForm(new FormBaoCaoThongKe());
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (formTrangChu != null)
                formTrangChu.Close();
        }
    }
}
