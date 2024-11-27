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

namespace Ex02_QLThuvien
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection
            ($@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename={Application.StartupPath}\QLTHUVIEN_LAB10.mdf;
                Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter da; //khai báo biến dataAdapter
        DataSet ds = new DataSet(); //khai báo 1 dataset
        //Database db = new Database();
        public Form1()
        {
            InitializeComponent();
            conn.Open();
            // Thêm các cột vào listview_chitietBH
            lsvNhanVien.Columns.Add("Họ tên", 170);
            lsvNhanVien.Columns.Add("Ngày sinh", 120);
            lsvNhanVien.Columns.Add("Điện thoại", 140);
            lsvNhanVien.Columns.Add("Địa chỉ", 300);
        }
        DataTable layDanhSachNhanVien() //lấy danh sách nhân viên
        {
            string sql = "Select * from NhanVien";

            // Xóa dữ liệu cũ trong DataSet trước khi nạp mới
            ds.Clear();

            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }
        void LoadListview()
        {
            // Xóa các item hiện có trong ListView để tránh lặp lại dữ liệu
            lsvNhanVien.Items.Clear();
            lsvNhanVien.FullRowSelect = true;//cho phép chọn 1 dòng
            lsvNhanVien.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
            DataTable dt = layDanhSachNhanVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvNhanVien.Items.Add(dt.Rows[i]["Hotennhanvien"].ToString());
                // dòng thứ i, tên cột là nhân viên
                lvi.SubItems.Add(dt.Rows[i][2].ToString()); //dùng chỉ số cột : dòng thứ i,cột thứ 1
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            LoadListview();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra độ dài của số điện thoại
                if (txtDienThoai.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có đúng 10 ký tự.");
                    return;
                }

                // Kiểm tra trùng lặp tên và số điện thoại trong cơ sở dữ liệu
                string checkSql = "SELECT COUNT(*) FROM NhanVien WHERE HoTenNhanVien = @HoTenNhanVien";
                using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                {
                    checkCmd.Parameters.AddWithValue("@HoTenNhanVien", txtHoten.Text);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Nhân viên này đã tồn tại trong hệ thống do trùng tên.");
                        return;
                    }
                }
                string checkSql2 = "SELECT COUNT(*) FROM NhanVien WHERE DienThoai = @DienThoai";
                using (SqlCommand checkCmd = new SqlCommand(checkSql2, conn))
                {
                    checkCmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Nhân viên này đã tồn tại trong hệ thống do trùng sdt.");
                        return;
                    }
                }

                // Nếu không trùng, tiến hành thêm nhân viên
                string sql = "INSERT INTO NhanVien (Hotennhanvien, NgaySinh, DiaChi, DienThoai, MaBangCap) " +
                             "VALUES (@Hoten, @NgaySinh, @DiaChi, @DienThoai, @MaBangCap)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Hoten", txtHoten.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
                    cmd.Parameters.AddWithValue("@MaBangCap", 1); // Giá trị mặc định cho cột cuối cùng
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm nhân viên thành công!");
                LoadListview(); // Tải lại danh sách sau khi thêm
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có chọn dòng nào trong ListView không
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                try
                {
                    // Lấy HoTenNhanVien của nhân viên từ dòng được chọn trong ListView
                    string hoTenNhanVien = lsvNhanVien.SelectedItems[0].SubItems[0].Text;

                    // Câu lệnh SQL xóa
                    string sql = "DELETE FROM NHANVIEN WHERE HoTenNhanVien = @HoTenNhanVien";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Thêm tham số cho câu lệnh xóa
                        cmd.Parameters.AddWithValue("@HoTenNhanVien", hoTenNhanVien);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xóa nhân viên thành công!");
                    LoadListview(); // Tải lại danh sách sau khi xóa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có chọn dòng nào trong ListView không
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                try
                {
                    // Lấy MaNhanVien từ dòng được chọn trong ListView
                    string hoTenNhanVien = lsvNhanVien.SelectedItems[0].SubItems[0].Text;

                    // Kiểm tra độ dài của số điện thoại
                    if (txtDienThoai.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại phải có đúng 10 ký tự.");
                        return;
                    }

                    // Kiểm tra trùng lặp tên và số điện thoại trong cơ sở dữ liệu
                    string checkSql = "SELECT COUNT(*) FROM NhanVien WHERE HoTenNhanVien = @HoTenNhanVien";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@HoTenNhanVien", txtHoten.Text);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Nhân viên này đã tồn tại trong hệ thống do trùng tên.");
                            return;
                        }
                    }
                    string checkSql2 = "SELECT COUNT(*) FROM NhanVien WHERE DienThoai = @DienThoai";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql2, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Nhân viên này đã tồn tại trong hệ thống do trùng sdt.");
                            return;
                        }
                    }

                    // Câu lệnh SQL để cập nhật thông tin nhân viên
                    string sql = "UPDATE NhanVien SET HoTenNhanVien = @Hoten, NgaySinh = @NgaySinh, " +
                                 "DiaChi = @DiaChi, DienThoai = @DienThoai WHERE MaNhanVien = @MaNhanVien";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Thêm các tham số cho câu lệnh cập nhật
                        cmd.Parameters.AddWithValue("@Hoten", txtHoten.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
                        //cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                        // Thực hiện câu lệnh cập nhật
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                    LoadListview(); // Tải lại danh sách sau khi cập nhật
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.");
            }
        }  
    }
}
