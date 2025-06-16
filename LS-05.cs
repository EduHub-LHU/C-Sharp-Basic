using System;
using System.Collections.Specialized;
using System.Collections;
using System.Collections.Generic;

namespace ListAndArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // === PriorityQueue Example ===
            // Khái niệm: PriorityQueue là một cấu trúc dữ liệu hỗ trợ xếp phần tử dựa trên độ ưu tiên.
            // Ứng dụng: Sử dụng khi cần xử lý các phần tử theo độ ưu tiên thay vì theo thứ tự nhập hoặc vị trí.
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
            Console.WriteLine("Please enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                int number; // Định nghĩa biến số trước vòng lặp while để sử dụng đúng ngữ cảnh.
                Console.Write($"Number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out number)) // Xử lý nhập không hợp lệ
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }
                priorityQueue.Enqueue(number, number); // Sử dụng giá trị làm độ ưu tiên
            }

            Console.WriteLine("\nNumbers in ascending order:");
            while (priorityQueue.Count > 0) // Trích xuất phần tử theo độ ưu tiên (thứ tự tăng dần)
            {
                Console.WriteLine(priorityQueue.Dequeue());
            }

            // === BitArray Example ===
            // Khái niệm: BitArray là một cấu trúc dữ liệu lưu trữ các giá trị boolean (true/false) dưới dạng bit.
            // Ứng dụng: Sử dụng khi cần tối ưu hóa bộ nhớ cho dữ liệu boolean hoặc thực hiện các phép toán bit.
            BitArray bits = new BitArray(5); // Tạo một BitArray với kích thước 5
            bits[0] = true;  // Gán giá trị tại chỉ mục 0
            bits[1] = false; // Gán giá trị tại chỉ mục 1
            Console.WriteLine(bits[0]); // Kết quả: True
            Console.WriteLine(bits[1]); // Kết quả: False

            // === NameValueCollection Example ===
            // Khái niệm: NameValueCollection là một tập hợp các cặp key-value cho phép nhiều giá trị được gán cho một khóa.
            // Ứng dụng: Sử dụng khi cần lưu trữ các giá trị liên kết với một khóa nhưng cho phép trùng lặp giá trị trên khóa đó.
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("key", "value1"); // Thêm giá trị đầu tiên cho khóa "key"
            nvc.Add("key", "value2"); // Thêm giá trị thứ hai cho khóa "key"

            // Kiểm tra null trước khi truy cập GetValues để tránh lỗi khi khóa không tồn tại
            var values = nvc.GetValues("key");
            if (values != null)
            {
                foreach (var value in values) // Duyệt qua các giá trị tương ứng với "key"
                {
                    Console.WriteLine(value); // Kết quả: value1, value2
                }
            }
            else
            {
                Console.WriteLine("No values found for the key."); // Thông báo nếu không tìm thấy giá trị
            }
        }
    }
}
