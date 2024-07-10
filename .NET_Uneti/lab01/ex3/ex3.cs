using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bài 3: Tìm UCLN của 2 số nguyên dương a và b dùng while
namespace ex3
{
    internal class ex3
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("UCLN cua {0} và {1} la: ", a, b);
            int tmp = 0;
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            tmp = a;
            Console.Write(tmp);
            Console.Read();
        }
    }
}
