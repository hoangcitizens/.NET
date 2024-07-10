using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_8_3
{
    public struct Worker
    {
        public string workerId; // mã công nhân
        public string fullName; // họ và tên
        public int birthYear; // năm sinh
        public float hsl; // hệ số lương
        public double salary; // lương
        public string department; // phòng ban
        public void import() // phương thức nhập
        {
            Console.Write($"Mời nhập mã công nhân: ");
            workerId = Console.ReadLine();
            Console.Write($"Mời nhập họ và tên: ");
            fullName = Console.ReadLine();
            Console.Write($"Mời nhập năm sinh: ");
            birthYear = int.Parse(Console.ReadLine());
            Console.Write($"Mời nhập hệ số lương: ");
            hsl = float.Parse(Console.ReadLine());
            salary = hsl * 1500000;
            Console.Write($"Mời nhập phòng: ");
            department = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine($"Mã công nhân: {workerId}, Họ và tên:{fullName}, " +
                              $"Lương:{salary}, Phòng ban:{department}");
        }
    }
    internal class Program
    {
        static void importList(Worker[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"(*) Mời nhập công nhân thứ {i + 1}");
                a[i].import();
                Console.WriteLine();
            }
        }
        static void displayList(Worker[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"(*) Thông tin công nhân thứ {i + 1}");
                a[i].display();
                Console.WriteLine();
            }
        }
        // Hiến thị danh sách công nhân lương cao nhất
        static void displayMaxSalary(Worker[] a, int n)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Danh sách công nhân có lương cao nhất là: ");
            double maxSalary = a[0].salary;
            for (int i = 0; i < n; i++)
            {
                if (maxSalary < a[i].salary)
                    maxSalary = a[i].salary;
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i].salary == maxSalary)
                    a[i].display();
            }    
        }
        // Hiển thị danh sách giảm dần theo tổng lương
        static void arrangeList(Worker[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].salary < a[j].salary) // sắp xếp giảm dần
                    {
                        Worker tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }    
                }    
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Danh sách công nhân giảm dần tổng lương");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"(*) Thông tin công nhân thứ {i + 1}");
                a[i].display();
                Console.WriteLine();
            }
        }
        // Tính tổng lương công nhân phòng hành chính
        static double sumSalary(Worker[] a, int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i].department.Trim().ToLower().Equals("hành chính"))
                    sum += a[i].salary;
            }    
            return sum;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.Write("Nhập vào số công nhân: ");
            n = int.Parse(Console.ReadLine());
            Worker[] a = new Worker[n];
            importList(a, n);
            displayList(a, n);
            displayMaxSalary(a, n);
            arrangeList(a, n);
            Console.WriteLine($"Tổng lương công nhân phòng hành chính là {sumSalary(a, n)}");
            Console.ReadLine();
        }
    }
}
