using System.Text.RegularExpressions;

public class Word
{
    private string _word;
    private string _hiddenWord;
    private bool _isHidden = false;

    public Word(string word)
    {
        _word = word;
        _hiddenWord = Regex.Replace(_word, "[a-zA-Z]","_");        
    }

    public void Display()
    {
        if (_isHidden)
        {
            Console.Write($"{_hiddenWord} ");
        }
        else 
        {
            Console.Write($"{_word} ");
        }
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}