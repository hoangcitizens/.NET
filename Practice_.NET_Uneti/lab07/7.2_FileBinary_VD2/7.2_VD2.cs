using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_FileBinary_VD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n;
            // Nhập mảng Console.Write(" n = ");
            Console.Write("Nhập số phần tử của mảng n = ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            // Lưu mảng ra tệp nhị phân
            string fileName = "D:\\Practice_.NET_Uneti\\lab07\\7.2_FileBinary_VD2\\DuLieu.BIN";
            BinaryWriter wr =
            new BinaryWriter(new FileStream(fileName,
            FileMode.Create));
            for (int i = 0; i < n; i++)
                wr.Write(a[i]);
            wr.Close();
            // Đọc dãy số từ tệp nhị phân
            BinaryReader rd = new BinaryReader(
            new FileStream(fileName, FileMode.Open));
            Console.Write("Phần tử vừa nhập là: ");
            while (rd.BaseStream.Position !=
            rd.BaseStream.Length)
            {
                Console.Write(rd.ReadInt32() + ", ");
            }     
            rd.Close();
            Console.ReadLine();
        }
    }
}
