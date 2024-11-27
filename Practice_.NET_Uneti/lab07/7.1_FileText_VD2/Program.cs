using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_FileText_VD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool debug = true;
            Console.WriteLine("\nĐếm số lần xuất hiện cua chu cai trong File: ");
            Console.WriteLine("-------------------------\n");
            Console.Write("Nhập tên file: "); // D:\Practice_.NET_Uneti\lab07\7.1_FileText_VD2\testVD2.txt
            string nameFile = Console.ReadLine();
            Console.Write("Nhập chữ cái cần đếm: ");
            string letter = Console.ReadLine();
            StreamReader myfile;
            myfile = File.OpenText(nameFile);
            string line;
            int countLetter = 0;
            do
            {
                line = myfile.ReadLine();
                if (line != null)
                    for (int i = 0; i < line.Length; i++)
                        if (line.Substring(i, 1) == letter)
                            countLetter++;
            } while (line != null);
            myfile.Close();
            Console.WriteLine("So lan xuat hien cua chu cai trong file la: {0}", countLetter);
            if (debug)
                Console.ReadLine();
            Console.ReadKey();
        }
    
    }
}
