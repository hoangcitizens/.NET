using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_XauKyTu_VD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("So sanh chuoi trong C#");
            Console.WriteLine("-------------------------------");
            string str1, str2;
            Console.WriteLine("Nhập vào chuỗi thứ nhất: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Nhập vào chuỗi thứ hai: ");
            str2 = Console.ReadLine();

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + "va" + str2 + "la giong nhau");
            }
            else
            {
                Console.WriteLine(str1 + " va" + str2 + "la khong giong nhau.");
            }
            Console.ReadKey();
        }
    }
}
