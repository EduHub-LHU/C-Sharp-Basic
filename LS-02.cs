using System;

namespace StructVsClassExample
{
    /*
    1. Tham trị (Value Type)
    Khi tham trị được sao chép, giá trị thực sự của nó được sao chép vào biến mới.

    Hai biến sẽ hoàn toàn độc lập với nhau, các thuộc tính sẽ không giống nhau nếu thay đổi.
    */
    struct PointStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    /*
    2. Tham chiếu (Reference Type)
    Khi tham chiếu được sao chép, cả hai biến sẽ trỏ đến cùng một đối tượng trong bộ nhớ.

    Do đó, các thuộc tính của đối tượng sẽ giống nhau.

    Thay đổi thuộc tính thông qua một biến sẽ làm thay đổi giá trị cho cả hai biến, vì chúng thực sự đang tham chiếu đến cùng một dữ liệu.
    */
    class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Struct Example ===");
            RunStructExample(); // Chạy ví dụ với Struct

            Console.WriteLine("\n=== Class Example ===");
            RunClassExample(); // Chạy ví dụ với Class
        }

        // Ví dụ về Struct
        static void RunStructExample()
        {
            // Tạo một đối tượng struct
            PointStruct p1 = new PointStruct { X = 10, Y = 20 };

            // Sao chép giá trị của p1 sang p2 (toàn bộ dữ liệu được sao chép)
            PointStruct p2 = p1;

            // Thay đổi giá trị X của p2
            p2.X = 50;

            // Vì là kiểu giá trị (value type), thay đổi ở p2 không ảnh hưởng đến p1
            Console.WriteLine($"p1: ({p1.X}, {p1.Y})"); // Kết quả: (10, 20)
            Console.WriteLine($"p2: ({p2.X}, {p2.Y})"); // Kết quả: (50, 20)
        }

        // Ví dụ về Class
        static void RunClassExample()
        {
            // Tạo một đối tượng class
            PointClass p1 = new PointClass { X = 10, Y = 20 };

            // Sao chép tham chiếu của p1 sang p2 (cả hai trỏ tới cùng một đối tượng)
            PointClass p2 = p1;

            // Thay đổi giá trị X của p2
            p2.X = 50;

            // Vì là kiểu tham chiếu (reference type), thay đổi ở p2 sẽ ảnh hưởng đến p1
            Console.WriteLine($"p1: ({p1.X}, {p1.Y})"); // Kết quả: (50, 20)
            Console.WriteLine($"p2: ({p2.X}, {p2.Y})"); // Kết quả: (50, 20)
        }
    }
}
