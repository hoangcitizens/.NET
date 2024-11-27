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
using System.Text.Json;

namespace NguyenHuuHoang_21103100320_DHTI15A5HN
{
    public partial class Form2_21103100320 : Form
    {
        private Form1 form1; // Tham chiếu đến Form1
        private string duongDanAnh = ""; // Đường dẫn đến ảnh của nhân viên
        public Form2_21103100320(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1; // Nhận tham chiếu Form1
        }
        private bool KiemTraThongTinHopLe()
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(cbGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin bắt buộc.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Hàm xóa trắng các trường nhập liệu trên form
        private void XoaForm()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtBoPhan.Clear();
            txtChucVu.Clear();
            cbGioiTinh.SelectedIndex = -1;
            txtHopDong.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            dtpNgayVao.Value = DateTime.Now;
            dtpNgayRa.Value = DateTime.Now;
            txtCCCD.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            cbDanToc.SelectedIndex = -1;
            // Reset the image path
            duongDanAnh = "";
            // Optionally, reset the picture box if you have one
            // pictureBoxAnh.Image = null; 
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinHopLe())
            {
                NhanVien nv = LayThongTinTuForm();
                form1.danhSachNhanVien.Add(nv);
                form1.CapNhatDanhSachNhanVien();
                LuuDanhSachNhanVienRaFile("danhsachnhanvien.json", form1.danhSachNhanVien);
                XoaForm(); // Xóa trắng các trường để nhập tiếp
                MessageBox.Show("Đã thêm nhân viên mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv = LayThongTinTuForm();
            form1.danhSachNhanVien.Add(nv);
            form1.CapNhatDanhSachNhanVien();
            LuuDanhSachNhanVienRaFile("danhsachnhanvien.json", form1.danhSachNhanVien);
            this.Close(); // Đóng form sau khi lưu
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaForm(); // Xóa trắng form
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Hàm lấy thông tin từ form và tạo đối tượng NhanVien
        private NhanVien LayThongTinTuForm()
        {
            return new NhanVien
            {
                MaNV = txtMaNV.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cbGioiTinh.Text,
                BoPhan = txtBoPhan.Text,
                ChucVu = txtChucVu.Text,
                HopDong = txtHopDong.Text,
                DiaChi = txtDiaChi.Text,
                NgayVao = dtpNgayVao.Value,
                NgayRa = dtpNgayRa.Value,
                CCCD = txtCCCD.Text,
                SDT = txtSDT.Text,
                Email = txtEmail.Text,
                DanToc = cbDanToc.Text,
                DuongDanAnh = duongDanAnh
            };
        }
        // Lưu danh sách nhân viên ra file JSON
        private void LuuDanhSachNhanVienRaFile(string filePath, List<NhanVien> danhSachNhanVien)
        {
            string jsonData = System.Text.Json.JsonSerializer.Serialize(danhSachNhanVien, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonData);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                duongDanAnh = openFileDialog.FileName;
                picAnhNhanVien.Image = Image.FromFile(duongDanAnh); // Hiển thị ảnh lên PictureBox
            }
        }
    }
}
