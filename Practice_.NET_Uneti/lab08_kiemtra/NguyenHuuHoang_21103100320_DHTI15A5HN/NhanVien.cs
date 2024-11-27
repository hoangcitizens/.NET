using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_21103100320_DHTI15A5HN
{
    public class NhanVien
    {
        // Thông tin cơ bản
        public string MaNV { get; set; }            // Mã nhân viên
        public string HoTen { get; set; }            // Họ và tên
        public DateTime NgaySinh { get; set; }       // Ngày sinh
        public string GioiTinh { get; set; }         // Giới tính
        public string BoPhan { get; set; }           // Bộ phận
        public string ChucVu { get; set; }           // Chức vụ
        public string HopDong { get; set; }          // Hợp đồng

        // Thông tin cơ bản mở rộng
        public string DiaChi { get; set; }           // Địa chỉ
        public DateTime NgayVao { get; set; }        // Ngày vào công ty
        public DateTime? NgayRa { get; set; }        // Ngày ra công ty (có thể là null nếu chưa nghỉ)
        public string CCCD { get; set; }             // Căn cước công dân
        public string SDT { get; set; }              // Số điện thoại
        public string Email { get; set; }            // Email
        public string DanToc { get; set; }           // Dân tộc

        // Ảnh nhân viên
        public string DuongDanAnh { get; set; }      // Đường dẫn đến ảnh nhân viên

        // Constructor mặc định
        public NhanVien()
        {
        }

        // Constructor với tham số
        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, string gioiTinh, string boPhan,
                        string chucVu, string hopDong, string diaChi, DateTime ngayVao, DateTime? ngayRa,
                        string cccd, string sdt, string email, string danToc, string duongDanAnh)
        {
            MaNV = maNV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            BoPhan = boPhan;
            ChucVu = chucVu;
            HopDong = hopDong;
            DiaChi = diaChi;
            NgayVao = ngayVao;
            NgayRa = ngayRa;
            CCCD = cccd;
            SDT = sdt;
            Email = email;
            DanToc = danToc;
            DuongDanAnh = duongDanAnh;
        }

        // Phương thức để hiển thị thông tin nhân viên
        public override string ToString()
        {
            return $"Mã NV: {MaNV}, Họ tên: {HoTen}, Ngày sinh: {NgaySinh.ToShortDateString()}, Giới tính: {GioiTinh}, " +
                   $"Bộ phận: {BoPhan}, Chức vụ: {ChucVu}, Hợp đồng: {HopDong}, Địa chỉ: {DiaChi}, " +
                   $"Ngày vào: {NgayVao.ToShortDateString()}, Ngày ra: {(NgayRa.HasValue ? NgayRa.Value.ToShortDateString() : "Chưa rời")}, " +
                   $"CCCD: {CCCD}, SĐT: {SDT}, Email: {Email}, Dân tộc: {DanToc}, Đường dẫn ảnh: {DuongDanAnh}";
        }
    }
}
