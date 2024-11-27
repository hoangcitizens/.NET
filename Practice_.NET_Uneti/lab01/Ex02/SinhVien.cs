using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class SinhVien
    {
        private String fullName; // họ và tên
        private String country; // quê quán
        public int birthYear; // năm sinh
        public double avgGrade; // điểm tổng kết

        public SinhVien() { }

        public SinhVien(string fullName, string country, int birthYear, double avgGrade)
        {
            this.fullName = fullName;
            this.country = country;
            this.birthYear = birthYear;
            this.avgGrade = avgGrade;
        }

        ~SinhVien() { }

        public String FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public String Country
        {
            get { return country; }
            set { country = value; }
        }
        public int BirthYear
        {
            get { return birthYear; }
            set
            {
                birthYear = value;
            }
        }
        public double AvgGrade
        {
            get { return avgGrade; }
            set
            {
                avgGrade = value;
            }
        }

        // Hàm nhập thông tin sinh viên
        public void EnterInfo()
        {
            Console.Write("Nhập tên sinh viên: ");
            FullName = Console.ReadLine();
            Console.Write("Nhập quê quán: ");
            Country = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            BirthYear = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm trung bình: ");
            AvgGrade = double.Parse(Console.ReadLine());
        }

        // Hàm xuất thông tin sinh viên
        public void ShowInfo()
        {
            Console.WriteLine($"Tên: {FullName}, Quê quán: {Country}, Năm sinh: {BirthYear}, Điểm trung bình: {AvgGrade}");
        }
    }
}
