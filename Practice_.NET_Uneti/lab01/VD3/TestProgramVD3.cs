using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD3
{
    class TestProgramVD3
    {
        static void Main(string[] args)
        {           
            Console.InputEncoding = Encoding.Unicode;           
            Console.OutputEncoding = Encoding.Unicode;         

            SinhVien sv1 = new SinhVien("21103100320", "Nguyễn Văn An", "Hải Phòng", 13);
            sv1.showInfo();
            string line = "----------------------------------";
            Console.WriteLine(line);

            //SinhVien sv2 = new SinhVien();
            //sv2.enterInfo();
            //Console.WriteLine(line);
            //sv2.showInfo();
            //Console.WriteLine(line);

            SinhVienIT sv3 = new SinhVienIT();
            sv3.Id = "21303100333";
            sv3.FullName = "Nguyễn Hữu Hoàng";
            sv3.Country = "Thái Bình";
            sv3.Course = 15;
            sv3.showInfoIT();
            Console.ReadLine();
        }
    }
}
