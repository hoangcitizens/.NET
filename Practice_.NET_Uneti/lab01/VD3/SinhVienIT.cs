using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD3
{
    class SinhVienIT : SinhVien
    {
        public SinhVienIT() { }
        public new void showInfoIT()
        {
            Console.WriteLine("Đây là sinh viên IT");
            base.showInfo();
        }
    }
}
