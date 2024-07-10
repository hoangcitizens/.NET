/*
   Bài 4. Hãy viết chương trình nhập vào mảng 2 chiều hình chữ nhật, tìm phần tử x (x nhập từ bàn phím)
          có nằm trong mảng trên không? In ra vị trí của phần tử nếu nằm trong mảng.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class ex4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số hàng: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"(*) Nhập hàng thứ {i + 1}");
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Nhập a[{i},{j}] = ");
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mảng vừa nhập là: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Nhập phần tử cần tìm: ");
            int x = int.Parse(Console.ReadLine());
            bool kt = false;
            Console.Write($"Vị trí của {x} là: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i,j] == x)
                    {
                        Console.Write($"a[{i}][{j}] ");
                        kt = true;
                    }    
                }    
            }
            if (kt == false)
                Console.WriteLine($"Không tìm thấy phần tử {x} trong mảng !!!");
            Console.ReadKey();
        }
    }
}
