using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_lab02
{
    // Lớp Student thực thi giao diện Person
    public class Student : Person
    {
        private string name;
        private int age;
        private string nativePlace;
        private string id;

        // Thuộc tính của Student
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string NativePlace
        {
            get { return nativePlace; }
            set { nativePlace = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        // Phương thức tạo không tham số
        public Student() { }

        // Phương thức khởi tạo có tham số
        public Student(string name, int age, string nativePlace, string id)
        {
            Name = name;
            Age = age;
            NativePlace = nativePlace;
            Id = id;
        }

        // Phương thức Input để nhập thông tin sinh viên
        public void Input()
        {
            Console.Write("Nhập tên: ");
            Name = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Nhập quê quán: ");
            NativePlace = Console.ReadLine();
            Console.Write("Nhập mã sinh viên: ");
            Id = Console.ReadLine();
        }

        // Phương thức Display để hiển thị thông tin sinh viên
        public void Display()
        {
            Console.WriteLine($"Tên: {Name}, Tuổi: {Age}, Quê quán: {NativePlace}, Mã sinh viên: {Id}");
        }
    }
}
