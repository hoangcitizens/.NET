using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_ex2_week4
{
    public class Sach
    {
        protected string ID; // mã sách
        protected string nxb; // nhà xuất bản
        protected int donGia; // đơn giá
        protected int sl; // số lượng
        public Sach()
        {
            ID = "Unknown";
            nxb = "Unknown";
            donGia = 0;
            sl = 0;
        }
        public Sach(string ID, string nxb, int donGia, int sl)
        {
            this.ID = ID;
            this.nxb = nxb;
            this.donGia = donGia;
            this.sl = sl;
        }
        public string NXB
        {
            get { return nxb; }
            set { nxb = value; }
        }
        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public int Sl
        {
            get { return sl; }
            set { sl = value; }
        }
        public virtual void import()
        {
            Console.Write("Nhập mã sách: ");
            ID = Console.ReadLine();
            Console.Write("Nhập tên nhà xuất bản: ");
            nxb = Console.ReadLine();
            Console.Write("Nhập đơn giá: ");
            donGia = int.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng: ");
            sl = int.Parse(Console.ReadLine());
        }
        public virtual double thanhTien() { return 0;}
        public virtual int option() { return 0; }
        public virtual void display()
        {
            Console.Write("{0,-15} {1,-20} {2,-15} {3,-10}", ID, nxb, donGia, sl);
        }
        static public void title()
        {
            Console.WriteLine("{0,-15} {1,-20} {2,-15} {3,-10} {4}", 
                "Mã sách", "Nhà xuất bản", "Đơn giá", "Số lượng" , "Thành tiền");
        }

    }
}
