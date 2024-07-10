/*
    Viết một chương trình đơn giản minh họa quản lý tài khoản ATM: 
    - Class Tài Khoản ATM có các thuộc tính private Số tài khoản, Họ tên chủ thẻ, số dư
    - Xây dựng hàm thành viên rút tiền void ruttien (số tiền cần rút)
    - Và thành viên chuyển khoản void chuyenkhoan(số tiền cần chuyển,Tài khoản ATM thụ hưởng)
    - Khi rút tiền hoặc chuyển tiền xong: phát sinh sự kiện “đã rút tiền” hoặc “đã chuyển tiền”, 
        + sự kiện rút tiền thì sẽ thực thi hàm thông báo in ra màn hình thông báo số tiền của tài khoản nào đã rút 
          bao nhiêu vào thời gian nào, số dư hiện tại là bao nhiêu
        + sự kiện chuyển tiền sẽ thực thi hàm thông báo in ra màn hình thông báo số tiền của tài khoản đã chuyển 
          bao nhiêu vào thời gian nào và số dư hiện tại là bao nhiêu
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_week5
{
    internal class Program
    {
        static void input(TaiKhoan a)
        {
            Console.Write("Nhập họ tên chủ tài khoản: ");
            a.FullName = Console.ReadLine();
            Console.Write("Nhập số tài khoản: ");
            a.SoTaiKhoan = int.Parse(Console.ReadLine());
            Console.Write("Nhập số dư: ");
            a.SoDu = int.Parse(Console.ReadLine());
        }
        static void ThongBaoDaRutTien(string s)
        {
            Console.WriteLine("____________________________ĐÃ RÚT TIỀN______________________________");
            Console.WriteLine("{0,-18} {1,-25} {2,-18} {3}","Số tiền đã rút",
                "Thời gian giao dịch","Số dư hiện tại","Đơn vị");
            Console.WriteLine(s);
        }
        static void ThongBaoDaChuyenTien(string s)
        {
            Console.WriteLine("________________________ĐÃ CHUYỂN TIỀN___________________________");
            Console.WriteLine("{0,-18} {1,-25} {2,-18} {3,-18} {4}", "Số tiền đã chuyển", "Thời gian giao dịch", 
                "Số dư hiện tại", "Số dư tk thụ hưởng", "Đơn vị");
            Console.WriteLine(s);          
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            TaiKhoan taiKhoan1 = new TaiKhoan();

            input(taiKhoan1);
            Console.Write("Nhập số tiền rút: ");
            int n = int.Parse(Console.ReadLine());
            taiKhoan1.WithdrewMoney += ThongBaoDaRutTien; // Đăng ký sự kiện rút tiền
            taiKhoan1.rutTien(n); // Phát sinh sự kiện rút tiền
            Console.WriteLine();

            TaiKhoan taiKhoan2 = new TaiKhoan();
            input(taiKhoan2);
            Console.Write("Nhập số tiền chuyển: ");
            int m = int.Parse(Console.ReadLine());
            taiKhoan2.TransferredMoney += ThongBaoDaChuyenTien; // Đăng ký sự kiện chuyển tiền
            taiKhoan2.chuyenKhoan(m, taiKhoan1); // Phát sinh sự kiện chuyển tiền
            Console.ReadLine();
        }
    }
}
