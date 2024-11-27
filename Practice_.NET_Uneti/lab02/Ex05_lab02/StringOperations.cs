using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex05_lab02
{
    class StringOperations
    {
        // 1. Phương thức nhập và hiển thị xâu ký tự
        public static string InputString()
        {
            Console.Write("Nhập vào một xâu ký tự: ");
            return Console.ReadLine();
        }

        // 2. Phương thức đếm số lượng chữ thường và chữ hoa trong xâu
        public static void CountUpperAndLowerCase(string input)
        {
            int upperCount = 0;
            int lowerCount = 0;

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    upperCount++;
                }
                else if (char.IsLower(c))
                {
                    lowerCount++;
                }
            }

            Console.WriteLine($"Số chữ hoa: {upperCount}");
            Console.WriteLine($"Số chữ thường: {lowerCount}");
        }

        // 3. Phương thức đếm số từ trong xâu
        public static void CountWords(string input)
        {
            // Sử dụng Regex để tách từ dựa trên khoảng trắng
            string[] words = Regex.Split(input.Trim(), @"\s+");
            Console.WriteLine($"Số từ trong xâu: {words.Length}");
        }

        // 4. Phương thức đếm số nguyên âm và phụ âm trong xâu
        public static void CountVowelsAndConsonants(string input)
        {
            int vowelsCount = 0;
            int consonantsCount = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (vowels.Contains(c))
                    {
                        vowelsCount++;
                    }
                    else
                    {
                        consonantsCount++;
                    }
                }
            }

            Console.WriteLine($"Số nguyên âm: {vowelsCount}");
            Console.WriteLine($"Số phụ âm: {consonantsCount}");
        }

        // 5. Phương thức đếm số lần xuất hiện của xâu con trong xâu
        public static void CountSubstringOccurrences(string input)
        {
            Console.Write("Nhập vào một xâu con: ");
            string subString = Console.ReadLine();

            int count = 0;
            int index = input.IndexOf(subString, 0);

            while (index != -1)
            {
                count++;
                index = input.IndexOf(subString, index + subString.Length);
            }

            Console.WriteLine($"Số lần xuất hiện của xâu con '{subString}' là: {count}");
        }

        // Phương thức tạo menu
        public static void Menu()
        {
            string input = "";
            int choice;
            do
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Nhập và hiển thị xâu ký tự");
                Console.WriteLine("2. Đếm số chữ thường và chữ hoa");
                Console.WriteLine("3. Đếm số từ trong xâu");
                Console.WriteLine("4. Đếm số nguyên âm và phụ âm");
                Console.WriteLine("5. Đếm số lần xuất hiện của xâu con");
                Console.WriteLine("6. Thoát");
                Console.Write("Lựa chọn của bạn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        input = InputString();
                        Console.WriteLine($"Xâu ký tự vừa nhập: {input}");
                        break;

                    case 2:
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("Vui lòng nhập một xâu trước.");
                        }
                        else
                        {
                            CountUpperAndLowerCase(input);
                        }
                        break;

                    case 3:
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("Vui lòng nhập một xâu trước.");
                        }
                        else
                        {
                            CountWords(input);
                        }
                        break;

                    case 4:
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("Vui lòng nhập một xâu trước.");
                        }
                        else
                        {
                            CountVowelsAndConsonants(input);
                        }
                        break;

                    case 5:
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("Vui lòng nhập một xâu trước.");
                        }
                        else
                        {
                            CountSubstringOccurrences(input);
                        }
                        break;

                    case 6:
                        Console.WriteLine("Chương trình kết thúc.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            } while (choice != 6);
        }

        // Chương trình chính
        static void Main(string[] args)
        {
            // Hiển thị menu
            Menu();
        }
    }
}
