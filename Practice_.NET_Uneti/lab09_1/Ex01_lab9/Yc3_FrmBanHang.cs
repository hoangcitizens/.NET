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
    public partial class Yc3_FrmBanHang : Form
    {
        SqlConnection conn;
        Database3 db = new Database3();
        int d = 0;
        private void openConnect()
        {
            conn = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QLBH_LAB9.mdf;
                Integrated Security=True;Connect Timeout=30");
            conn.Open();
        }
        private void closeConnect()
        {
            conn.Close();
        }
        public Yc3_FrmBanHang()
        {
            InitializeComponent();
        }
        public DataTable danhSachChitietMathang(string soHoadon)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM tblChiTietBanHang WHERE SoHieuHD = @shd";
            //Khai báo SqlCommad
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("shd", soHoadon);
            //Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();
            //Đổ vào bảngbang.Load(reader);
            closeConnect();
            return bang;
        }
        public Boolean kiemTraSoHoadon(string soHieuHoadon)
        {
            Boolean kiemTra = false;
            openConnect();
            string sql = "SELECT * FROM tblBanHang WHERE SoHieuHD = @sh";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("sh", soHieuHoadon);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                kiemTra = true;
            }
            closeConnect();
            return kiemTra;
        }
        void themBanhang(string soHieuHoadon, string maKH, DateTime ngayMua)
        {
            openConnect();
            string sql = "INSERT INTO tblBanHang VALUES(@sh, @maKH, @ngay)";
            SqlCommand cmdBanhang = new SqlCommand(sql, conn);
            cmdBanhang.Parameters.AddWithValue("sh", soHieuHoadon);
            cmdBanhang.Parameters.AddWithValue("maKH", maKH);
            cmdBanhang.Parameters.AddWithValue("ngay", ngayMua);
            cmdBanhang.ExecuteNonQuery(); closeConnect();
        }
        public void themChitietBanhang(string soHieuHoadon, string mamh, int soLuong, float donGia)
        {
            openConnect();
            string sql = "INSERT INTO tblChiTietBanHang VALUES(@sh, @mamh, @sl, @dg)";
            SqlCommand cmdBanhang = new SqlCommand(sql, conn);
            cmdBanhang.Parameters.AddWithValue("sh", soHieuHoadon);
            cmdBanhang.Parameters.AddWithValue("mamh", mamh);
            cmdBanhang.Parameters.AddWithValue("sl", soLuong);
            cmdBanhang.Parameters.AddWithValue("dg", donGia);
            cmdBanhang.ExecuteNonQuery();
            closeConnect();
        }
        public void suaChitietBanhang(int soluong, float dongia, string mamh)
        {
            openConnect();
            string sql = "UPDATE tblChiTietBanHang SET SoLuong=@sl,DonGia = @dg where MaMH = @ma";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("sl", soluong);
            cmd.Parameters.AddWithValue("dg", dongia);
            cmd.Parameters.AddWithValue("ma", mamh);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void xoaChitietBanHang(int sh, string mamh)
        {
            openConnect();
            string sql = "DELETE tblChitietBanHang WHERE MaMH = @ma and SoHieuHD = @sh";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            cmd.Parameters.AddWithValue("sh", sh);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        bool kiemtra_du_lieu()
        {
            if (kiemtra(txt_shd.Text) || kiemtra(txt_makh.Text) ||
            kiemtra(date_ngaymua.Text) || kiemtra(txt_mamh.Text)
            || kiemtra(txt_soluong.Text) ||
            kiemtra(txt_dongia.Text)) return false;
            int shd; double dongia;
            if (!int.TryParse(txt_shd.Text, out shd))
                return false;
            if (!int.TryParse(txt_soluong.Text, out shd)) return
            false;
            if (!double.TryParse(txt_dongia.Text, out dongia))
                return false;
            return true;
        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }
        void reset()
        {
            txt_mamh.ResetText();
            txt_soluong.ResetText();
            txt_dongia.ResetText();
        }
        void vohieuhoa1(bool gt)
        {
            txt_shd.Enabled = gt;
            txt_makh.Enabled = gt;
            date_ngaymua.Enabled = gt;
        }
        void vohieuhoa2(bool gt)
        {
            txt_shd.Enabled = gt;
            txt_makh.Enabled = gt;
            date_ngaymua.Enabled = gt;
            txt_mamh.Enabled = gt;
            txt_soluong.Enabled = gt;
            txt_dongia.Enabled = gt;
        }
        private void Dua_DL_listview(string soHoadon)
        {
            listview_chitietBH.Items.Clear();
            int d = 1;
            foreach (DataRow dr in db.danhSachChitietMathang(soHoadon).Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = d.ToString();
                item.SubItems.Add(dr["MaMH"].ToString());
                item.SubItems.Add(dr["SoHieuHD"].ToString());
                item.SubItems.Add(dr["SoLuong"].ToString());
                item.SubItems.Add(dr["DonGia"].ToString());
                item.SubItems.Add((int.Parse(dr["SoLuong"].ToString()) *
                float.Parse(dr["DonGia"].ToString())).ToString());
                listview_chitietBH.Items.Add(item);
                d++;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yc3_FrmBanHang_Load(object sender, EventArgs e)
        {
            vohieuhoa2(false);
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;

            // Thêm các cột vào listview_chitietBH
            listview_chitietBH.Columns.Add("STT", 50);
            listview_chitietBH.Columns.Add("Mã MH", 100);
            listview_chitietBH.Columns.Add("Số hiệu HĐ", 100);
            listview_chitietBH.Columns.Add("Số lượng", 100);
            listview_chitietBH.Columns.Add("Đơn giá", 100);
            listview_chitietBH.Columns.Add("Thành tiền", 100);

            // Gọi phương thức Dua_DL_listview với mã hóa đơn hợp lệ (giả sử mã là "1001")
            string soHoadon1 = "1001";
            //string soHoadon2 = "1002";
            //string soHoadon3 = "1003";
            
            Dua_DL_listview(soHoadon1);
            //Dua_DL_listview(soHoadon2);
            //Dua_DL_listview(soHoadon3);
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (string.Compare(bt_them.Text, "Thêm") == 0)
            {
                if (d == 0)
                {
                    vohieuhoa2(true); bt_xoa.Enabled = true;
                    bt_sua.Enabled = true;
                }
                else
                {
                    vohieuhoa1(true); vohieuhoa1(false);
                }
                txt_mamh.Enabled = true;
                bt_them.Text = "Lưu";
            }
            else if (kiemtra_du_lieu())
            {
                if (db.kiemTraSoHoadon(txt_shd.Text) && d == 0)
                {
                    MessageBox.Show("Số hiệu hóa đơn đã tồn tại.\nKiểm tra lại!");
                    txt_shd.Focus();
                }
                else
                {
                    if (!db.kiemTraSoHoadon(txt_shd.Text))
                    {
                        db.themBanhang(txt_shd.Text, txt_makh.Text,
                    Convert.ToDateTime(date_ngaymua.Text));
                        bt_them.Text = "Thêm"; vohieuhoa1(false);
                    }
                    db.themChitietBanhang(txt_shd.Text,
                    txt_mamh.Text, int.Parse(txt_soluong.Text),
                    float.Parse(txt_dongia.Text));
                    reset(); bt_them.Text = "Thêm";
                    vohieuhoa1(false); d++;
                    Dua_DL_listview(txt_shd.Text);
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ","Thông báo lỗi"); 
                bt_them.Text = "Lưu";
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (string.Compare(bt_sua.Text, "Sửa") == 0)
            {
                txt_shd.Enabled = false;
                txt_makh.Enabled = false;
                date_ngaymua.Enabled = false;
                txt_mamh.Enabled = false;
                bt_sua.Text = "Cập nhật";
            }
            else if (kiemtra_du_lieu())
            {
                for (int i = 0; i < listview_chitietBH.Items.Count; i++)
                {
                    db.suaChitietBanhang(int.Parse(txt_soluong.Text),
                    float.Parse(txt_dongia.Text), txt_mamh.Text);
                    Dua_DL_listview(txt_shd.Text);
                }
                bt_sua.Text = "Sửa";
            }
            else
            {
                MessageBox.Show("Dữ liệu sửa không hợp lệ");
                bt_sua.Text = "Cập nhật";
            }
        }

        private void listview_chitietBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listview_chitietBH.SelectedItems.Count; i++)
                {                 
                    txt_mamh.Text = listview_chitietBH.SelectedItems[i].SubItems[1].Text;
                    txt_shd.Text = listview_chitietBH.SelectedItems[i].SubItems[2].Text;
                    txt_soluong.Text = listview_chitietBH.SelectedItems[i].SubItems[3].Text;
                    txt_dongia.Text = listview_chitietBH.SelectedItems[i].SubItems[4].Text;
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn phần tử để xóa");
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
{
                db.xoaChitietBanHang(int.Parse(txt_shd.Text),
                txt_mamh.Text);
                Dua_DL_listview(txt_shd.Text);
            }
        }
    }
}
