/*
    Bài 2: Đa hình
    Xây dựng class Sách gồm Mã sách, đơn giá, số lượng, nhà xuất bản; Các hàm tạo, hàm nhập, hàm xuất
        - Sách giáo khoa kế thừa lớp Sách bổ sung thuộc tính  tình trạng (mới, cũ). Nếu tình trạng sách là mới 
          thì hàm thành tiền = số lượng * đơn giá. Nếu tình trạng sách là cũ thì thành tiền = số lượng * đơn giá * 50%.
        - Sách tham khảo  kế thừa lớp Sách bổ sung thuộc tính: thuế, hàm thành thành tiền = số lượng * đơn giá + thuế.
    Viết chương trình thực hiện các yêu cầu sau:
        - Nhập vào 1 sanh sách lẫn lộn 2 loại sách, tại mỗi vòng lặp cho người dùng lựa chọn nhập loại nào
        - Sau đó xuất danh sách đã nhập
        - Tính tổng thành tiền cho từng loại sách
        - Tính trung bình cộng đơn giá của các sách tham khảo.
        - Xuất ra các sách giáo khoa của nhà xuất bản với tên nhà xuất bản nhập từ bàn phím
    (Chú ý bài này dùng hàm ảo: nhập, xuất, hàm tính thành tiền)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_ex2_week4
{
    internal class Program
    {
        static void importList(Sach[] a, int n)
        {
            int option;
            for (int i = 0; i < n; i++)
            {               
                do
                {
                    Console.Write($"\t1. Sách giáo khoa\n\t2. Sách tham khảo\n\tLựa chọn sách thứ {i + 1}: ");
                    option = int.Parse(Console.ReadLine());
                    if (option != 1 && option != 2)
                    {
                        Console.WriteLine("(!) Không có lựa chọn này! Chọn lại: ");
                        option = int.Parse(Console.ReadLine());
                    }                         
                } while (option != 1 && option != 2);
                if (option == 1)
                   a[i] = new SachGiaoKhoa();            
                else
                   a[i] = new SachThamKhao();
                a[i].import();
                Console.WriteLine();
            }    
        }
        static void displayList(Sach[] a, int n)
        {
            Console.WriteLine("________________________________THÔNG TIN SÁCH_________________________________");
            Sach.title();
            for (int i = 0; i < n; i++)
            {
                a[i].display();
            }    
        }
        static void sumMoney(Sach[] a, int n)
        {
            double sgk = 0, stk = 0; // Tổng tiền sách giáo khoa và sách tham khảo
            for (int i = 0; i < n; i++)
            {
                if (a[i].option() == 1)
                    sgk += a[i].thanhTien();
                else if (a[i].option() == 2)
                    stk += a[i].thanhTien();
                else
                    Console.Write("0");
            }
            Console.WriteLine($"Tổng tiền của sách giáo khoa là: {sgk}" +
                              $"\nTổng tiền của sách tham khảo là: {stk}");
        }
        static void averageSumMoney(Sach[] a, int n)
        {
            double S = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i].option() == 2)
                    S = (double)(a[i].DonGia)/a[i].Sl;
            }    
            Console.WriteLine($"Trung bình cộng đơn giá sách tham khảo là: {S}");

        }
        static void findnxb(Sach[] a, int n)
        {
            Console.Write("Nhập nhà xuất bản muốn tìm: ");
            string x = Console.ReadLine();
            int count = 0;
            Console.WriteLine($"__________________________THÔNG TIN SÁCH NXB {x}_________________________");
            Sach.title();
            for (int i = 0; i < n; i++)
            {
                if (x.Equals(a[i].NXB))
                {
                    count++;
                    a[i].display();
                }    
            }
            if (count == 0)
                Console.WriteLine($"Không tìm thấy nhà xuất bản {x} trong danh sách !!!");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Mời nhập số lượng sách: ");
            int n = int.Parse(Console.ReadLine());
            Sach[] s = new Sach[n]; 
            importList(s, n);
            displayList(s, n);
            sumMoney(s, n);
            averageSumMoney(s, n);
            findnxb(s, n);
            Console.ReadLine();
        }
    }
}
