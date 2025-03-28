using System;

class ResourceHolder : IDisposable
{
    private bool disposed = false;

    public ResourceHolder()
    {
        Console.WriteLine("Ресурс создан.");
    }

    public void UseResource()
    {
        if (disposed)
            throw new ObjectDisposedException("ResourceHolder");

        Console.WriteLine("Использование ресурса.");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                Console.WriteLine("Освобождение управляемых ресурсов.");
            }

            Console.WriteLine("Освобождение неуправляемых ресурсов.");
            disposed = true;
        }
    }

    ~ResourceHolder()
    {
        Dispose(false);
    }
}

class Program
{
    static void Main()
    {
        using (ResourceHolder resource = new ResourceHolder())
        {
            resource.UseResource();
        }

        Console.WriteLine("Ресурс автоматически освобождён после блока using.");
    }
}
