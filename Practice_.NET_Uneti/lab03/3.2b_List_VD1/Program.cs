using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2b_List_VD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("a");
            list1.Add("dammio");
            list1.Add("b"); foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
