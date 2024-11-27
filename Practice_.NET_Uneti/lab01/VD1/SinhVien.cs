using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD1
{
    internal class SinhVien
    {
        private string id; // mã sinh viên
        private string fullName; // họ và tên
        private string country; // quê quán
        private int course; // khóa

        public SinhVien() { }
        public SinhVien(string id, string fullName, string country, int course)
        {
            this.id = id;
            this.fullName = fullName;
            this.country = country;
            this.course = course;
        }
        public string Id
        {
            get { return this.id; }
            set { this.id = value;  }
        }
        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public int Course
        {
            get { return this.course; }
            set
            {
                this.course = value;
            }
        }
        public void status()
        {
            Console.Write("Trạng thái: ");
            if (this.course < 14)
            {
                Console.WriteLine("Đã tốt nghiệp");
            } else
            {
                Console.WriteLine("Đang theo học");
            }
                
        }
        public void enterInfo()
        {
            Console.Write("Nhập mã sinh viên: ");
            this.id = Console.ReadLine();
            Console.Write("Nhập họ tên sinh viên: ");
            this.fullName = Console.ReadLine();
            Console.Write("Nhập quê quán: ");
            this.country = Console.ReadLine();
            Console.Write("Nhập khóa: ");
            this.course = Convert.ToInt32(Console.ReadLine());
        }
        public void showInfo()
        {
            Console.WriteLine("Mã sinh viên là: " + id);
            Console.WriteLine("Họ và tên là: " + fullName);
            Console.WriteLine("Quê quán: " + country);
            Console.WriteLine("Khóa: " + Convert.ToString(this.course));
            status();
        }
    }
}
