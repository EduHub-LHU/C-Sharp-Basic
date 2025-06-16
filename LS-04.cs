using System;
using System.Collections.Generic;

namespace ListAndArrayExample
{
   class Program
   {
        static void Main(string[] args)
        {
            // === ARRAY EXAMPLE ===
            // Khái niệm: Array (mảng) là một cấu trúc dữ liệu cố định về kích thước và kiểu dữ liệu.
            // Ứng dụng: Sử dụng khi cần lưu trữ một tập hợp dữ liệu có kích thước cố định và cùng kiểu.
            int[] numbers = new int[5]; // Tạo một mảng chứa 5 số nguyên
            Console.WriteLine("Please enter 5 numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i])) // Xử lý nhập liệu
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }
            }

            // === LIST EXAMPLE ===
            // Khái niệm: List là một danh sách động, có thể thay đổi kích thước, lưu trữ các phần tử cùng kiểu.
            // Ứng dụng: Sử dụng khi cần lưu trữ dữ liệu không cố định kích thước và hỗ trợ các thao tác như thêm, xóa, tìm kiếm.
            List<int> evenNumbers = new List<int>(); // Danh sách lưu số chẵn
            List<int> oddNumbers = new List<int>();  // Danh sách lưu số lẻ
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number); // Thêm số chẵn vào danh sách
                }
                else
                {
                    oddNumbers.Add(number); // Thêm số lẻ vào danh sách
                }
            }

            // In danh sách số chẵn
            Console.WriteLine("\nEven Numbers:");
            foreach (int even in evenNumbers)
            {
                Console.WriteLine(even);
            }

            // In danh sách số lẻ
            Console.WriteLine("\nOdd Numbers:");
            foreach (int odd in oddNumbers)
            {
                Console.WriteLine(odd);
            }

            // === HASHSET EXAMPLE ===
            // Khái niệm: HashSet là một tập hợp các phần tử duy nhất, không chứa các phần tử trùng lặp.
            // Ứng dụng: Sử dụng khi cần lưu trữ dữ liệu không trùng lặp hoặc thực hiện các phép toán tập hợp.
            HashSet<int> uniqueNumbers = new HashSet<int>(numbers); // Khởi tạo HashSet từ mảng
            Console.WriteLine("\nUnique Numbers:");
            foreach (int unique in uniqueNumbers)
            {
                Console.WriteLine(unique);
            }
        }
    }
}
