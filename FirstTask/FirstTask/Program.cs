using System;
using System.Collections.Generic;

abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void Speak();
}

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override void Speak()
    {
        Console.WriteLine($"{Name}: Гав-гав!");
    }
}

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override void Speak()
    {
        Console.WriteLine($"{Name}: Мяу-мяу!");
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog("Бобик", 3),
            new Cat("Мурка", 2),
            new Dog("Рекс", 5),
            new Cat("Барсик", 4)
        };

        foreach (var animal in animals)
        {
            animal.Speak();
        }
    }
}
