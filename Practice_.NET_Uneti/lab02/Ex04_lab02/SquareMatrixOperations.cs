using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_lab02
{
    internal class SquareMatrixOperations
    {
        // 1. Phương thức nhập ma trận vuông cấp n
        public static double[,] InputMatrix(int n)
        {
            double[,] matrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Nhập phần tử [{i + 1}, {j + 1}]: ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }

        // 2. Phương thức hiển thị ma trận
        public static void DisplayMatrix(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // 3. Phương thức tính tổng các phần tử nằm trên đường chéo phụ
        public static double SumSecondaryDiagonal(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, n - 1 - i]; // Tổng các phần tử trên đường chéo phụ
            }
            return sum;
        }

        // 4. Phương thức tìm số âm lớn nhất trên đường chéo chính
        public static double FindLargestNegativeOnMainDiagonal(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double largestNegative = double.NaN;
            bool foundNegative = false;

            for (int i = 0; i < n; i++)
            {
                if (matrix[i, i] < 0)
                {
                    if (!foundNegative || matrix[i, i] > largestNegative)
                    {
                        largestNegative = matrix[i, i];
                        foundNegative = true;
                    }
                }
            }

            return largestNegative;
        }

        // 5. Phương thức đếm các phần tử chia hết cho 3 và 5
        public static int CountDivisibleBy3And5(double[,] matrix)
        {
            int count = 0;
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] % 15 == 0) // Chia hết cho cả 3 và 5 (bội số chung của 15)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        // Phương thức tạo menu
        public static void Menu(double[,] matrix)
        {
            int choice;
            do
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Hiển thị ma trận");
                Console.WriteLine("2. Tính tổng các phần tử trên đường chéo phụ");
                Console.WriteLine("3. Tìm số âm lớn nhất trên đường chéo chính");
                Console.WriteLine("4. Đếm các phần tử chia hết cho 3 và 5");
                Console.WriteLine("5. Thoát");
                Console.Write("Lựa chọn của bạn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nMa trận:");
                        DisplayMatrix(matrix);
                        break;

                    case 2:
                        double sumDiagonal = SumSecondaryDiagonal(matrix);
                        Console.WriteLine($"Tổng các phần tử trên đường chéo phụ là: {sumDiagonal}");
                        break;

                    case 3:
                        double largestNegative = FindLargestNegativeOnMainDiagonal(matrix);
                        if (double.IsNaN(largestNegative))
                        {
                            Console.WriteLine("Không có số âm nào trên đường chéo chính.");
                        }
                        else
                        {
                            Console.WriteLine($"Số âm lớn nhất trên đường chéo chính là: {largestNegative}");
                        }
                        break;

                    case 4:
                        int countDivisible = CountDivisibleBy3And5(matrix);
                        Console.WriteLine($"Số phần tử chia hết cho 3 và 5 trong ma trận là: {countDivisible}");
                        break;

                    case 5:
                        Console.WriteLine("Chương trình kết thúc.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            } while (choice != 5);
        }

        // Chương trình chính
        static void Main(string[] args)
        {
            Console.Write("Nhập kích thước ma trận vuông (n x n): ");
            int n = int.Parse(Console.ReadLine());

            double[,] matrix = InputMatrix(n); // Nhập ma trận

            // Hiển thị menu
            Menu(matrix);
        }
    }
}
