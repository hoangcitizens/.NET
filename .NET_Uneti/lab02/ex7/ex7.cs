/*
     Bài 7: Viết chương trình tạo một struct sinh viên bao gồm : mã sinh viên, họ tên, năm sinh, điểm trung bình tích lũy
            Nhập vào n sinh viên từ bàn phím, sau đó in ra danh sách sinh viên đã nhập, hiển thị thông tin của 
            sinh viên có điểm trung bình tích lũy lớn nhất
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    struct Student
    {
        public string ID;
        public string fullName;
        public int birthYear;
        public float GPA;
        public void import()
        {
            Console.Write("Nhập mã sinh viên: ");
            ID = Console.ReadLine();
            Console.Write("Nhập họ và tên sinh viên: ");
            fullName = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            birthYear = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm trung bình tích lũy: ");
            GPA = float.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-10} {3}", ID, fullName, birthYear, GPA);
        }
    };
    internal class ex7
    {
        static void title()
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-10} {3}", "Mã SV", "Họ tên", "Năm sinh", "Điểm TB");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());
            Student []student = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"(*) Nhập vào thông tin sinh viên thứ {i + 1}");
                student[i].import();
                Console.WriteLine();
            }
            title();  
            for (int i = 0; i < n; i++)
            {
                student[i].display();
            }

            // Tìm sinh viên có điểm trung bình tích lũy cao nhất
            double maxGPA = student[0].GPA;
            Student s = student[0];
            for (int i = 1; i < n; i++)
            {
                if (student[i].GPA > maxGPA)
                {
                    maxGPA = student[i].GPA;
                    s = student[i];
                }
            }
            Console.WriteLine("\nThông tin sinh viên có điểm trung bình cao nhất:");
            title();
            Console.WriteLine("{0,-10} {1,-20} {2,-10} {3}", s.ID, s.fullName, s.birthYear, s.GPA);
            Console.ReadLine();
        }
    }
}
