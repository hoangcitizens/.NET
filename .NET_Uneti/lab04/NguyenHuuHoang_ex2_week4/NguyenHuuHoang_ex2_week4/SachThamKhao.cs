using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_ex2_week4
{
    public class SachThamKhao : Sach
    {
        public override int option() { return 2; }
        private int thue; // tiền thuế
        public SachThamKhao() : base()
        {
            thue = 0;
        }
        public SachThamKhao(int thue, string ID, string nxb, int donGia, int sl)
            : base(ID, nxb, donGia, sl)
        {
            this.thue = thue;
        }
        public override void import()
        {
            base.import();
            Console.Write("Nhập tiền thuế: ");
            thue = int.Parse(Console.ReadLine());
        }
      
        public override double thanhTien()
        {
            return sl * donGia + thue;
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("{0,4}", thanhTien());
        }
    }
}
