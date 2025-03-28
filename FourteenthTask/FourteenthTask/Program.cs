using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    delegate IEnumerable<int> DataProcessor(IEnumerable<int> numbers);

    static void ProcessData(IEnumerable<int> numbers, DataProcessor processor)
    {
        var result = processor(numbers);
        Console.WriteLine("Результат обработки: " + string.Join(", ", result));
    }

    static void Main()
    {
        List<int> data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        ProcessData(data, nums => nums.Where(n => n % 2 == 0));
        ProcessData(data, nums => nums.Select(n => n * n));
    }
}
