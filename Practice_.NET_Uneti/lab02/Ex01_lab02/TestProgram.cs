using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_lab02
{
    internal class TestProgram
    {
        static void Main(string[] args)
        {
            SinhVienIT svIT = new SinhVienIT("Nguyen Van A", "Công nghệ thông tin", 8, 7.5, 9);
            SinhVienKinhTe svKinhTe = new SinhVienKinhTe("Tran Thi B", "Kinh tế", 7, 6.5);

            Console.WriteLine("Thông tin sinh viên IT:");
            svIT.Xuat();

            Console.WriteLine("\nThông tin sinh viên Kinh Tế:");
            svKinhTe.Xuat();
            Console.ReadLine();
        }
    }
}
