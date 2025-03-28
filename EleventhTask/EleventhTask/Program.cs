using System;

interface ILogging
{
    void LogMessage(string message)
    {
        Console.WriteLine($"Стандартный лог: {message}");
    }
}

class Logger : ILogging
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"Переопределённый лог: {message}");
    }
}

class Program
{
    static void Main()
    {
        ILogging defaultLogger = new DefaultLogger();
        defaultLogger.LogMessage("Используется стандартная реализация");

        ILogging customLogger = new Logger();
        customLogger.LogMessage("Используется переопределённая реализация");
    }
}

class DefaultLogger : ILogging { }
