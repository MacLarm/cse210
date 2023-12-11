public class Instruction
{
    private string _step;
    private bool _isCompleted;

    public Instruction (string step)
    {
        _step = step;
        _isCompleted = false;
    }

    public void DisplayInstruction()
    {
        if(_isCompleted)
        {
            Console.WriteLine($"[X] {_step} ");
        }
        else
        {
            Console.WriteLine($"[ ] {_step} ");
        }
    }

    public bool CheckCompleted()
    {
        return _isCompleted;
    }

    public void CompleteStep()
    {
        _isCompleted = true;
    }

    public void UncompleteStep()
    {
        _isCompleted = false;
    }

    public string StringifyInstruction()
    {
        return _step;
    }
}