using System;

// Interface định nghĩa hợp đồng
interface IAnimal
{
    void Eat(); // Phương thức phải được triển khai
}

// Abstract class định nghĩa nền tảng chung và phương thức trừu tượng
abstract class Animal : IAnimal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    // Phương thức abstract - không có logic mặc định, bắt buộc lớp con phải override
    public abstract void Speak();

    // Phương thức virtual - có logic mặc định, lớp con có thể override nếu cần
    public virtual void Move()
    {
        Console.WriteLine($"{Name} đang di chuyển.");
    }

    // Triển khai phương thức từ interface
    public void Eat()
    {
        Console.WriteLine($"{Name} đang ăn.");
    }
}

// Lớp kế thừa và triển khai các thành phần
class Dog : Animal
{
    public Dog(string name) : base(name) { }

    // Ghi đè phương thức abstract
    public override void Speak()
    {
        Console.WriteLine($"{Name} nói: Gâu Gâu!");
    }

    // Ghi đè phương thức virtual
    public override void Move()
    {
        Console.WriteLine($"{Name} đang chạy.");
    }
}

class Fish : Animal
{
    public Fish(string name) : base(name) { }

    // Ghi đè phương thức abstract
    public override void Speak()
    {
        Console.WriteLine($"{Name} không nói, nhưng phát ra bong bóng!");
    }

    // Không ghi đè phương thức virtual, sử dụng logic mặc định
}

// Chương trình chính
class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Chó");
        Fish fish = new Fish("Cá");

        Console.WriteLine("--- Chó ---");
        dog.Speak();   // Gâu Gâu!
        dog.Move();    // Chạy
        dog.Eat();     // Ăn

        Console.WriteLine("\n--- Cá ---");
        fish.Speak();  // Bong bóng
        fish.Move();   // Logic mặc định
        fish.Eat();    // Ăn
    }
}
