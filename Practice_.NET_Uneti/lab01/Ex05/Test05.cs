using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Test05
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số lượng khách hàng: ");
            int n = int.Parse(Console.ReadLine());
            KhachHang[] danhSachKhachHang = new KhachHang[n];

            // Nhập thông tin cho từng khách hàng
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin cho khách hàng thứ {i + 1}:");
                Console.Write("Nhập loại khách hàng (VN/NN): ");
                string loaiKhachHang = Console.ReadLine();

                if (loaiKhachHang.Equals("NN", StringComparison.OrdinalIgnoreCase))
                {
                    danhSachKhachHang[i] = new KhachHangNuocNgoai("", 0, 0, "", DateTime.Now, "");
                    danhSachKhachHang[i].Nhap();
                }
                else if (loaiKhachHang.Equals("VN", StringComparison.OrdinalIgnoreCase))
                {
                    danhSachKhachHang[i] = new KhachHangVietNam("", 0, 0, "", DateTime.Now, "", 0);
                    danhSachKhachHang[i].Nhap();
                }
                else
                {
                    Console.WriteLine("Loại khách hàng không hợp lệ. Vui lòng nhập lại.");
                    i--; // Giảm i để yêu cầu nhập lại
                }
            }

            // Hiển thị danh sách khách hàng
            Console.WriteLine("\nDanh sách khách hàng:");
            foreach (var khach in danhSachKhachHang)
            {
                khach.Xuat();
            }

            // Tính tổng số lượng điện tiêu thụ cho từng loại khách hàng
            int tongKhachVN = 0, tongKhachNN = 0;
            foreach (var khach in danhSachKhachHang)
            {
                if (khach is KhachHangVietNam)
                {
                    tongKhachVN += khach.SoLuong;
                }
                else if (khach is KhachHangNuocNgoai)
                {
                    tongKhachNN += khach.SoLuong;
                }
            }
            Console.WriteLine($"\nTổng số lượng điện tiêu thụ của khách hàng Việt Nam: {tongKhachVN}");
            Console.WriteLine($"Tổng số lượng điện tiêu thụ của khách hàng nước ngoài: {tongKhachNN}");

            // Tính trung bình thành tiền của khách hàng nước ngoài
            double tongTienNN = 0;
            int countNN = 0;
            foreach (var khach in danhSachKhachHang)
            {
                if (khach is KhachHangNuocNgoai)
                {
                    tongTienNN += khach.ThanhTien;
                    countNN++;
                }
            }

            double trungBinhTienNN = countNN > 0 ? tongTienNN / countNN : 0;
            Console.WriteLine($"Trung bình thành tiền của khách hàng nước ngoài: {trungBinhTienNN}");

            // Xuất hóa đơn trong tháng 09 năm 2020
            Console.WriteLine("\nHóa đơn trong tháng 09 năm 2020:");
            foreach (var khach in danhSachKhachHang)
            {
                if (khach.NgayHoaDon.Year == 2020 && khach.NgayHoaDon.Month == 9)
                {
                    khach.Xuat();
                }
            }
        }
    }
}
