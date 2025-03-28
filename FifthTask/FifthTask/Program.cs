using System;

delegate int ArithmeticOperation(int a, int b);

class Program
{
    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;

    static void Main()
    {
        ArithmeticOperation operation;

        Console.WriteLine("Выберите операцию: 1 - Сложение, 2 - Вычитание, 3 - Умножение");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                operation = Add;
                break;
            case "2":
                operation = Subtract;
                break;
            case "3":
                operation = Multiply;
                break;
            default:
                Console.WriteLine("Неверный выбор!");
                return;
        }

        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        int result = operation(num1, num2);
        Console.WriteLine($"Результат: {result}");
    }
}
