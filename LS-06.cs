using System;

class NonStaticClass
{
    public int InstanceVariable; // Biến không static (riêng cho từng đối tượng)
    public static int SharedVariable = 0; // Biến static (chia sẻ giữa tất cả các đối tượng)

    public NonStaticClass(int value)
    {
        InstanceVariable = value;
        SharedVariable++; // Tăng biến static mỗi khi có đối tượng được tạo
    }

    public void Display()
    {
        Console.WriteLine($"InstanceVariable: {InstanceVariable}, SharedVariable: {SharedVariable}");
    }
}

static class StaticClass
{
    public static string StaticMessage = "This is a static class"; // Biến static trong lớp static

    public static void ShowMessage()
    {
        Console.WriteLine(StaticMessage); // Phương thức static chỉ truy cập biến static
    }
}

class Program
{
    static void Main()
    {
        // Sử dụng biến và phương thức không static
        NonStaticClass obj1 = new NonStaticClass(10);
        NonStaticClass obj2 = new NonStaticClass(20);

        obj1.Display(); // Output: InstanceVariable: 10, SharedVariable: 2
        obj2.Display(); // Output: InstanceVariable: 20, SharedVariable: 2

        // Truy cập biến static qua tên lớp
        Console.WriteLine($"SharedVariable (from class): {NonStaticClass.SharedVariable}"); // Output: 2

        // Sử dụng lớp static
        StaticClass.ShowMessage(); // Output: This is a static class

        // Thay đổi biến static trong lớp static
        StaticClass.StaticMessage = "Static class message updated!";
        StaticClass.ShowMessage(); // Output: Static class message updated!
    }
}
