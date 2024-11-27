using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Test01
    {
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo(1, 2);
            PhanSo ps2 = new PhanSo(3, 4);

            PhanSo tong = ps1.Cong(ps2);
            PhanSo hieu = ps1.Tru(ps2);
            PhanSo tich = ps1.Nhan(ps2);
            PhanSo thuong = ps1.Chia(ps2);

            Console.WriteLine($"Tổng: {ps1} + {ps2} = {tong}");
            Console.WriteLine($"Hiệu: {ps1} - {ps2} = {hieu}");
            Console.WriteLine($"Tích: {ps1} * {ps2} = {tich}");
            Console.WriteLine($"Thương: {ps1} / {ps2} = {thuong}");
        }
    }
}
