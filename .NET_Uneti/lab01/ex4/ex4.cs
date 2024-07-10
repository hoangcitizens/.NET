/* Bài 4: Nhập vào 1 số từ 2 đến 8 sau đó in ra thứ 2 đến chủ nhật
          tương ứng với số người dùng nhập (dùng câu lệnh switch case) */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class ex4
    {
        static void Main(string[] args)
        {
            int options;
            do
            {
                Console.Write("Nhap mot so tu (2->8): ");
                options = int.Parse(Console.ReadLine());
                switch (options)
                {
                    case 2:
                        {
                            Console.WriteLine("\tThu Hai");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\tThu Ba");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\tThu Tu");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("\tThu Nam");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("\tThu Sau");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("\tThu Bay");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("\tChu Nhat");
                            break;
                        }
                    default:
                        Console.WriteLine("(!) Khong co lua chon nay vui long nhap lai lua chon cua ban !!!");
                        break;
                }
            } while (options < 2 || options > 8);
            Console.ReadLine();
        }
    }
}
