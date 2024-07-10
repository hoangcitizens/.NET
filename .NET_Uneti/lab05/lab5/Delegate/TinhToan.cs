using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class TinhToan
    {
        public static int sum(int a, int b)
        {
            Console.WriteLine("Chạy sum");
            return a + b;
        }
        public static int minus(int a, int b)
        {
            Console.WriteLine("Chạy minus");
            return a - b;
        }
        public static int multiple(int a, int b)
        {
            Console.WriteLine("Chạy multiple");
            return a * b;
        }
    }
}
