using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_lab02
{
    // Lớp SinhVienKinhTe kế thừa từ SinhVienUneti
    public class SinhVienKinhTe : SinhVienUneti
    {
        private double diemMarketing;
        private double diemSales;
        public double DiemMarketing
        {
            get { return diemMarketing; }
            set { diemMarketing = value; }
        }
        public double DiemSales
        {
            get { return diemSales; }
            set { diemSales = value; }
        }

        // Constructor khởi tạo giá trị
        public SinhVienKinhTe(string hoTen, string nganh, double diemMarketing, double diemSales)
            : base(hoTen, nganh)
        {
            DiemMarketing = diemMarketing;
            DiemSales = diemSales;
        }

        // Triển khai phương thức trừu tượng GetDiem
        public override double GetDiem()
        {
            return (DiemMarketing + DiemSales) / 2;
        }
    }
}
