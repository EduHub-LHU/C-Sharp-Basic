using System;

class GenericClass<T>
{
    public T Value { get; set; }

    public GenericClass(T value)
    {
        Value = value;
    }

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}
class GenericClassExample
{
    // Generic method that accepts any type T
    public static void PrintValue<T>(T value)
    {
        Console.WriteLine($"Value: {value}");
    }
}
class GenericClassExample2
{
    // Generic method that accepts any type T and returns a string representation
    public static string GetString<T>(T value)
    {
        return value.ToString();
    }
}
class stack<T>
{
    private T[] items;
    private int top;

    public stack(int size)
    {
        items = new T[size];
        top = -1;
    }

    public void Push(T item)
    {
        if (top == items.Length - 1)
            throw new InvalidOperationException("Stack overflow");
        items[++top] = item;
    }

    public T Pop()
    {
        if (top == -1)
            throw new InvalidOperationException("Stack underflow");
        return items[top--];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
}
class Program
{
    static void Main()
    {
        GenericClass<int> intInstance = new GenericClass<int>(5);
        intInstance.Display();

        GenericClass<string> stringInstance = new GenericClass<string>("Hello");
        stringInstance.Display();
        GenericClassExample.PrintValue(10);
        GenericClassExample.PrintValue("Hello World");
        GenericClassExample2.GetString(123);
        GenericClassExample2.GetString("Generic Method Example");
        stack<int> intStack = new stack<int>(5);
        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);
        while (!intStack.IsEmpty())
        {
            Console.WriteLine($"Popped: {intStack.Pop()}");
        }
    }
}
