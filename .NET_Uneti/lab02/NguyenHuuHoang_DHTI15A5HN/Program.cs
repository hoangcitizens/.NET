using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_DHTI15A5HN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hoten, dem;
            Console.Write("Nhap ho va ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap dem: ");
            dem = Console.ReadLine();

            // dùng hàm Trim() xóa dấu cách thừa
            Console.WriteLine("\nChuoi hoten khi them Trim(): " + hoten.Trim());       
            Console.WriteLine("Chuoi dem khi them Trim(): " + dem.Trim());

            // dùng hàm Insert và hàm IndexOf() để chèn vào hoten
            hoten = hoten.Insert(hoten.IndexOf(" ") + 1, dem + " ");
            Console.WriteLine("\nChuoi sau khi noi: " + hoten);

            // dùng hàm toUpper() in ra chuỗi hoa
            string hovaten = hoten.ToUpper();
            Console.WriteLine("\nChuoi sau khi in hoa la: " + hovaten);

            // tìm chữ "thi" và "van" trong chuỗi có thì in ra "con trai" con "thi" là "con gái"
            if (hoten.Contains("Thi"))
                Console.WriteLine("\nCon gai");
            else if (hoten.Contains("Van"))
                Console.WriteLine("\nCon trai");
            else
                Console.WriteLine("\nKhong xac dinh duoc gioi tinh");

        }
    }
}
