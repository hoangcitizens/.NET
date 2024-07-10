using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_week4
{
    public class Person
    {
        protected string fullName; // Họ và tên
        protected int birthYear; // Năm sinh
        public Person()
        {
            fullName = "Unknown";
            birthYear = 0;
        }
        public Person(string fullName, int birthYear)
        {
            this.fullName = fullName;
            this.birthYear = birthYear;
        }
        public void input()
        {
            Console.Write("Mời nhập họ và tên: ");
            fullName = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            birthYear = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("{0,-25} {1,-10}",fullName,birthYear);
        }
    }
}
