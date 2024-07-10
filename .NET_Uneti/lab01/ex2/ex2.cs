using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bài 2: Tính tích các số lẻ trong phạm vi n dùng for và if
namespace ex2
{
    internal class ex2
    {
        static void Main(string[] args)
        {
            int n, S = 1;
            Console.Write("Nhap n = ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    S *= i;
                } 
            }
            Console.WriteLine("Tich cac so tu 1 den {0} la: {1}", n, S);
            Console.ReadLine();
        }
    }
}
