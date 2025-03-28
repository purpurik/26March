using System;

class Program
{
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int x = 10, y = 20;
        Console.WriteLine($"Before Swap: x = {x}, y = {y}");
        Swap(ref x, ref y);
        Console.WriteLine($"After Swap: x = {x}, y = {y}");

        string s1 = "Hello", s2 = "World";
        Console.WriteLine($"Before Swap: s1 = {s1}, s2 = {s2}");
        Swap(ref s1, ref s2);
        Console.WriteLine($"After Swap: s1 = {s1}, s2 = {s2}");

        var p1 = new Person("Alice", 30);
        var p2 = new Person("Bob", 25);
        Console.WriteLine($"Before Swap: {p1}, {p2}");
        Swap(ref p1, ref p2);
        Console.WriteLine($"After Swap: {p1}, {p2}");
    }
}

class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString() => $"{Name}, {Age}";
}
