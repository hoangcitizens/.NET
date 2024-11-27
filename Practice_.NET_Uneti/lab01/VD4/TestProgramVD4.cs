using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD4
{
    class TestProgramVD4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            bool debug = false;
            Console.WriteLine("\nLập trình hướng đối tượng trong C#");
            string line = "------------------------\n";
            Console.WriteLine(line);
            // Tạo đối tượng Person và gọi phương thức Greet()
            Person person = new Person();
            person.sayHello();

            Student student = new Student();
            student.SetAge(21);
            student.sayHello();
            student.ShowInfoAge();

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.sayHello();
            teacher.Teach();
            if (debug)
            {
                Console.ReadLine();
                Console.ReadKey();
            }
            Console.ReadLine();
        }
    }
}
