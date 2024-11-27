using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_lab02
{
    class MatrixOperations
    {
        // Phương thức nhập ma trận
    public static double[,] InputMatrix(int n, int m)
        {
            double[,] matrix = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Nhập phần tử [{i + 1}, {j + 1}]: ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }

        // Phương thức hiển thị ma trận
        public static void DisplayMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Phương thức tìm số âm nhỏ nhất trong ma trận
        public static double FindSmallestNegative(double[,] matrix)
        {
            double smallestNegative = double.MaxValue;
            bool foundNegative = false;

            foreach (var element in matrix)
            {
                if (element < 0 && element < smallestNegative)
                {
                    smallestNegative = element;
                    foundNegative = true;
                }
            }

            if (foundNegative)
                return smallestNegative;
            else
                return double.NaN; // Không có số âm
        }

        // Phương thức sắp xếp từng cột theo thứ tự tăng dần
        public static void SortColumns(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int j = 0; j < cols; j++)
            {
                double[] column = new double[rows];
                for (int i = 0; i < rows; i++)
                {
                    column[i] = matrix[i, j];
                }

                Array.Sort(column);

                for (int i = 0; i < rows; i++)
                {
                    matrix[i, j] = column[i];
                }
            }
        }

        // Phương thức xóa cột thứ k trong ma trận
        public static double[,] RemoveColumn(double[,] matrix, int k)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (k < 1 || k > cols)
            {
                Console.WriteLine("Cột không hợp lệ.");
                return matrix;
            }

            double[,] newMatrix = new double[rows, cols - 1];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0, newJ = 0; j < cols; j++)
                {
                    if (j != k - 1)
                    {
                        newMatrix[i, newJ++] = matrix[i, j];
                    }
                }
            }

            return newMatrix;
        }

        // Phương thức tính trung bình cộng các số chẵn trong ma trận
        public static double AverageOfEvenNumbers(double[,] matrix)
        {
            double sum = 0;
            int count = 0;

            foreach (var element in matrix)
            {
                if (element % 2 == 0)
                {
                    sum += element;
                    count++;
                }
            }

            if (count > 0)
                return sum / count;
            else
                return double.NaN; // Không có số chẵn
        }

        // Chương trình chính
        static void Main(string[] args)
        {
            // 1. Nhập ma trận
            Console.Write("Nhập số hàng của ma trận: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Nhập số cột của ma trận: ");
            int m = int.Parse(Console.ReadLine());

            double[,] matrix = InputMatrix(n, m);

            // 2. Hiển thị ma trận
            Console.WriteLine("Ma trận vừa nhập:");
            DisplayMatrix(matrix);

            // 3. Tìm số âm nhỏ nhất của ma trận
            double smallestNegative = FindSmallestNegative(matrix);
            if (!double.IsNaN(smallestNegative))
            {
                Console.WriteLine($"Số âm nhỏ nhất trong ma trận là: {smallestNegative}");
            }
            else
            {
                Console.WriteLine("Không có số âm trong ma trận.");
            }

            // 4. Sắp xếp từng cột theo thứ tự tăng dần
            SortColumns(matrix);
            Console.WriteLine("Ma trận sau khi sắp xếp từng cột tăng dần:");
            DisplayMatrix(matrix);

            // 5. Nhập số nguyên dương k, xóa cột thứ k của ma trận
            Console.Write("Nhập số nguyên dương k (để xóa cột thứ k): ");
            int k = int.Parse(Console.ReadLine());
            matrix = RemoveColumn(matrix, k);
            Console.WriteLine("Ma trận sau khi xóa cột thứ k:");
            DisplayMatrix(matrix);

            // 6. Tính trung bình cộng các phần tử có giá trị chẵn
            double averageEven = AverageOfEvenNumbers(matrix);
            if (!double.IsNaN(averageEven))
            {
                Console.WriteLine($"Trung bình cộng các số chẵn trong ma trận là: {averageEven}");
            }
            else
            {
                Console.WriteLine("Không có số chẵn trong ma trận.");
            }
        }
    }
}
