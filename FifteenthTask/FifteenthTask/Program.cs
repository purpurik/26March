using System;

class Vehicle
{
    public virtual string Describe()
    {
        return "Это транспортное средство.";
    }
}

class Car : Vehicle
{
    public override string Describe()
    {
        return base.Describe() + " Это легковой автомобиль.";
    }
}

class Truck : Vehicle
{
    public override string Describe()
    {
        return base.Describe() + " Это грузовик.";
    }
}

class Program
{
    static void Main()
    {
        Vehicle car = new Car();
        Vehicle truck = new Truck();

        Console.WriteLine(car.Describe());
        Console.WriteLine(truck.Describe());
    }
}
