using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3._3_Threading_VD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Da luong trong C#");
            Console.WriteLine("Vi du minh hoa Main Thread");
            Console.WriteLine("--------------------------");
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
            Console.WriteLine("Day la {0}", th.Name); Console.ReadKey();
        }
    }
}
