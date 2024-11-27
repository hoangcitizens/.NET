using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_FileText_VD3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nChuyển nội dung file thành chữ hoa trong C#:");
            Console.WriteLine("--------------------------\n");

            Console.Write("Nhập tên file ban đầu: ");
            string fileName = Console.ReadLine();

            Console.Write("Nhập tên file 2: ");
            string fileName1 = Console.ReadLine();

            try
            {
                if (File.Exists(fileName))
                {
                    // Sử dụng 'using' để đảm bảo đóng file tự động sau khi hoàn thành
                    using (StreamReader fileRw = new StreamReader(fileName))
                    using (StreamWriter fileWr = new StreamWriter(fileName1))
                    {
                        string line;
                        // Đọc từng dòng và chuyển sang chữ hoa
                        while ((line = fileRw.ReadLine()) != null)
                        {
                            fileWr.WriteLine(line.ToUpper());  // Ghi dòng đã chuyển sang chữ hoa vào file 2
                        }
                    }

                    Console.WriteLine("\nNội dung đã được chuyển sang file mới với các chữ cái viết hoa.");
                }
                else
                {
                    Console.WriteLine("File ban đầu không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                // Bắt lỗi nếu có vấn đề xảy ra khi đọc hoặc ghi file
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }

            // Chờ người dùng nhấn phím bất kỳ trước khi thoát chương trình
            Console.WriteLine("\nNhấn phím bất kỳ để thoát chương trình.");
            Console.ReadKey();
        }
    }
}
