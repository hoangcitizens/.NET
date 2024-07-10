using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bài 1: Giải phương trình bậc nhất
namespace ex1
{
    internal class ex1
    {
        static void Main(string[] args)
        {
            // ax + b = 0
            float a, b;
            Console.Write("Nhap vao he so a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao he so b: ");
            b = Convert.ToSingle(Console.ReadLine());
            /*  
            - Nếu a == 0 thì pt <=> b = 0
                + Nếu b == 0 thì pt có vô số nghiệm
                + Nếu b != 0 thì pt vô nghiệm
            - Nếu a != 0
                + Phương trình có nghiệm x = -b/a
             */
            if (a == 0)
            {
                if (b == 0) Console.WriteLine("Phuong trinh vo so nghiem");
                else Console.WriteLine("Phuong trinh vo nghiem");
            }
            else 
            {
                Console.WriteLine("Phuong trinh co 1 nghiem là x = {0}", -b / a);
            } 
                
        }
    }
}
