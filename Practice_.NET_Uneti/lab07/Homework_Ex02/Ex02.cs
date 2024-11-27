using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Ex02
{
    internal class Ex02
    {
        static void Main(string[] args)
        {
            try
            {
                // Nhập tên tệp từ bàn phím
                Console.Write("Nhập tên tệp cần đếm số từ: "); // D:\Practice_.NET_Uneti\lab07\Homework_Ex02\bai2_lab7.txt
                string fileName = Console.ReadLine();

                // Kiểm tra xem tệp có tồn tại không
                if (File.Exists(fileName))
                {
                    // Đọc toàn bộ nội dung tệp
                    string fileContent = File.ReadAllText(fileName);

                    // Tách các từ bằng cách sử dụng khoảng trắng và ký tự đặc biệt
                    char[] delimiters = { ' ', '\t', '\n', '\r', ',', '.', ';', ':', '!', '?' };
                    string[] words = fileContent.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                    // Đếm số từ và hiển thị kết quả
                    int wordCount = words.Length;
                    Console.WriteLine($"Số từ trong tệp: {wordCount}");
                }
                else
                {
                    Console.WriteLine("Tệp không tồn tại.");
                }
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                // Xử lý các lỗi nếu có
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
