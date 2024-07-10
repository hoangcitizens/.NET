using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;          
            // Đa hình
            //HocSinh hs = new HocSinh("Tuấn",2004,8,6);
            //Console.WriteLine($"Điểm trung bình: {hs.TinhDiemTrungBinh()}");
            //hs = new HocSinhVan("Bình", 2005, 8, 6, 7);
            //Console.WriteLine($"Điểm trung bình: {hs.TinhDiemTrungBinh()}");
            int n;
            Console.Write("Nhập số lượng học sinh: ");
            n = int.Parse(Console.ReadLine());
            HocSinh[] a = new HocSinh[n];
            int luaChon;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Mời nhập lựa chọn cho a[{i}]: Học sinh văn: 1; Học sinh Toán: Số khác 1");
                luaChon = int.Parse(Console.ReadLine());
                if(luaChon == 1)
                {
                    a[i] = new HocSinhVan();
                }
                else
                {
                    a[i] = new HocSinhToan();
                }
                a[i].nhap();
            }
            double S = 0;
            for (int i = 0; i < n; i++)
            {
                S += a[i].TinhDiemTrungBinh();
            }
            for (int i = 0; i < n; i++)
            {
                a[i].xuat();
            }    
            Console.WriteLine($"Điểm trung bình của tất cả học sinh là: {S}");
            Console.ReadLine();
        }
    }
}
