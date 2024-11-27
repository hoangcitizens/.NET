using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_XauKyTu_VD3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lay chuoi con trong C#");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nhập chuỗi bất kỳ: ");
            string str = Console.ReadLine();
            Console.WriteLine("Chuỗi ban đầu: " + str);
            string substr = str.Substring(10);
            Console.WriteLine("Chuỗi con: " + substr);
            Console.ReadKey();
        }
    }
}
