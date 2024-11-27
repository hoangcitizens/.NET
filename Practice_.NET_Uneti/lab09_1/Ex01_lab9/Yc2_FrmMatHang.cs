using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ex01_lab9
{
    public partial class Yc2_FrmMatHang : Form
    {
        SqlConnection conn;
        Database2 db = new Database2();
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
        public Yc2_FrmMatHang()
        {
            InitializeComponent();
            vohieuhoa(false);
            Dua_DL_listview();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DataTable danhSachMathang()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM tblMatHang";//Khai báo SqlCommad
            SqlCommand cmd = new SqlCommand(sql, conn);
            //Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();
            //Đổ vào bảng
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public void themMathang(string MaMH, string TenMatHang, string dvt)
        {
            openConnect();
            string sqlInsert = "INSERT INTO tblMatHang VALUES(@MaMH,@TenMatHang,@DVT)";
            SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn);
            cmdInsert.Parameters.AddWithValue("MaMH", MaMH);
            cmdInsert.Parameters.AddWithValue("TenMatHang", TenMatHang);
            cmdInsert.Parameters.AddWithValue("DVT", dvt);
            cmdInsert.ExecuteNonQuery();
            closeConnect();
        }
        public void suaMathang(string TenMatHang, string dvt, string MaMH)
        {
            openConnect(); string sqlUpdate = "UPDATE tblMatHang SET TenMatHang = @TenMatHang,DVT = @DVT WHERE MaMH = @MaMH";
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
            cmd.Parameters.AddWithValue("TenMatHang", TenMatHang);
            cmd.Parameters.AddWithValue("DVT", dvt);
            cmd.Parameters.AddWithValue("MaMH", MaMH);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public DataTable timKiemMathang(string MaMH)
        {
            openConnect();
            DataTable bang = new DataTable();
            string sqlTimkiem = "SELECT * FROM tblMatHang WHERE MaMH = @MaMH";
            SqlCommand cmd = new SqlCommand(sqlTimkiem, conn);
            cmd.Parameters.AddWithValue("MaMH", MaMH);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) { bang.Load(reader); }
            else bang =
            null;
            closeConnect();
            return bang;
        }
        public void xoaMathang(string MaMH)
        {
            openConnect();
            string sql = "DELETE tblMatHang WHERE MaMH = @MaMH"; SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaMH", MaMH);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public Boolean kiemTraMaMathang(string MaMH)
        {
            Boolean kiemTra = false;
            openConnect();
            string sql = "SELECT * FROM tblMatHang WHERE MaMH = @MaMH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaMH", MaMH);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                kiemTra = true;
            }
            closeConnect();
            return kiemTra;
        }
        void vohieuhoa(bool gt)
        {
            txt_dvtinh.Enabled = gt; 
            txt_tenmh.Enabled = gt;
            txt_mamh.Enabled = gt;
        }
        bool kiemtra_du_lieu()
        {
            if (kiemtra(txt_tenmh.Text) || kiemtra(txt_mamh.Text) || kiemtra(txt_dvtinh.Text)) 
                return false;
            return true;
        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return true;
            else return false;
        }
        void reset()
        {
            txt_dvtinh.ResetText();
            txt_mamh.ResetText();
            txt_tenmh.ResetText();
        }
        private void Dua_DL_listview()
        {
            //Đưa mặt hàng vào listview
            listview_mathang.Items.Clear();
            foreach (DataRow dr in db.danhSachMathang().Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["MaMH"].ToString();
                item.SubItems.Add(dr["TenMatHang"].ToString());
                item.SubItems.Add(dr["DVT"].ToString());
                listview_mathang.Items.Add(item);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.Compare(btnThem.Text, "Thêm") == 0)
            {
                // Chuyển đổi chế độ từ "Thêm" sang "Lưu"
                vohieuhoa(true); // Kích hoạt các trường nhập liệu
                txt_tenmh.Focus(); // Đặt tiêu điểm vào trường mã mặt hàng
                btnThem.Text = "Lưu"; // Đổi nút từ "Thêm" sang "Lưu"
            }
            else if (kiemtra_du_lieu()) // Kiểm tra dữ liệu nhập vào
            {
                // Kiểm tra xem mã mặt hàng đã tồn tại chưa
                if (db.kiemTraMaMathang(txt_tenmh.Text))
                {
                    MessageBox.Show("Trùng mã mặt hàng", "Thông báo");
                    txt_tenmh.Focus(); // Đặt tiêu điểm vào trường mã mặt hàng
                }
                else
                {
                    // Thêm mặt hàng vào cơ sở dữ liệu
                    try
                    {
                        db.themMathang(txt_mamh.Text, txt_tenmh.Text, txt_dvtinh.Text);
                        MessageBox.Show("Thêm mặt hàng thành công!", "Thông báo");

                        // Làm mới ListView để hiển thị dữ liệu mới
                        Dua_DL_listview(); // Cập nhật ListView

                        reset(); // Reset các trường nhập liệu
                        btnThem.Text = "Thêm"; // Đặt lại nút về trạng thái ban đầu
                        vohieuhoa(false); // Vô hiệu hóa các trường nhập liệu
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi trong quá trình thêm: " + ex.Message, "Thông báo lỗi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo lỗi");
                btnThem.Text = "Lưu"; // Đặt lại nút về trạng thái lưu
            }
        }
   

        private void FrmMatHang_Load(object sender, EventArgs e)
        {
            vohieuhoa(false);
            Dua_DL_listview();
            listview_mathang.Columns.Add("Mã mặt hàng", 150);
            listview_mathang.Columns.Add("Tên mặt hàng", 200);
            listview_mathang.Columns.Add("Đơn vị tính", 150);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
{
                try
                {
                    db.xoaMathang(txt_tenmh.Text);
                    listview_mathang.Items.Clear();
                    Dua_DL_listview();
                    reset();
                }
                catch
                {
                    MessageBox.Show("Có lỗi khi xóa!", "Thông báo lỗi");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.Compare(btnSua.Text, "Sửa") == 0)
            {
                vohieuhoa(true); 
                txt_mamh.Enabled = false;
                txt_tenmh.Focus(); 
                btnSua.Text = "Cập nhật";
            }
            else if (kiemtra_du_lieu())
            {
                //Cập nhật vào csdl
                try
                {
                    db.suaMathang(txt_mamh.Text, txt_tenmh.Text, txt_dvtinh.Text);
                    Dua_DL_listview(); btnSua.Text = "Sửa";
                    vohieuhoa(false); reset();
                }
                catch
                {
                    MessageBox.Show("Có lỗi trong quá trình sửa!",
                    "Thông báo lỗi");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu sửa không hợp lệ");
                btnSua.Text = "Cập nhật";
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã mặt hàng cần tìm kiếm", "Tìm kiếm");
            if (db.timKiemMathang(ma) != null)
            {
                //Đưa khách hàng vào listview
                listview_mathang.Items.Clear();
                foreach (DataRow dr in db.timKiemMathang(ma).Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dr["MaMH"].ToString();
                    item.SubItems.Add(dr["TenMatHang"].ToString());
                    item.SubItems.Add(dr["DVT"].ToString());
                    listview_mathang.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Tìm kiếm không thấy", "Thông báo tìm kiếm");
            }
        }

        private void listview_mathang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listview_mathang.SelectedItems.Count; i++)
                {
                    txt_mamh.Text =
                    listview_mathang.SelectedItems[i].SubItems[0].Text;
                    txt_tenmh.Text =
                    listview_mathang.SelectedItems[i].SubItems[1].Text;
                    txt_dvtinh.Text =
                    listview_mathang.SelectedItems[i].SubItems[2].Text;
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn phần tử để xóa");
            }
        }
    }
}
