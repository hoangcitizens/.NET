using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_lab02
{
    internal class TestProgram
    {
        static void Main(string[] args)
        {
            // 1. Nhập danh sách sinh viên
            List<Student> students = new List<Student>();
            Console.Write("Nhập số lượng sinh viên: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"\nNhập thông tin sinh viên thứ {i + 1}:");
                Student student = new Student();
                student.Input();
                students.Add(student);
            }

            // 2. Hiển thị danh sách sinh viên vừa nhập
            Console.WriteLine("\nDanh sách sinh viên:");
            foreach (var student in students)
            {
                student.Display();
            }

            // 3. Tìm kiếm và đưa ra thông tin của sinh viên có tên là "Nam"
            Console.WriteLine("\nTìm kiếm sinh viên có tên là 'Nam':");
            bool found = false;
            foreach (var student in students)
            {
                if (student.Name.Equals("Nam", StringComparison.OrdinalIgnoreCase))
                {
                    student.Display();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Không tìm thấy sinh viên nào có tên là 'Nam'.");
            }
            Console.ReadLine();
        }
    }
}
