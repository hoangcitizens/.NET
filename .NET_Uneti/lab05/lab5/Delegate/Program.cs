using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate int IntIntToInt(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            IntIntToInt iiToInt = new IntIntToInt(TinhToan.sum);
            int value = iiToInt(10, 20); // 30 goi TinhToan.sum
            Console.WriteLine("Value = {0}", value);

            // Gán delegate đại diện cho phương thức khác
            iiToInt = TinhToan.minus;
            value = iiToInt(10, 20);
            Console.WriteLine("\nValue = {0}", value);

            // Biến delegate đại diện cho nhiều phương thức
            Console.WriteLine("\nĐại diện cho cả 2 phương thức");
            iiToInt += TinhToan.multiple;
            int value1 = iiToInt(10, 20); // 200 gọi TinhToan.multiple
            Console.WriteLine("Value = {0}", value1);

            Console.WriteLine("\nSau khi trừ phương thức multiple");
            iiToInt -= TinhToan.multiple;
            int value2 = iiToInt(10, 20);
            Console.WriteLine("Value = {0}", value2);
            Console.ReadLine();
        }
    }
}
