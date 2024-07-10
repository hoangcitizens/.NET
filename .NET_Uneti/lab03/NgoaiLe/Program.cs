using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace NgoaiLe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            int[] b = new int[3];
            lap:
            try
            {
                Console.Write("Mời nhập 1 số nguyên: ");
                a = int.Parse(Console.ReadLine());
                b[a] = 10;
                Console.WriteLine(a);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Số nhập vào không hợp lệ. Mời nhập số nguyên !!!");          
                Console.WriteLine("Mời nhập lại !");
                goto lap;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Mời nhập số nguyên nhỏ hơn 3");
                goto lap;
            }
            finally
            {
                Console.WriteLine("Lệnh trong khối finally luôn được chạy");
            }
            Console.ReadLine();
        }
    }
}
