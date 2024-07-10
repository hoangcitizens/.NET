using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_tuan5_22_3
{
    // Định nghĩa 1 kiểu delegate đại diện cho các hàm có kiểu (int, int) -> (int)
    delegate int IntIntToInt(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            // Tạo đối tượng delegate
            IntIntToInt iiToInt = new IntIntToInt(TinhToan.sum); // Truyền vào tham số là một hàm số có cùng kiểu với hàm delegate
            // Thực thi một delegate nó sẽ gọi phương thức nó đại diện
            int value = iiToInt(10, 20);
            Console.WriteLine("Value = {0}\n", value);
            
            iiToInt = TinhToan.minus;
            value = iiToInt(10, 20);
            Console.WriteLine("Value = {0}", value);
            
            // Biến delegate đại diện cho nhiều phương thức
            Console.WriteLine("\n***Đại diện cho 2 phương thức***");
            iiToInt += TinhToan.multiple;
            int value1 = iiToInt(10, 20);
            Console.WriteLine("Value = {0}", value1);
            
            Console.WriteLine("\n***Sau khi trừ phương thức multiple***");
            iiToInt -= TinhToan.minus;
            int value2 = iiToInt(10, 20);
            Console.WriteLine("Value = {0}", value2);
            
            Console.ReadLine();
        }
    }
}
