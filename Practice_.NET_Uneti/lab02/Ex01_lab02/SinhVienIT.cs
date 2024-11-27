using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_lab02
{
    // Lớp SinhVienIT kế thừa từ SinhVienUneti
    public class SinhVienIT : SinhVienUneti
    {
        private double diemJave;
        private double diemCsharp;
        private double diemSQL;
        public double DiemJava
        {
            get { return diemJave; }
            set { diemJave = value; }
        }
        public double DiemCsharp
        {
            get { return diemCsharp; }
            set { diemCsharp = value; }
        }
        public double DiemSQL
        {
            get { return diemSQL; }
            set
            {
                diemSQL = value;
            }
        }

        // Constructor khởi tạo giá trị
        public SinhVienIT(string hoTen, string nganh, double diemJava, double diemCsharp, double diemSQL)
            : base(hoTen, nganh)
        {
            DiemJava = diemJava;
            DiemCsharp = diemCsharp;
            DiemSQL = diemSQL;
        }

        // Triển khai phương thức trừu tượng GetDiem
        public override double GetDiem()
        {
            return (DiemJava + DiemCsharp + DiemSQL) / 3;
        }
    }
}
