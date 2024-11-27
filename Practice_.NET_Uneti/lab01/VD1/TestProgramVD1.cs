using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD1
{
    internal class TestProgramVD1
    {
        static void Main(string[] args)
        {   
            // Nhập chữ Unicode
            Console.InputEncoding = Encoding.Unicode;

            // In ra màn hình chữ Unicode
            Console.OutputEncoding = Encoding.Unicode;
            
            //// Đổi màu nền
            //Console.BackgroundColor = ConsoleColor.Green;
            
            //// Xóa màu nền cũ
            //Console.Clear();
            
            //// Chuyển màu chữ
            //Console.ForegroundColor = ConsoleColor.Red;
            
            SinhVien sv1 = new SinhVien("21103100320", "Nguyễn Văn An", "Thái Bình", 15);
            sv1.showInfo();
            string line = "----------------------------------";
            Console.WriteLine(line);

            SinhVien sv2 = new SinhVien();
            sv2.enterInfo();
            Console.WriteLine(line);
            sv2.showInfo();
            Console.WriteLine(line);

            SinhVien sv3 = new SinhVien();
            sv3.Id = "21303100333";
            sv3.FullName = "Nguyễn Hữu Hoàng";
            sv3.Country = "Thái Bình";
            sv3.Course = 15;
            sv3.showInfo();
        }
    }
}
