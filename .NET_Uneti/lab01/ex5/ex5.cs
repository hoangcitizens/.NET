/* Bài 5. Mời người dùng nhập vào 1 số khác 0, nếu người dùng nhập vào ko đúng thì mời nhập lại 
          đến khi nào nhập đúng số khác 0 thì in ra số đã nhập (dùng vòng lặp do while) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class ex5
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao mot so != 0: ");
                n = int.Parse(Console.ReadLine());
            } while (n == 0);
            Console.WriteLine("So vua nhap: {0}",n);
            Console.Read();
        }
    }
}
