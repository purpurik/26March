using System;
using System.Collections.Generic;
using System.Linq;

class Repository<T>
{
    private readonly List<T> _items = new List<T>();

    public void Add(T item) => _items.Add(item);
    public void Remove(T item) => _items.Remove(item);
    public T Find(Predicate<T> match) => _items.Find(match);
    public void DisplayAll() => _items.ForEach(item => Console.WriteLine(item?.ToString()));
}

class Product
{
    public string Name { get; }
    public decimal Price { get; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString() => $"Product: {Name}, Price: {Price:C}";
}

class Customer
{
    public string Name { get; }
    public int Age { get; }

    public Customer(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString() => $"Customer: {Name}, Age: {Age}";
}

class Program
{
    static void Main()
    {
        var productRepo = new Repository<Product>();
        productRepo.Add(new Product("Laptop", 1200));
        productRepo.Add(new Product("Mouse", 25));
        productRepo.DisplayAll();

        var customerRepo = new Repository<Customer>();
        customerRepo.Add(new Customer("Alice", 30));
        customerRepo.Add(new Customer("Bob", 25));
        customerRepo.DisplayAll();
    }
}
