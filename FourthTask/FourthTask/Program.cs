using System;
using System.Collections.Generic;

class Book
{
    public string ISBN { get; }
    public string Title { get; }
    public string Author { get; }

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    public override bool Equals(object obj)
    {
        if (obj is Book otherBook)
        {
            return ISBN == otherBook.ISBN;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return ISBN.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        var book1 = new Book("978-3-16-148410-0", "Book One", "Author A");
        var book2 = new Book("978-3-16-148410-0", "Duplicate Book", "Author B");
        var book3 = new Book("978-1-23-456789-7", "Book Two", "Author C");

        Console.WriteLine(book1.Equals(book2)); // True
        Console.WriteLine(book1.Equals(book3)); // False

        HashSet<Book> books = new HashSet<Book> { book1, book2, book3 };
        Console.WriteLine($"Количество книг в HashSet: {books.Count}"); // 2, так как book1 и book2 считаются одинаковыми
    }
}
