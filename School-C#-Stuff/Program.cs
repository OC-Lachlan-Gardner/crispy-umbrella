using System.Runtime.InteropServices;

class Book
{
    public string Title;

    public string Author;

    public int Pages;

    public Book(string bookTitle, string bookAuthor, int bookPages)
    {
        Title = bookTitle;

        Author = bookAuthor;

        Pages = bookPages;
    }

    public string summary()
    {
        return $"{Title} by {Author} is {Pages} pages long";
    }
}

class Program
{
    public static string BookSummary(Book book)
    {
        return $"{book.Title} by {book.Author} is {book.Pages} pages long";   
    }
    static void Main(string[] args)
    {
        Book vicious = new Book("Vicious", "V. E. Schwab", 402);

        Book vengeful = new Book("Vengeful", "V. E. Schwab", 462);

        Console.WriteLine(BookSummary(vicious));

        Console.WriteLine(vengeful.summary());

        // The instance method looks a lot cleaner because it contains the function within itself, since it is useless outside of that context..
    }
}