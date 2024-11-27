using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Mang2chieu_Vd2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];
            int[,] ma_tran_tong = new int[50, 50];
            Console.Write("\nCộng 2 ma trận trong C#:\n");
            Console.Write("----------------------------\n");
            Console.Write("Nhập kích cỡ của 2 ma trận vuông (<5): ");
            n = Convert.ToInt32(Console.ReadLine());
            /* Nhap cac phan tu vao trong mang da chieu*/
            Console.Write("Nhập các phần tử ma trận thứ 1:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phần tử - [{0},{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Nhập các phần tử ma trận thứ 2:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phần tử - [{0},{1}]: ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nIn ma trận thứ nhất:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\nIn ma trận thứ hai:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++) Console.Write("{0}\t", arr2[i, j]);
            }
            /* cong hai ma tran */
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    ma_tran_tong[i, j] = arr1[i, j] + arr2[i, j];
            Console.Write("\nMa trận tổng của 2 ma trận trên là: \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", ma_tran_tong[i, j]);
            }
            Console.Write("\n\n");
            Console.ReadKey();
        }
   
    }
}
