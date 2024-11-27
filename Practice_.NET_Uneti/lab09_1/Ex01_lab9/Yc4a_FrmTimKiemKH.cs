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
    public partial class Yc4a_FrmTimKiemKH : Form
    {
        SqlConnection conn;
        Database4 db = new Database4();
        private void openConnect()
        {
            conn = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QLBH_LAB9.mdf;
                Integrated Security=True;Connect Timeout=30");
            conn.Open();
        }
        public Yc4a_FrmTimKiemKH()
        {
            InitializeComponent();
            listview_kqtimkiem.Columns.Add("Mã KH", 70);
            listview_kqtimkiem.Columns.Add("Họ tên", 160);
            listview_kqtimkiem.Columns.Add("Giới tính", 70);
            listview_kqtimkiem.Columns.Add("Địa chỉ", 100);
            listview_kqtimkiem.Columns.Add("Điện thoại", 120);

        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            DataTable bangKetqua = new DataTable();
            if (radio_makh.Checked) // Tim kiem theo ma
            {
                bangKetqua = db.timKiemKhachhang("MaKH", txt_noidungTK.Text);
            }
            else if (radio_tenkh.Checked) // Tìm kiếm theo ten
            {
                bangKetqua = db.timKiemKhachhang("HoTen", txt_noidungTK.Text);
            }
            else
            {
                bangKetqua = db.timKiemKhachhang("DienThoai", txt_noidungTK.Text);
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
                    item.Text = dr["MaKH"].ToString();
                    item.SubItems.Add(dr["Hoten"].ToString());
                    item.SubItems.Add(dr["Gioitinh"].ToString());
                    item.SubItems.Add(dr["Diachi"].ToString());
                    item.SubItems.Add(dr["Dienthoai"].ToString());
                    listview_kqtimkiem.Items.Add(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
