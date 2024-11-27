using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Test02
    {
        static void Main(string[] args)
        {           
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<SinhVien> danhSachSinhVien = new List<SinhVien>();
            int choice;

            do
            {
                Console.WriteLine("_____________________MENU___________________");
                Console.WriteLine("|1. Thêm sinh viên                          |");
                Console.WriteLine("|2. Sửa thông tin sinh viên                 |");
                Console.WriteLine("|3. Xóa sinh viên                           |");
                Console.WriteLine("|4. Danh sách sinh viên quê quán Nam Định   |");
                Console.WriteLine("|5. Sinh viên có điểm trung bình cao nhất   |");
                Console.WriteLine("|6. Hiển thị toàn bộ danh sách sinh viên    |");
                Console.WriteLine("|0. Thoát                                   |");
                Console.WriteLine("|___________________________________________|");
                Console.Write("Chọn chức năng: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Thêm sinh viên
                        SinhVien sv = new SinhVien();
                        sv.EnterInfo();
                        danhSachSinhVien.Add(sv);                                          
                        break;

                    case 2:
                        // Sửa thông tin sinh viên
                        Console.Write("Nhập tên sinh viên cần sửa: ");
                        string tenCanSua = Console.ReadLine();
                        SinhVien svSua = null;
                        foreach (SinhVien s in danhSachSinhVien)
                        {
                            if (s.FullName.Equals(tenCanSua))
                            {
                                svSua = s;
                                break; // Dừng vòng lặp ngay khi tìm thấy sinh viên
                            }
                        }
                        if (svSua != null)
                        {
                            Console.WriteLine("(!) Nhập thông tin mới");
                            svSua.EnterInfo();
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sinh viên.");
                        }                        
                        break;

                    case 3:
                        // Xóa sinh viên
                        Console.Write("Nhập tên sinh viên cần xóa: ");
                        string tenCanXoa = Console.ReadLine();
                        SinhVien svXoa = null;

                        foreach (var sinhVien in danhSachSinhVien)
                        {
                            if (sinhVien.FullName.Equals(tenCanXoa))
                            {
                                svXoa = sinhVien;
                                break;
                            }
                        }

                        if (svXoa != null)
                        {
                            danhSachSinhVien.Remove(svXoa);
                            Console.WriteLine("Đã xóa sinh viên.");
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sinh viên.");
                        }
                        break;

                    case 4:
                        // Hiển thị sinh viên có quê quán Nam Định
                        Console.WriteLine("-----------Danh sách sinh viên quê quán Nam Định------------");
                        foreach (var sinhVien in danhSachSinhVien)
                        {
                            if (sinhVien.Country.Equals("Nam Định"))
                                sinhVien.ShowInfo();
                            else
                            {
                                Console.WriteLine("Không có sinh viên nào quê quán Nam Định.");
                            }
                        }                                          
                        break;

                    case 5:
                        // Hiển thị sinh viên có điểm trung bình cao nhất
                        double maxAvgGrade = 0;
                        foreach (SinhVien s in danhSachSinhVien)
                        {
                            if (s.AvgGrade > maxAvgGrade)
                            {
                                maxAvgGrade = s.AvgGrade;
                            }
                        }
                        List<SinhVien> svDiemCaoNhat = new List<SinhVien>();
                        foreach (SinhVien s in danhSachSinhVien)
                        {
                            if (s.AvgGrade == maxAvgGrade)
                            {
                                svDiemCaoNhat.Add(s);
                            }
                        }
                        Console.WriteLine("--------------Sinh viên có điểm trung bình cao nhất-------------");
                        foreach (var sinhVien in svDiemCaoNhat)
                        {
                            sinhVien.ShowInfo();
                        }
                        break;
                    case 6:
                        // Hiển thị toàn bộ danh sách sinh viên
                        Console.WriteLine("Danh sách toàn bộ sinh viên:");
                        if (danhSachSinhVien.Count > 0)
                        {
                            foreach (var sinhVien in danhSachSinhVien)
                            {
                                sinhVien.ShowInfo();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Không có sinh viên nào trong danh sách.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Chọn chức năng không hợp lệ.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
