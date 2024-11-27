using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD2
{
    internal class TestProgram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Class trong C#");
            string line = "-----------------------------\n";
            Console.WriteLine(line);
            Box box1 = new Box(5.0,6.0,7.0); // tạo đối tượng box1
            Box box2 = new Box(); // tạo đối tượng box2       
         
            // Tính và in thể tích của box1 là
            Console.WriteLine("Thể tích box1 là: " + box1.volume());

            // Tính và in thể tích của box2 là
            box2.Length = 10.0;
            box2.Width = 11.0;
            box2.Height = 12.0;
            Console.WriteLine($"Thể tích box2 là: {box2.volume()}");
        }
    }
}
