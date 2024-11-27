using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Mang2chieu_VD3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum = 0, n;
            int[,] arr1 = new int[50, 50];
            Console.Write("\nTinh tong cac phan tu tren duong cheo chinh cua ma tran trong C#:\n");
            Console.Write("-----------------------\n");
            Console.Write("Nhập kích cỡ ma trận vuông: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập các phần tử của ma trận:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phần tử - [{0}],[{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    //tinh tong cac phan tu tren duong cheo chinh
                    if (i == j) sum = sum + arr1[i, j];
                }
            }
            Console.Write("In ma trận:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}   ", arr1[i, j]);
                Console.Write("\n");
            }
            Console.Write("Tổng các phần tử trên đường chéo chính là: {0}\n", sum);
            Console.ReadKey();
        }
    
    }
}
