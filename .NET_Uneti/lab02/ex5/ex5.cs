/*
    Bài 5. Viết chương trình nhập vào một mảng 1 chiều in ra màn hình các số là số chính phương của mảng
           (yêu cầu xây dựng hàm kiểm tra số chính phương)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class ex5
    {
        static bool checkSoChinhPhuong(int x)
        {
            int i = (int)Math.Sqrt(x);
            if (x < 1)
                return false;
            if (i * i == x)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            int []a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }    
            Console.WriteLine("Mảng vừa nhập là: ");
            for (int i = 0; i < n; i++)
                Console.Write("{0,4}", a[i]);
            Console.WriteLine("\nSố chính phương trong mảng là: ");
            for (int i = 0; i < n; i++)
            {
                if (checkSoChinhPhuong(a[i]))
                {
                    Console.Write("{0,4}", a[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
