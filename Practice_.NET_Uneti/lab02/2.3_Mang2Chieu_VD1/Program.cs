using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Mang2Chieu_VD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] arr1 = new int[3, 3];
            Console.Write("\nĐọc và in mảng 2 chiều trong C#:\n");
            Console.Write("--------------------------------\n");
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhập các phần tử vào mảng 2 chiều:\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Phan tu - [{0},{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nIn mảng hai chiều: \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++) Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");
            Console.ReadKey();
        }   
    }
}
