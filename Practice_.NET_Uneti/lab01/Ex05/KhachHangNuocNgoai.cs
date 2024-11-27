using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class KhachHangNuocNgoai : KhachHang
    {
        private string quocTich;

        // Thuộc tính
        public string QuocTich
        {
            get { return quocTich; }
            set { quocTich = value; }
        }

        // Hàm tạo
        public KhachHangNuocNgoai(string maKhachHang, int soLuong, double donGia,
            string hoTen, DateTime ngayHoaDon, string quocTich)
            : base(maKhachHang, soLuong, donGia, hoTen, ngayHoaDon)
        {
            QuocTich = quocTich;
        }

        // Hàm hủy
        ~KhachHangNuocNgoai() { }

        // Phương thức nhập
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập quốc tịch: ");
            QuocTich = Console.ReadLine();
        }

        // Phương thức xuất
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Quốc tịch: {QuocTich}");
        }
    }
}
