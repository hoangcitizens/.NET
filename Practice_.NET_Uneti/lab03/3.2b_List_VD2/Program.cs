using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2b_List_VD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo 1 List các kiểu string và thêm 2 phần tử vào List.
            List<string> MyList4 = new List<string>();
            MyList4.Add("Free");
            MyList4.Add("Education");
            // In giá trị các phần tử trong List
            Console.WriteLine(" List ban dau: ");
            Console.WriteLine(" So luong phan tu trong List la: {0}",
            MyList4.Count); foreach (string item in MyList4)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            // Chèn 1 phần tử vào đầu List.
            MyList4.Insert(0, "HowKteam");
            // In lại giá trị các phần tử trong List để xem đã chèn được hay chưa
            Console.WriteLine(" List sau khi insert: ");
            Console.WriteLine(" So luong phan tu trong List la: {0}",
            MyList4.Count);
            foreach (string item in MyList4)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            // Kiểm tra 1 phần tử có tồn tại trong List hay không.
            bool isExists = MyList4.Contains("Kteam");
            if (isExists == false)
            {
                Console.WriteLine("Khong tim thay chuoi Kteam trong List");
            }
        }
    }
}
