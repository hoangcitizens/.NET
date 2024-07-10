using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_tuan4
{
    public class Student
    {
        // khai báo biến thành viên
        protected string fullname; 
        protected int birthYear;
        protected double literatureScore;
        protected double mathScore;
        // khai báo hàm thành viên
        public double LiteratureScore
        {
            get { return literatureScore; }
            set
            {
                if (value >= 0 && value <= 10)
                    literatureScore = value;
            }
        }
        public Student()
        {
            fullname = "Unknown";
            birthYear = 0;
            literatureScore = 0;
            mathScore = 0;
        }
        public Student(string fullname, int birthYear, double literatureScore, double mathScore)
        {
            this.fullname = fullname; // this phân biệt giữa tên biến và tham số
            this.birthYear = birthYear;
            this.literatureScore = literatureScore;
            this.mathScore = mathScore;
        }
        public Student(Student s)
        {
            this.fullname = s.fullname;
            this.birthYear = s.birthYear;
            this.literatureScore = s.literatureScore;
            this.mathScore = s.mathScore;
        }
        public void input()
        {
            Console.Write("Mời nhập họ và tên: ");
            fullname = Console.ReadLine();
            Console.Write("Mời nhập năm sinh: ");
            birthYear = int.Parse(Console.ReadLine());
            Console.Write("Mời nhập điểm văn: ");
            literatureScore = double.Parse(Console.ReadLine());
            Console.Write("Mời nhập điểm toán: ");
            mathScore = double.Parse(Console.ReadLine());
        }
        public double mediumScoreStudent()
        {
            return (literatureScore + mathScore) / 2;
        }
        public void output()
        {
            Console.WriteLine("{0,-25} {1,-10} {2,-10} {3,-10} {4}"
                                , fullname, birthYear, literatureScore, mathScore, mediumScoreStudent());
        }
        static public void title()
        {
            Console.WriteLine("{0,-25} {1,-10} {2,-10} {3,-10} {4}"
                            , "Họ và tên", "Năm sinh", "Điểm văn", "Điểm toán", "Điểm trung bình");
        }
        static public void importListStudent(Student[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\t(*) Mời nhập học sinh thứ {i + 1}");
                a[i] = new Student();
                a[i].input();
                Console.WriteLine();
            }
        }
        static public void displayListStudent(Student[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {           
                a[i].output();
            }
        }
        static public void maxMediumScore(Student[] a, int n)
        {
            Student maxStudent = a[0];
            double maxMedium = a[0].mediumScoreStudent();
            for (int i = 0; i < n; i++)
            {
                if (maxMedium < a[i].mediumScoreStudent())
                {
                    maxStudent = a[i];
                }    
            }
            Console.WriteLine("________________THÔNG TIN HỌC SINH ĐIỂM TRUNG BÌNH CAO NHẤT_______________");
            title();
            maxStudent.output();
        }


    }
}
