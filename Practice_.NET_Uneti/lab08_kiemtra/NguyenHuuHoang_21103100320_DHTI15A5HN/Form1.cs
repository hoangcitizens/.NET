using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHuuHoang_21103100320_DHTI15A5HN
{
    public partial class Form1 : Form
    {
        // Khai báo danh sách nhân viên
        public List<NhanVien> danhSachNhanVien;
        private int viTriHienTai = -1;
        // Hàm tải danh sách nhân viên từ file JSON
        private List<NhanVien> TaiDanhSachNhanVienTuFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<NhanVien>>(jsonData);

            }
            else
            {
                return new List<NhanVien>();
            }
        }
        // Hàm cập nhật danh sách nhân viên lên DataGridView
        public void CapNhatDanhSachNhanVien()
        {
            // Đảm bảo rằng DataGridView được clear trước khi bind dữ liệu mới
            dgvDanhSachNhanVien.DataSource = null;
            dgvDanhSachNhanVien.Rows.Clear();

            // Bind dữ liệu vào DataGridView
            dgvDanhSachNhanVien.DataSource = danhSachNhanVien;
        }
        public Form1()
        {
            InitializeComponent();
            try
            {
                // Tải dữ liệu nhân viên từ file khi khởi động chương trình
                danhSachNhanVien = TaiDanhSachNhanVienTuFile("danhsachnhanvien.json");

                // Kiểm tra dữ liệu đã được tải chưa
                if (danhSachNhanVien.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu nhân viên nào được tải.");
                }

                // Cập nhật danh sách nhân viên lên DataGridView
                CapNhatDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        
        // Hàm lưu danh sách nhân viên ra file JSON
        private void LuuDanhSachNhanVienRaFile(string filePath, List<NhanVien> danhSachNhanVien)
        {
            string jsonData = JsonConvert.SerializeObject(danhSachNhanVien, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (viTriHienTai >= 0 && viTriHienTai < danhSachNhanVien.Count)
            {
                danhSachNhanVien.RemoveAt(viTriHienTai);
                LuuDanhSachNhanVienRaFile("danhsachnhanvien.json", danhSachNhanVien);
                CapNhatDanhSachNhanVien();
                rtbThongTinNhanVien.Clear(); // Xóa thông tin hiển thị sau khi xóa
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2_21103100320 form2 = new Form2_21103100320(this); // Truyền tham chiếu của Form1 cho Form2
            form2.Show();
        }
        // Hiển thị thông tin nhân viên vào RichTextBox
        private void HienThiThongTinNhanVien(NhanVien nv)
        {
            rtbThongTinNhanVien.Text = $"Mã NV: {nv.MaNV}\n" +
                                       $"Họ tên: {nv.HoTen}\n" +
                                       $"Ngày sinh: {nv.NgaySinh.ToShortDateString()}\n" +
                                       $"Giới tính: {nv.GioiTinh}\n" +
                                       $"Bộ phận: {nv.BoPhan}\n" +
                                       $"Chức vụ: {nv.ChucVu}\n" +
                                       $"Hợp đồng: {nv.HopDong}\n" +
                                       $"Địa chỉ: {nv.DiaChi}\n" +
                                       $"Ngày vào: {nv.NgayVao.ToShortDateString()}\n" +
                                       $"Ngày ra: {(nv.NgayRa.HasValue ? nv.NgayRa.Value.ToShortDateString() : "Chưa rời")}\n" +
                                       $"CCCD: {nv.CCCD}\n" +
                                       $"SĐT: {nv.SDT}\n" +
                                       $"Email: {nv.Email}\n" +
                                       $"Dân tộc: {nv.DanToc}\n" +
                                       $"Đường dẫn ảnh: {nv.DuongDanAnh}";
        }
        // Nút tiến: Hiển thị nhân viên sau
        private void button2_Click(object sender, EventArgs e)
        {
            if (viTriHienTai < danhSachNhanVien.Count - 1)
            {
                viTriHienTai++;
                HienThiThongTinNhanVien(danhSachNhanVien[viTriHienTai]);
            }
        }

        // Nút lùi: Hiển thị nhân viên trước
        private void button1_Click(object sender, EventArgs e)
        {
            if (viTriHienTai > 0)
            {
                viTriHienTai--;
                HienThiThongTinNhanVien(danhSachNhanVien[viTriHienTai]);
            }
        }

        private void dgvDanhSachNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < danhSachNhanVien.Count)
            {
                viTriHienTai = e.RowIndex;
                HienThiThongTinNhanVien(danhSachNhanVien[e.RowIndex]);
            }
        }
    }
}
