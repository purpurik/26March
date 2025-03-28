using System;
using System.Collections.Generic;

interface IPrintable
{
    string Print();
}

class Document : IPrintable
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Document(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public string Print()
    {
        return $"Документ: {Title}\nСодержимое: {Content}";
    }
}

class Report : IPrintable
{
    public string Name { get; set; }
    public DateTime Date { get; set; }

    public Report(string name, DateTime date)
    {
        Name = name;
        Date = date;
    }

    public string Print()
    {
        return $"Отчет: {Name}\nДата: {Date.ToShortDateString()}";
    }
}

class Program
{
    static void Main()
    {
        List<IPrintable> printables = new List<IPrintable>
        {
            new Document("Договор", "Стороны обязуются..."),
            new Report("Годовой отчет", DateTime.Now)
        };

        foreach (var printable in printables)
        {
            Console.WriteLine(printable.Print());
            Console.WriteLine();
        }
    }
}
