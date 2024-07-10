using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_week4
{
    public class Candidates : Person // Lớp Thí Sinh kế thừa lớp Người
    {
        private string ID; // số báo danh
        private double mathScore; // điểm Toán
        private double physicalScore; // điểm Lý
        private double chemistryScore; // điểm Hóa
        public Candidates() : base()
        {
            ID = "Unknown";
            mathScore = 0;
            physicalScore = 0;
            chemistryScore = 0;
        }
        public Candidates(string ID, double mathScore, double physicalScore, double chemistryScore, 
            string fullName, int birthyear) : base(fullName,birthyear)
        {
            this.ID = ID;
            this.mathScore = mathScore;
            this.physicalScore = physicalScore;
            this.chemistryScore = chemistryScore;
        }
        public double MathScore
        {
            get {
                return mathScore;
            }
            set
            {
                if (value >= 0 && value <= 10)
                    mathScore = value;
            }
        }
        public double PhysicalScore
        {
            get
            {
                return physicalScore;
            }
            set
            {
                if (value >= 0 && value <= 10)
                    physicalScore = value;
            }
        }
        public double ChemistryScore
        {
            get
            {
                return chemistryScore;
            }
            set
            {
                if (value >= 0 && value <= 10)
                    chemistryScore = value;
            }
        }
        public void import()
        {
            input();
            Console.Write("Nhập mã sinh viên: ");
            ID = Console.ReadLine();
            Console.Write("Nhập điểm Toán: ");
            MathScore = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Lý: ");
            PhysicalScore = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Hóa: ");
            ChemistryScore = double.Parse(Console.ReadLine());
        }
        public double sumScore()
        {
            return mathScore + physicalScore + chemistryScore;  
        }
        public void display()
        {
            Console.WriteLine("{0,-25} {1,-10} {2,-15} {3,-15} {4,-15} {5,-15} {6}" 
                , fullName, birthYear, ID, MathScore, PhysicalScore, ChemistryScore, sumScore());
        }
        static public void title()
        {
            Console.WriteLine("{0,-25} {1,-10} {2,-15} {3,-15} {4,-15} {5,-15} {6}"
                , "Họ và tên", "Năm sinh", "Mã SV", "Điểm Toán", "Điểm Lý", "Điểm Hóa", "Tổng điểm");
        }
        static public void importList(Candidates[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\t(*) Nhập thông tin thí sinh thứ {i+1}");
                a[i] = new Candidates();
                a[i].import();
                Console.WriteLine();
            }    
        }    
        static public void displayList(Candidates[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                a[i].display();
            }
            Console.WriteLine();
        }
        static public void upScore(Candidates[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].sumScore() > a[j].sumScore())
                    {
                        Candidates tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }    
                }    
            }
            Console.WriteLine("______________________________________" +
                "DANH SÁCH THÍ SINH TỔNG ĐIỂM TĂNG DẦN___________________________________");
            Candidates.title();
            for (int i = 0; i < n; i++)
            {
                a[i].display();
            }
            Console.WriteLine();
        }
        static public void findID(Candidates[] a, int n)
        {
            Console.Write("Nhập số báo danh cần tìm: ");
            string x = Console.ReadLine();
            int count = 0;
            Console.WriteLine("_________________________________" +
                $"THÔNG TIN THÍ SINH SBD {x} TRONG DANH SÁCH_____________________________________");
            Candidates.title();
            for (int i = 0; i < n; i++)
            {
                if ((a[i].ID).Equals(x) == true)
                {
                    count++;
                    a[i].display();
                }    
            }    
            if (count == 0)         
                Console.WriteLine($"\t(!) Không tìm thấy thí sinh có SBD {x} trong danh sách");
            Console.WriteLine();
        }
        static public void statistical(Candidates[] a, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i].mathScore >= 5 && a[i].physicalScore >= 5 && a[i].chemistryScore >= 5)
                {
                    count++;
                }    
            }
            double S = ((double)count / n)*100;
            Console.WriteLine($"Phần trăm thí sinh đạt yêu cầu (cả ba môn có điểm lớn hơn hoặc bằng 5) là: " +
                $"{Math.Round(S,2)}%");
        }
    }
}
