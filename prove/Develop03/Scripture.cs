public class Scripture
{
    private Reference _reference;
    private List<Word> _verses = new List<Word>();

    public Scripture(Reference reference, string verse) 
    {
        _reference = reference;

        string[] verses = verse.Split(" ");
        foreach (string word in verses)
        {
            _verses.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine();
        _reference.Display();
        Console.WriteLine();
        foreach (Word word in _verses)
        {
            word.Display();
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    public void HideWords(int numberHidden)
    {
        for (int i = 0; i < numberHidden; i++)
        {
            var random = new Random();
            int index = random.Next(_verses.Count);
            while (_verses[index].IsHidden())
            {
                index = random.Next(_verses.Count);
            }
            _verses[index].HideWord();
        }
    }

    public bool AllHidden()
    {
        bool allHidden = true;
        foreach (Word word in _verses)
        {
            if (!word.IsHidden())
            {
                allHidden = false;
                break;            
            }
        }
        return allHidden;
    }
}