using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3._3_Threading_VD4
{
    internal class Program
    {
        private static void A()
        {
            for (int i = 0; i < 200; i++)
                Console.Write(" A ");
        }
        private static void B()
        {
            for (int i = 0; i < 200; i++)
                Console.Write(" B ");
        }
        private static void D()
        {
            for (int i = 0; i < 200; i++)
                Console.Write(" D ");
        }
        private static void C(object n)
        {
            int t = (int)n;
            for (int i = 0; i < t; i++)
                Console.Write(" C ");
        }
        public static void Main(string[] args)
        {
            Thread Luong1 = new Thread(A);
            Thread Luong2 = new Thread(B);
            Thread Luong3 = new Thread(C);
            Thread Luong4 = new Thread(D);
            Luong1.Start();
            Luong2.Start();
            Luong3.Start(200);
            Luong4.Start();
            Console.ReadLine();
        }
    }
}
