using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            HocSinh a = new HocSinh();
            a.xuat();
            HocSinh b = new HocSinh("Phạm Thị Thùy", 1986, 7, 8);
            b.xuat();
            // hàm tạo sao chép
            HocSinh c = new HocSinh(b);
            c.xuat();
            a.nhap();
            a.xuat();
            Console.ReadLine();
        }
    }
}
