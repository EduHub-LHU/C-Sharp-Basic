using System;

namespace StackAndDictionaryExample
{
   class Program
   {
       static void Main(string[] args)
       {
           // === STACK EXAMPLE ===
           // Khái niệm: Stack là một cấu trúc dữ liệu LIFO (Last In, First Out),
           // nghĩa là phần tử được thêm cuối cùng sẽ được lấy ra đầu tiên.
           // Ứng dụng: 
           // - Quản lý Undo/Redo trong các trình soạn thảo.
           // - Duyệt cây hoặc biểu thức toán học.
           Stack<int> numberStack = new Stack<int>();
           numberStack.Push(1); // Thêm 1 vào đỉnh của stack
           numberStack.Push(2); // Thêm 2 vào đỉnh của stack
           numberStack.Push(3); // Thêm 3 vào đỉnh của stack

           Console.WriteLine("=== Stack Example ===");
           while (numberStack.Count > 0) // Lặp đến khi stack rỗng
           {
               // Phương thức Pop lấy phần tử trên đỉnh stack và xóa nó
               Console.WriteLine($"Pop: {numberStack.Pop()}");
           }

           // === DICTIONARY EXAMPLE ===
           // Khái niệm: Dictionary là một cấu trúc dữ liệu lưu trữ các cặp khóa-giá trị (key-value).
           // Mỗi khóa là duy nhất và được sử dụng để truy xuất giá trị.
           // Ứng dụng:
           // - Lưu trữ và truy xuất dữ liệu nhanh chóng dựa trên một khóa cụ thể.
           // - Thích hợp trong các ứng dụng cần ánh xạ dữ liệu, ví dụ: bảng từ điển, cấu hình.
           Dictionary<string, int> ageDictionary = new Dictionary<string, int>();
           ageDictionary["Alice"] = 30; // Thêm cặp khóa-giá trị: Alice -> 30
           ageDictionary["Bob"] = 25;   // Thêm cặp khóa-giá trị: Bob -> 25
           ageDictionary["Charlie"] = 35; // Thêm cặp khóa-giá trị: Charlie -> 35

           Console.WriteLine("\n=== Dictionary Example ===");
           foreach (var kvp in ageDictionary) // Lặp qua từng cặp khóa-giá trị
           {
               Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
           }
       }
   }
}
