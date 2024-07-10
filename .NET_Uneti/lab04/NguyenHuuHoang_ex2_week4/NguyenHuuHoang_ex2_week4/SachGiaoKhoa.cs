using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_ex2_week4
{
    public class SachGiaoKhoa : Sach
    {
        public override int option() { return 1; }
        private string tinhTrang;
        public SachGiaoKhoa() : base()
        {
            tinhTrang = "Unknown";
        }
        public SachGiaoKhoa(string tinhTrang, string ID, string nxb, int donGia, int sl) 
            : base(ID, nxb, donGia, sl)
        {
            this.tinhTrang = tinhTrang;
        }
        public override void import()
        {
            base.import();
            Console.Write("Nhập tình trạng sách: ");
            TinhTrang = Console.ReadLine();
        }
        public string TinhTrang
        {
            get { return tinhTrang; }
            set { 
                if (value == "Mới" && value == "Cũ")
                    tinhTrang = value; 
            }
        }
        public override double thanhTien()
        {
            if (tinhTrang == "Mới")
                return sl * donGia;
            else
                return sl * donGia * 0.5;
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("{0,4}", thanhTien());
        }

    }
}
