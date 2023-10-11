public class Book
{
    private string _author;
    private string _name;
    private int _timesRead;
    private bool _available;

    public Book(string author, string name)  
    {
        _author = author;
        _name = name;
        _timesRead = 0;
        _available = true;
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Author:     {_author}");
        Console.WriteLine($"Title:      {_name}");
        Console.WriteLine($"Times read: {_timesRead}");
        Console.WriteLine($"Available:  {_available}");
        Console.WriteLine();
    }

    public void CheckOut()
    {
        _timesRead ++;
        _available = false;
    }
    public void CheckIn()
    {
        _available = true;
    }

    public bool HasAuthor(string author)
    {
        return _author.Contains(author);
    }
}