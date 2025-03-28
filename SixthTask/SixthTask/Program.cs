using System;
using System.Timers;

class TimerEvent
{
    private readonly System.Timers.Timer _timer;
    public event EventHandler TimeElapsed;

    public TimerEvent(double interval)
    {
        _timer = new System.Timers.Timer(interval);
        _timer.Elapsed += OnTimeElapsed;
    }

    public void Start() => _timer.Start();
    public void Stop() => _timer.Stop();

    private void OnTimeElapsed(object sender, ElapsedEventArgs e)
    {
        TimeElapsed?.Invoke(this, EventArgs.Empty);
    }
}

class Subscriber
{
    public void OnTimeElapsed(object sender, EventArgs e)
    {
        Console.WriteLine("Событие: Время истекло!");
    }
}

class Program
{
    static void Main()
    {
        TimerEvent timerEvent = new TimerEvent(2000);
        Subscriber subscriber = new Subscriber();

        timerEvent.TimeElapsed += subscriber.OnTimeElapsed;
        Console.WriteLine("Таймер запущен. Нажмите Enter для остановки.");
        timerEvent.Start();

        Console.ReadLine();
        timerEvent.Stop();
        timerEvent.TimeElapsed -= subscriber.OnTimeElapsed;
        Console.WriteLine("Таймер остановлен.");
    }
}
