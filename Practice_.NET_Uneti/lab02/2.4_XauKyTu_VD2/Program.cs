using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_XauKyTu_VD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiểm tra chuỗi con trong C#"); 
            Console.WriteLine("---------------------------");
            Console.WriteLine("Nhập chuỗi bất kỳ: ");
            string str = Console.ReadLine();
            Console.WriteLine("Nhập chuỗi cần kiểm tra");
            string strKT = Console.ReadLine();
            if (str.Contains(strKT))
            {
                Console.WriteLine($"Tìm thấy chuỗi con {strKT} trong chuỗi vừa nhập.");
            }
            Console.ReadKey();
        }
    }
}
