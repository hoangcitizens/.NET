using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class TestProgram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SinhVien sv3 = new SinhVien();
            sv3.Ma = "113";
            sv3.HoTen = "Nguyễn Hữu Hoàng";
            sv3.QueQuan = "Thái Bình";
            sv3.Khoa = 8;
            sv3.HienThi();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Sử dụng phương thức của interface cho ra kết quả");
            Nguoi ng = sv3;
            ng.HienThi();
            Console.ReadKey();
        }
    }
}
