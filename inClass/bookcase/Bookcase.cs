public class Bookcase
{
    private List<Book> _books;

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void DisplayBookcase()
    {
        Console.WriteLine($"{_books.Count}");
    }
}