using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Lab03
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            QuanLySinhVien quanLy = new QuanLySinhVien();
            while (true)
            {
                Console.WriteLine("\nChọn chức năng:");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Sửa sinh viên");
                Console.WriteLine("3. Xóa sinh viên");
                Console.WriteLine("4. Xuất số lượng sinh viên");
                Console.WriteLine("5. Xuất danh sách sinh viên theo lớp");
                Console.WriteLine("6. Thoát");
                Console.Write("Lựa chọn của bạn: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Thêm sinh viên
                        Console.Write("Nhập mã số sinh viên: ");
                        string maSo = Console.ReadLine();
                        Console.Write("Nhập họ tên: ");
                        string hoTen = Console.ReadLine();
                        Console.Write("Nhập năm sinh: ");
                        int namSinh = int.Parse(Console.ReadLine());
                        Console.Write("Nhập địa chỉ: ");
                        string diaChi = Console.ReadLine();
                        Console.Write("Nhập lớp học: ");
                        string lopHoc = Console.ReadLine();

                        SinhVien sv = new SinhVien(maSo, hoTen, namSinh, diaChi, lopHoc);
                        quanLy.ThemSinhVien(sv);
                        break;

                    case 2:
                        // Sửa sinh viên
                        Console.Write("Nhập mã số sinh viên cần sửa: ");
                        string maSoSua = Console.ReadLine();
                        quanLy.SuaSinhVien(maSoSua);
                        break;

                    case 3:
                        // Xóa sinh viên
                        Console.Write("Nhập mã số sinh viên cần xóa: ");
                        string maSoXoa = Console.ReadLine();
                        quanLy.XoaSinhVien(maSoXoa);
                        break;

                    case 4:
                        // Xuất số lượng sinh viên
                        quanLy.XuatSoLuongSinhVien();
                        break;

                    case 5:
                        // Xuất danh sách sinh viên theo lớp
                        Console.Write("Nhập lớp học cần xem: ");
                        string lopHocXem = Console.ReadLine();
                        quanLy.XuatSinhVienTheoLop(lopHocXem);
                        break;

                    case 6:
                        // Thoát chương trình
                        Console.WriteLine("Kết thúc chương trình.");
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}
