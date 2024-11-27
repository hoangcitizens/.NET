using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Test03
    {
        static void Main(string[] args)
        {
            // Khai báo đối tượng lớp VanDongVien
            VanDongVien p = new VanDongVien("Nguyen Van A", 25, "Bơi", 70.5, 1.75);
            Console.WriteLine("Thông tin vận động viên p:");
            p.ShowInfo();

            // Nhập số lượng vận động viên
            Console.Write("Nhập số lượng vận động viên: ");
            int n = int.Parse(Console.ReadLine());
            VanDongVien[] danhSachVanDongVien = new VanDongVien[n];

            // Nhập thông tin cho từng vận động viên
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin cho vận động viên thứ {i + 1}:");
                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine();
                Console.Write("Tuổi: ");
                int tuoi = int.Parse(Console.ReadLine());
                Console.Write("Môn thi đấu: ");
                string monThiDau = Console.ReadLine();
                Console.Write("Cân nặng: ");
                double canNang = double.Parse(Console.ReadLine());
                Console.Write("Chiều cao: ");
                double chieuCao = double.Parse(Console.ReadLine());

                // Khởi tạo đối tượng và thêm vào mảng
                danhSachVanDongVien[i] = new VanDongVien(hoTen, tuoi, monThiDau, canNang, chieuCao);
            }

            // Hiển thị danh sách vận động viên đã nhập
            Console.WriteLine("\nDanh sách vận động viên đã nhập:");
            foreach (var vanDongVien in danhSachVanDongVien)
            {
                vanDongVien.ShowInfo();
            }

            // Sắp xếp mảng theo tuổi
            Array.Sort(danhSachVanDongVien, (a, b) => a.Tuoi.CompareTo(b.Tuoi));

            // Hiển thị danh sách đã sắp xếp
            Console.WriteLine("\nDanh sách vận động viên đã sắp xếp theo tuổi:");
            foreach (var vanDongVien in danhSachVanDongVien)
            {
                vanDongVien.ShowInfo();
            }
        }
    }
}
