using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_ex2_tuan5
{
    public class SinhVien
    {
        public delegate void ScoreChangedHandler(object sender, EventArgs e);
        public event ScoreChangedHandler ScoreChanged;  
        private string fullName;
        private double score;
        public string Fullname
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public double Score
        {
            get { return score; }
            set { 
                if (value != score)
                {
                    score = value;
                    RunScoreChanged();
                }    
            }
        }
        protected virtual void RunScoreChanged()
        {
            if (ScoreChanged != null)
            {
                ScoreChanged(this, new EventArgs());
            }    
        }
    }
    public class Program
    {
        static void information1(object sender, EventArgs e)
        {
            SinhVien sv = (SinhVien)sender;
            Console.WriteLine($"Điểm của sinh viên {sv.Fullname} đã thay đổi");
        }
        static void information2(object sender, EventArgs e)
        {
            SinhVien sv = (SinhVien)sender;
            Console.WriteLine($"Điểm của sinh viên {sv.Fullname} đã thay đổi. Điểm hiện tại là: {sv.Score}");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            SinhVien sv = new SinhVien();
            sv.Fullname = "Nguyễn Hữu Hoàng";
            sv.Score = 8.5;

            sv.ScoreChanged += information1;
            sv.ScoreChanged += information2;

            sv.Score = 9;
            Console.Write("Mời nhập điểm: ");
            sv.Score = double.Parse(Console.ReadLine());    

            Console.ReadLine();
        }
    }
}
