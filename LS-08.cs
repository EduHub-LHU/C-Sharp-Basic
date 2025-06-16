using System;


class Getset
{
    private int _value;

    public int Value
    {
        get { return _value; } // Getter trả về giá trị
        set { _value = value; } // Setter gán giá trị
    }
}

class Animal
{
    int _SoChan;
    public int SoChan
    {
        get { return _SoChan; }
        set { _SoChan = value; }
    }
    string _Ten;
    public string Ten
    {
        get { return _Ten; }
        set { _Ten = value; }
    }
    string _tiengkeu;
    public string TiengKeu
    {
        get { return _tiengkeu; }
        set { _tiengkeu = value; }
    }
    public Animal(int soChan, string ten)
    {
        _SoChan = soChan;
        _Ten = ten;
        Console.WriteLine($"Động vật {_Ten} có {_SoChan} chân");
    }

    public void Speaking(string tiengkeu)
    {
        _tiengkeu = tiengkeu;
        Console.WriteLine($"Động vật {_Ten} nói: {_tiengkeu}");
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Tên: {_Ten}, Số chân: {_SoChan}, Tiếng kêu: {_tiengkeu}");
    }
   
}
 class Dog : Animal
    {
        // Constructor lớp con
        public Dog(int soChan, string ten) : base(soChan, ten)
    {
    // Các logic khởi tạo riêng cho Dog
    TiengKeu = "Gâu Gâu"; // Đặc điểm riêng
}

        public void Bark()
        {
            Console.WriteLine($"{Ten} đang sủa: {TiengKeu}");
        }
    }
class Program
{
    static void Main()
    {

        // Tạo một đối tượng Getset
        Getset obj = new Getset();

        // Sử dụng setter để gán giá trị
        obj.Value = 10;

        // Sử dụng getter để lấy giá trị
        Console.WriteLine($"Value: {obj.Value}"); // Output: Value: 10

        // Thay đổi giá trị thông qua setter
        obj.Value = 20;
        Console.WriteLine($"Updated Value: {obj.Value}"); // Output: Updated Value: 20

        // Tạo một đối tượng Animal
        Animal animal = new Animal(4, "Mèo");
        animal.Speaking("Meo Meo");
        animal.ShowInfo();
        // Tạo một đối tượng Dog
        Dog dog = new Dog(4, "Chó");
        dog.Speaking("Gâu Gâu");
        dog.ShowInfo();
        dog.Bark(); // Gọi phương thức Bark của lớp Dog
                   
        dog.SoChan = 3; // Thay đổi số chân
        dog.Ten = "Chó con"; // Thay đổi tên
        dog.TiengKeu = "Gâu Gâu Nhỏ"; // Thay đổi tiếng kêu
        dog.ShowInfo(); // Hiển thị thông tin đã thay đổi
    }
}
