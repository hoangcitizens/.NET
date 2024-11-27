using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class KhachHangVietNam : KhachHang
    {
        private string loaiKhachHang;
        private double dinhMuc;
        // Thuộc tính
        public string LoaiKhachHang
        {
            get { return loaiKhachHang; }
            set { loaiKhachHang = value; }
        }
        public double DinhMuc
        {
            get { return dinhMuc; }
            set
            {
                dinhMuc = value;
            }
        }

        // Hàm tạo
        public KhachHangVietNam(string maKhachHang, int soLuong, double donGia,
            string hoTen, DateTime ngayHoaDon, string loaiKhachHang, double dinhMuc)
            : base(maKhachHang, soLuong, donGia, hoTen, ngayHoaDon)
        {
            LoaiKhachHang = loaiKhachHang;
            DinhMuc = dinhMuc;
        }

        // Hàm hủy
        ~KhachHangVietNam() { }

        // Phương thức nhập
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập loại khách hàng: ");
            LoaiKhachHang = Console.ReadLine();
            Console.Write("Nhập định mức: ");
            DinhMuc = double.Parse(Console.ReadLine());
        }

        // Phương thức xuất
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Loại KH: {LoaiKhachHang}, Định mức: {DinhMuc}");
        }
    }
}
