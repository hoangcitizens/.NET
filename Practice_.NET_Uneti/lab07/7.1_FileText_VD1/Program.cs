using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_FileText_VD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nChương trình ghi file trong C#");
            Console.WriteLine("----------------------------\n");

            // Sử dụng try-catch để bắt lỗi nếu có
            try
            {
                // Mở file để ghi thêm (append)
                StreamWriter myFile = File.AppendText("D:\\Practice_.NET_Uneti\\lab07\\7.1_FileText_VD1\\test.txt");

                string line;
                do
                {
                    Console.Write("Nhập một câu Text (nhấn Enter để kết thúc): ");
                    line = Console.ReadLine();

                    if (!string.IsNullOrEmpty(line))
                    {
                        myFile.WriteLine(line);  // Ghi dòng vào file
                    }
                }
                while (!string.IsNullOrEmpty(line));  // Dừng nếu người dùng nhấn Enter mà không nhập gì

                // Đóng file sau khi hoàn thành
                myFile.Close();

                Console.WriteLine("\nNội dung đã được lưu vào file test.txt.");
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có ngoại lệ
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }

            // Chờ người dùng nhấn phím bất kỳ để thoát chương trình
            Console.WriteLine("\nNhấn phím bất kỳ để thoát chương trình.");
            Console.ReadKey();  // Chỉ cần dùng Console.ReadKey() để tạm dừng chương trình
        }
    }
}
