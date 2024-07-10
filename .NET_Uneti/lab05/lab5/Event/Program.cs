using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Clock c1 = new Clock();
            AnalogClock a1 = new AnalogClock();
            //a1.Subscribe(c1);
            c1.OnSecondChange += a1.show;
            c1.run();
        }
    }
}
