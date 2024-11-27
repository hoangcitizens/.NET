using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Ex03
{
    internal class Ex03
    {
        static void Main(string[] args)
        {
            try
            {
                // Nhập tên tệp nguồn
                Console.Write("Nhập tên tệp nguồn: "); // D:\Practice_.NET_Uneti\lab07\Homework_Ex03\bai3.1_lab7.txt
                string sourceFile = Console.ReadLine();

                // Nhập tên tệp đích
                Console.Write("Nhập tên tệp đích: "); 
                string destinationFile = Console.ReadLine();

                // Kiểm tra xem tệp nguồn có tồn tại không
                if (File.Exists(sourceFile))
                {
                    // Sao chép nội dung từ tệp nguồn sang tệp đích
                    File.Copy(sourceFile, destinationFile, true);
                    Console.WriteLine($"Đã sao chép thành công từ tệp '{sourceFile}' sang tệp '{destinationFile}'.");
                }
                else
                {
                    Console.WriteLine("Tệp nguồn không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi nếu có
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
