using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3._3_Threading_VD2
{
    internal class Program
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Thread con bat dau!!!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Da luong trong C#");
            Console.WriteLine("Vi du minh hoa cach tao Thread");
            Console.WriteLine("---------------------------");
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("Trong Main Thread: tao thread con.");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }
    }
}
