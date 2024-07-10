/*
    Bài 8: - Viết chương trình tạo một struct công nhân bao gồm :  
                mã công nhân, họ tên, năm sinh, hệ số lương, lương, phòng
           - Nhập vào n công nhân từ bàn phím(không nhập lương biết lương= hệ số lương*1.500.000),
             sau đó in ra danh sách công nhân đã nhập, hiển thị thông tin của công nhân có lương cao nhất, 
             sắp xếp danh sách công nhân theo chiều giảm dần của lương. 
           - Tính tổng lương của các nhân viên của phòng Hành chính
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

struct Worker
{
    public string ID;
    public string fullName;
    public int birthYear;
    public float s;
    public float salary;
    public string roomName;
    public void import()
    {
        Console.Write("Nhập mã công nhân: ");
        ID = Console.ReadLine();
        Console.Write("Nhập họ và tên: ");
        fullName = Console.ReadLine();
        Console.Write("Nhập năm sinh: ");
        birthYear = int.Parse(Console.ReadLine());
        Console.Write("Nhập hệ số lương: ");
        s = float.Parse(Console.ReadLine());
        salary = s * 1500000;
        Console.Write("Nhập tên phòng: ");
        roomName = Console.ReadLine();
    }
    public void display()
    {
        Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-10} {4,-10} {5}"
                            , ID, fullName, birthYear, s, salary, roomName);
    }
}

namespace ex8
{
    internal class ex8
    {
        static void title()
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-10} {4,-10} {5}"
                            , "Mã cn", "Họ và tên", "Năm sinh", "HSL", "Lương", "Tên phòng");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng công nhân: ");
            int n = int.Parse(Console.ReadLine());
            Worker[] workers = new Worker[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"(*) Nhập thông tin công nhân thứ {i + 1}");
                workers[i].import();
                Console.WriteLine();
            }
            Console.WriteLine("\t\t\tTHÔNG TIN CÔNG NHÂN");
            title();
            for (int i = 0; i < n; i++)
            {
                workers[i].display();
            }

            // Tìm công nhân có lương cao nhất
            float maxSalary = workers[0].salary;
            Worker w = workers[0];
            for (int i = 1; i < n; i++)
            {
                if (workers[i].salary > maxSalary)
                {
                    maxSalary = workers[i].salary;
                    w = workers[i];
                }
            }
            Console.WriteLine("\n\t\tTHÔNG TIN CÔNG NHÂN CÓ LƯƠNG CAO NHẤT");
            title();
            w.display();

            // Sắp xếp danh sách công nhân theo chiều giảm dần của lương
            Console.WriteLine("\n\t\tDanh sách công nhân sau khi sắp xếp");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (workers[j].salary < workers[j+1].salary)
                    {
                        Worker tmp = workers[j];
                        workers[j] = workers[j+1];
                        workers[j+1] = tmp;
                    }    
                }    
            }
            title();
            for (int i = 0; i < n; i++)
            {
                workers[i].display();
            }

            // Tính tổng lương của các nhân viên của phòng Hành chính
            float sumSalary = 0;
            for (int i = 0; i < n; i++)
            {
                if (String.Equals(workers[i].roomName,"Hành chính") == true)
                    sumSalary += workers[i].salary;
            }    
            Console.WriteLine($"\nTổng lương của các nhân viên của phòng Hành chính: {sumSalary}");
            Console.ReadLine();
        }
    }
}
