using System.Reflection;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verses;

    public Reference(string book, string chapter, string verses)
    {
        _book = book;
        _chapter = chapter;
        _verses = verses;
    }

    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verses}");
    }
}