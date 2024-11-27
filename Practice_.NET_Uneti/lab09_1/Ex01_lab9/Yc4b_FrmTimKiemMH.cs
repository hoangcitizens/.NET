using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_lab9
{
    public partial class Yc4b_FrmTimKiemMH : Form
    {
        SqlConnection conn;
        Database5 db = new Database5();
        private void openConnect()
        {
            conn = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QLBH_LAB9.mdf;
                Integrated Security=True;Connect Timeout=30");
            conn.Open();
        }
        public Yc4b_FrmTimKiemMH()
        {
            InitializeComponent();
            listview_kqtimkiem.Columns.Add("Mã MH", 80);
            listview_kqtimkiem.Columns.Add("Tên Mặt Hàng", 180);
            listview_kqtimkiem.Columns.Add("Đơn Vị Tính", 100);
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            DataTable bangKetqua = new DataTable();
            if (radio_mamh.Checked) // Tim kiem theo ma
            {
                bangKetqua = db.timKiemMathang("MaMH", txt_noidungTK.Text);
            }
            else // Tìm kiếm theo ten
            {
            bangKetqua = db.timKiemMathang("TenMatHang", txt_noidungTK.Text);
            }
            if (bangKetqua == null)
            {
                MessageBox.Show("Tìm kiếm không thấy", "Thông báo tìm kiếm");
            }
            else
            {
                listview_kqtimkiem.Items.Clear();
                foreach (DataRow dr in bangKetqua.Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dr["MaMH"].ToString();
                    item.SubItems.Add(dr["TenMatHang"].ToString());
                    item.SubItems.Add(dr["DVT"].ToString());
                    listview_kqtimkiem.Items.Add(item);
                }
            }
        }
    }
}
