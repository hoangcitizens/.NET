using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_tuan4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            /* Nhập vào 1 mảng học sinh sau đó in ra học sinh có điểm trung bình cao nhất
               trong đó có sử dụng hàm tính điểm trung bình */
            Console.Write("Nhập vào số lượng học sinh: ");
            int n = int.Parse(Console.ReadLine());
            Student []student = new Student[n];
            Student.importListStudent(student, n);
            Console.WriteLine("_________________________THÔNG TIN HỌC SINH________________________");
            Student.title();
            Student.displayListStudent(student, n);
            Student.maxMediumScore(student, n);
            Console.WriteLine();

            // Nhập vào 1 mảng học sinh chuyên văn 
            Console.Write("Nhập vào số lượng học sinh chuyên văn: ");
            int m = int.Parse(Console.ReadLine());
            StudentLiterature[] studentLiterature = new StudentLiterature[m];
            StudentLiterature.importListStudentLiterature(studentLiterature, m);
            Console.WriteLine("_________________________THÔNG TIN HỌC SINH CHUYÊN VĂN________________________");
            StudentLiterature.title2();
            StudentLiterature.displayListStudentLiterature(studentLiterature, m);

            // Sau đó in ra học sinh có điểm văn chuyên thấp nhất
            Console.WriteLine();
            StudentLiterature.minMediumScoreSpecial(studentLiterature, m);
            Console.WriteLine();

            // Sắp xếp theo chiều tăng dần của điểm văn chuyên, tạo Property DiemVanChuyen
            StudentLiterature.arrange(studentLiterature, m);
            Console.ReadLine();
        }
    }
}
