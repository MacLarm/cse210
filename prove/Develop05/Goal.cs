using System.ComponentModel;

public class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;

    public Goal()
    {}

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    public virtual void CreateGoal()
    {
        AddTitle();
        AddDescription();
        AddPoints();
    }

    public void AddTitle()
    {
        Console.Write("Enter a title for your goal: ");
        string title = Console.ReadLine();
        _title = title;
    }

    public void AddDescription()
    {
        Console.Write("Enter a description for your goal: ");
        string description = Console.ReadLine();
        _description = description;
    }

    public virtual void AddPoints()
    {
        Console.Write("Enter a points value for your goal: ");
        int points = Int32.Parse(Console.ReadLine());
        _points = points;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_title}: {_description}");
    }

    public virtual int CompleteGoal()
    {
        return _points;
    }

    public virtual string StringifyGoal()
    {
        // index     0            1           2            3
        return $"Eternal Goal|{_title}|{_description}|{_points}";
    }
}