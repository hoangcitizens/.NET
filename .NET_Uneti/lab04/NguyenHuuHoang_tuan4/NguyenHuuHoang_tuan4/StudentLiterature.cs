using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_tuan4
{
    public class StudentLiterature : Student
    {
        private double literatureScoreSpecial; // điểm chuyên văn
        public StudentLiterature() : base()
        {
            literatureScoreSpecial = 0;
        }
        public StudentLiterature(double literatureScoreSpecial, string fullname, int birthYear, double literatureScore, double mathScore)
            : base(fullname, birthYear, literatureScore, mathScore)
        {
            this.literatureScoreSpecial = literatureScoreSpecial;
        }   
        public void import()
        {
            input();
            Console.Write("Mời nhập điểm văn chuyên: ");
            literatureScoreSpecial = double.Parse(Console.ReadLine());  
        }
        public void display()
        {
            Console.WriteLine("{0,-25} {1,-10} {2,-10} {3,-10} {4}"
                               , fullname, birthYear, literatureScore, mathScore, literatureScoreSpecial);
        }
        public double LiteratureScoreSpecial
        {
            get { return literatureScoreSpecial; }
            set
            {
                if (value >= 0 && value <= 10)
                    literatureScoreSpecial = value;
            }
        }
        static public void title2()
        {
            Console.WriteLine("{0,-25} {1,-10} {2,-10} {3,-10} {4}"
                            , "Họ và tên", "Năm sinh", "Điểm văn", "Điểm toán", "Điểm chuyên văn");
        }
        static public void importListStudentLiterature(StudentLiterature[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\t(*) Mời nhập học sinh chuyên văn thứ {i + 1}");
                a[i] = new StudentLiterature();
                a[i].import();
                Console.WriteLine();
            }
        }
        static public void displayListStudentLiterature(StudentLiterature[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                a[i].display();
            }
        }
        static public void minMediumScoreSpecial(StudentLiterature[] a, int n)
        {
            StudentLiterature minStudentLiterature = a[0];
            double minStudentScoreSpecial = a[0].mediumScoreStudent();
            for (int i = 0; i < n; i++)
            {
                if (minStudentScoreSpecial > a[i].mediumScoreStudent())
                {
                    minStudentLiterature = a[i];
                }
            }
            Console.WriteLine("________________THÔNG TIN HỌC SINH ĐIỂM CHUYÊN VĂN THẤP NHẤT_______________");
            title2();
            minStudentLiterature.display();
        }

        static public void arrange(StudentLiterature[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].literatureScoreSpecial < a[j].literatureScoreSpecial)
                    {
                        StudentLiterature tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
            Console.WriteLine("__________________SẮP XẾP GIẢM DẦN THEO ĐIỂM CHUYÊN VĂN_________________");
            title2();
            for (int i = 0; i < n; i++)
            {
                a[i].display();
            }
        }
    }
}
