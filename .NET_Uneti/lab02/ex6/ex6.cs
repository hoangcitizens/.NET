/*
    Bài 6. Sử dụng kiểu cấu trúc khai báo điểm A(xa, ya); B(xb, yb). Nhập và tính độ dài đoạn thẳng AB.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    struct Point
    { 
        public double x;
        public double y;
    };
    internal class ex6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Point A;
            Console.WriteLine("(*) Nhập tọa độ điểm A");
            Console.Write("\tNhập xA = ");
            A.x = double.Parse(Console.ReadLine());
            Console.Write("\tNhập yA = ");
            A.y = double.Parse(Console.ReadLine());
            Point B;
            Console.WriteLine("(*) Nhập tọa độ điểm B");
            Console.Write("\tNhập xB = ");
            B.x = double.Parse(Console.ReadLine());
            Console.Write("\tNhập yA = ");
            B.y = double.Parse(Console.ReadLine());
            double d = (double)Math.Sqrt(Math.Pow((B.x - A.x), 2) + Math.Pow((B.y - A.y), 2));
            Console.WriteLine($"Độ dài đoạn thẳng AB = {d}");
            Console.ReadLine();
        }
    }
}
