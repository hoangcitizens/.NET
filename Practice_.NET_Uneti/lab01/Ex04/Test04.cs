using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Test04
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số lượng hành khách: ");
            int n = int.Parse(Console.ReadLine());
            HanhKhach[] danhSachHanhKhach = new HanhKhach[n];

            // Nhập thông tin cho từng hành khách
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin cho hành khách thứ {i + 1}:");
                danhSachHanhKhach[i] = new HanhKhach("", "", 0, 0);
                danhSachHanhKhach[i].Nhap();
            }
            // Hiển thị danh sách hành khách
            Console.WriteLine("\nDanh sách hành khách:");
            foreach (var khach in danhSachHanhKhach)
            {
                khach.Xuat();
                Console.WriteLine($"Tổng tiền: {khach.TongTien()}");
                Console.WriteLine("-----------------------");
            }
            // Sắp xếp danh sách hành khách theo tổng tiền giảm dần
            Array.Sort(danhSachHanhKhach, (a, b) => b.TongTien().CompareTo(a.TongTien()));

            // Hiển thị danh sách đã sắp xếp
            Console.WriteLine("\nDanh sách hành khách đã sắp xếp theo tổng tiền:");
            foreach (var khach in danhSachHanhKhach)
            {
                khach.Xuat();
                Console.WriteLine($"Tổng tiền: {khach.TongTien()}");
                Console.WriteLine("-----------------------");
            }
        }
    }
}
