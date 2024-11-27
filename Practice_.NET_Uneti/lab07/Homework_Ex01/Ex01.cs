using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Ex01
{
    internal class Ex01
    {
        static void Main(string[] args)
        {
            try
            {
                // Nhập tên tệp từ bàn phím
                Console.Write("Nhập tên tệp cần mở: ");
                string fileName = Console.ReadLine();

                // Kiểm tra xem tệp có tồn tại không
                if (File.Exists(fileName))
                {
                    // Đọc toàn bộ nội dung tệp và hiển thị lên màn hình
                    string fileContent = File.ReadAllText(fileName);
                    Console.WriteLine("Nội dung của tệp:");
                    Console.WriteLine(fileContent);
                }
                else
                {
                    Console.WriteLine("Tệp không tồn tại.");
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
