using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex05_Lab03
{
    class Program
    {
        // Biến dùng chung để lưu trữ số ngẫu nhiên
        private static int randomNumber = 0;
        private static bool hasNewNumber = false;
        private static readonly object lockObject = new object();

        // Thread 1: Sinh số ngẫu nhiên
        public static void GenerateRandomNumber()
        {
            Random rand = new Random();
            while (true)
            {
                // Tạo ra số ngẫu nhiên từ 1 đến 20
                int num = rand.Next(1, 21);

                // Đồng bộ hóa để gán giá trị cho randomNumber
                lock (lockObject)
                {
                    randomNumber = num;
                    hasNewNumber = true;
                    Console.WriteLine($"Thread 1: Sinh số ngẫu nhiên: {randomNumber}");
                }

                // Tạm dừng Thread 1 trong 2 giây
                Thread.Sleep(2000);
            }
        }

        // Thread 2: Tính bình phương số ngẫu nhiên
        public static void CalculateSquare()
        {
            while (true)
            {
                // Đồng bộ hóa để kiểm tra và tính bình phương
                lock (lockObject)
                {
                    if (hasNewNumber)
                    {
                        int square = randomNumber * randomNumber;
                        Console.WriteLine($"Thread 2: Bình phương của {randomNumber} là: {square}");
                        hasNewNumber = false; // Đánh dấu đã xử lý số ngẫu nhiên hiện tại
                    }
                }

                // Tạm dừng Thread 2 trong 1 giây để đợi số tiếp theo
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            // Tạo 2 Thread
            Thread thread1 = new Thread(new ThreadStart(GenerateRandomNumber));
            Thread thread2 = new Thread(new ThreadStart(CalculateSquare));

            // Khởi động 2 Thread
            thread1.Start();
            thread2.Start();

            // Đảm bảo chương trình không kết thúc ngay
            thread1.Join();
            thread2.Join();
        }
    }
}
