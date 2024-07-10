using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
	static : tĩnh (cố định)
	=> tạo ra biến có ảnh hưởng đến toàn bộ chương trình nhung cac bien do gan lien voi class nao do 
	   nhung ban chat do la bien global
    bien static : giong bien global nhung no duoc gan lien voi class
    ham static: duoc goi khi khong can khoi tao object nào
*/
/*  
    Convert.toDataType(); // chuyển kiểu dữ liệu
 
 */
/*  
    Console.WriteLine("{0,4}\n+{1,4}\n---\n{2,4}",i,j,i + j); (0,4) : dùng 4 ô trống để in ra i
 */
// cùng 1 file có thể chứa nhiều namespace

namespace lab1
{
    //class A { } // có thể chứa nhiều class khác trong namespace
                //int x, y, z; namespace không chứa được phương thức
    public class A
    {
        public static int bientoancuc;
    }
    internal class Program
    {
        // static : dùng cho cả class
        public static int bientoancuc; // biến static dùng chung cho cả class
        public static void giaiphuongtrinhbac1()
        {
            A.bientoancuc = 1;
        }
        public void giaiptbac1() // không có static thì là 1 phương thức của 1 đối tượng 
        {

        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World"); // Writeline : in xuống dòng
            Console.ReadLine(); // chờ nhập vào một dòng, mục đích để dừng màn hình
            Program.giaiphuongtrinhbac1();
        }
    }
}
