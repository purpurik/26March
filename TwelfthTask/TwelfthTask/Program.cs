using System;

interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

class Duck : IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("Утка летит.");
    }

    public void Swim()
    {
        Console.WriteLine("Утка плывёт.");
    }
}

class Program
{
    static void Main()
    {
        Duck duck = new Duck();

        IFlyable flyingDuck = duck;
        ISwimmable swimmingDuck = duck;

        flyingDuck.Fly();
        swimmingDuck.Swim();
    }
}
