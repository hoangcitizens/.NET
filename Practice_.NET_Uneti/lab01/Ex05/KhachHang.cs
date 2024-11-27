using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class KhachHang
    {
        private string maKhachHang;
        private int soLuong;
        private double donGia;
        private double thanhTien;
        private DateTime ngayHoaDon;
        private string hoTen;

        // Thuộc tính
        public string MaKhachHang 
        {
            get { return maKhachHang; }
            set { maKhachHang = value; }
        }
        public int SoLuong 
        { 
            get { return soLuong; }
            set { soLuong = value; }

        }
        public double DonGia
        {
            get { return donGia; }
            set
            {
                donGia = value;
            }
        }
        public double ThanhTien
        {
            get { return thanhTien; }
            set
            {
                thanhTien = value;
            }
        }
        public DateTime NgayHoaDon
        {
            get { return ngayHoaDon; }
            set
            {
                ngayHoaDon = value;
            }
        }
        public string HoTen
        {
            get { return hoTen; }
            set
            {
                hoTen = value;
            }
        }

        // Hàm tạo
        public KhachHang(string maKhachHang, int soLuong, double donGia, string hoTen, DateTime ngayHoaDon)
        {
            MaKhachHang = maKhachHang;
            SoLuong = soLuong;
            DonGia = donGia;
            HoTen = hoTen;
            NgayHoaDon = ngayHoaDon;
            ThanhTien = SoLuong * DonGia; // Tính thành tiền
        }

        // Hàm hủy
        ~KhachHang() { }

        // Phương thức nhập
        public void Nhap()
        {
            Console.Write("Nhập mã khách hàng: ");
            MaKhachHang = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập số lượng: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhập đơn giá: ");
            DonGia = double.Parse(Console.ReadLine());
            Console.Write("Nhập ngày hóa đơn (dd/MM/yyyy): ");
            NgayHoaDon = DateTime.Parse(Console.ReadLine());
            ThanhTien = SoLuong * DonGia; // Tính thành tiền
        }

        // Phương thức xuất
        public void Xuat()
        {
            Console.WriteLine($"Mã KH: {MaKhachHang}, Họ tên: {HoTen}, Số lượng: {SoLuong}, Đơn giá: {DonGia}, Thành tiền: {ThanhTien}, Ngày HĐ: {NgayHoaDon.ToShortDateString()}");
        }
    }
}
