namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            string c = "Hello World";
            Console.WriteLine(a);
            Console.WriteLine("Hello, World!");
            int d = a + b;
            Console.WriteLine(d);
            Console.WriteLine("please fill in n :");
            int n = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine(n % 2 == 0 ? "n is even" : "n is odd");
            if (n > 0)
            {
                Console.WriteLine("n is positive");
            }
            else if (n < 0)
            {
                Console.WriteLine("n is negative");
            }
            else
            {
                Console.WriteLine("n is zero");
            }
            int e;
            string f = Console.ReadLine() ?? "0";
            if (int.TryParse(f, out e))
            {
                Console.WriteLine("The value of e is: " + e);
            }
            else if (n == 0)
            {
                Console.WriteLine("n is zero, so e is not assigned a value.");
            }
            else if (n < 0)
            {
                Console.WriteLine("test");
            }
            else
            {
                Console.WriteLine("Invalid input for e");
            }

            Console.WriteLine("Please enter a string :");
            string input = Console.ReadLine();
            if (input.Length > 0)
            {
                Console.WriteLine("The string is not empty");
            }
            else
            {
                Console.WriteLine("The string is empty");
            }
            while (true)
            {
                Console.WriteLine("Please enter a number (or type 'exit' to quit):");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "exit")
                {
                    break;
                }
                // tham số int.TryParse sẽ trả về true nếu chuyển đổi thành công, false nếu không thành công
                // neu 2 bien duoc gan cho nhau thi phai cung kieu du lieu
              
                if (int.TryParse(userInput, out int number))
                {
                    Console.WriteLine($"You entered the number: {number}");
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                }
            }
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("This is a while loop iteration: " + j);
                j++;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("This is a for loop iteration: " + i);
            }
            char[] charArray = { 'H', 'e', 'l', 'l', 'o' };
            foreach (char ch in c)
            {
                Console.WriteLine("Character: " + ch);
            }
            int count = 0;
            do
            {
                Console.WriteLine(count);
                count++;
            } while (count == 3);
            PrintMessage("This is a message from a method.");
            int sum = Add(5, 10);
            int product = Multiply(5, 10);
            int difference = Subtract(10, 5);
            int quotient = Divide(10, 2);
            int r = 10;
            printR(ref r);
        }
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        static int Add(int x, int y)
        {
            return x + y;

        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static int Subtract(int x, int y)
        {
            return x - y;
        }
        static int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return x / y;
        }
        // Phương thức này sử dụng từ khóa ref để truyền tham chiếu của biến r
        // khi gọi phương thức, giá trị của r sẽ được thay đổi trong phương thức
        // biến r sẽ được gán giá trị mới là r + 5 thay vì r = 10
        // nếu không xài ref thì r vẫn = 10
        static void printR (ref int r)
        {
            Console.WriteLine(r+5);
        }
    }
}
