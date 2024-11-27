using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_FileBinary_VD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            BinaryReader br;
            int i = 13;
            double d = 2.56317;
            bool b = true;
            string s = "Hello World !!";
            //create the file
            try
            {
                bw = new BinaryWriter(new FileStream("D:\\Practice_.NET_Uneti\\lab07\\7.2_FileBinary_VD1\\mydata.bin",
                FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "Cannot create file.");
            return;
            }
            //writing into the file
            try
            {
                bw.Write(i);
                bw.Write(d); bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "Cannot write to file.");
            return;
            }
            bw.Close();
            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream("D:\\Practice_.NET_Uneti\\lab07\\7.2_FileBinary_VD1\\mydata.bin",
                FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "Cannot open file.");
            return;
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer data: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                s = br.ReadString();
                Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "Cannot read from file.");
                return;
            }
            //close the file
            br.Close();
            Console.ReadKey();
        }
    }
}
