using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class PhanSo
    {
        private int tuso;
        private int mauso;
        public PhanSo() { }
        public PhanSo(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        ~PhanSo() { }
        public int Tuso
        {
            get { return tuso; }
            set { tuso = value; }
        }
        public int Muso
        { 
            get { return mauso; }
            set { mauso = value; }
        }
        // Hàm tính ước chung lớn nhất (UCLN)
        private int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }
        public void nhap()
        {
            Console.Write("Nhập tử số: ");
            this.tuso = Convert.ToInt32(Console.ReadLine());
        }
        // Phép cộng 2 phân số
        public PhanSo Cong(PhanSo ps)
        {
            int tusoMoi = this.tuso * ps.mauso + this.mauso * ps.tuso;
            int mausoMoi = this.mauso * ps.mauso;
            return new PhanSo(tusoMoi, mausoMoi);
        }

        // Phép trừ 2 phân số
        public PhanSo Tru(PhanSo ps)
        {
            int tusoMoi = this.tuso * ps.mauso - this.mauso * ps.tuso;
            int mausoMoi = this.mauso * ps.mauso;
            return new PhanSo(tusoMoi, mausoMoi);
        }

        // Phép nhân 2 phân số
        public PhanSo Nhan(PhanSo ps)
        {
            int tusoMoi = this.tuso * ps.tuso;
            int mausoMoi = this.mauso * ps.mauso;
            return new PhanSo(tusoMoi, mausoMoi);
        }

        // Phép chia 2 phân số
        public PhanSo Chia(PhanSo ps)
        {
            if (ps.tuso == 0)
            {
                throw new ArgumentException("Không thể chia cho 0.");
            }
            int tusoMoi = this.tuso * ps.mauso;
            int mausoMoi = this.mauso * ps.tuso;
            return new PhanSo(tusoMoi, mausoMoi);
        }

        // Hiển thị phân số
        public override string ToString()
        {
            return $"{tuso}/{mauso}";
        }
    }
}
