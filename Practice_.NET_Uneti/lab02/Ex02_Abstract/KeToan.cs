using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Abstract
{
    class KeToan : NhanVien
    {
        public override string ChucVu()
        {
            return "Kế Toán";
        }
        public override void CongViec()
        {
            Console.WriteLine("Kiểm kê ngân sách, chi thu");
        }
    }
}
