public class ChecklistGoal : Goal
{
    private int _finishedPoints;
    private int _repetitions;
    private int _timesDone;

    public ChecklistGoal() {}

    public ChecklistGoal(string title, string description, int points, 
    int finishedPoints, int repetitions, int timesDone) :base(title, description, points)
    {
        _finishedPoints = finishedPoints;
        _repetitions = repetitions;
        _timesDone = timesDone;
    }

    public override void CreateGoal()
    {
        AddTitle();
        AddDescription();
        SetRepetitions();
        AddPoints();
    }

    public void SetRepetitions()
    {
        Console.Write("How many times will you complete this goal? ");
        int repetitions = Int32.Parse(Console.ReadLine());
        _repetitions = repetitions;
    }

    public override void AddPoints()
    {
        Console.Write("How many points will you get for each time you do this? ");
        int points = Int32.Parse(Console.ReadLine());
        Console.Write("How many points will you get when you finish the goal? ");
        int finishedPoints = Int32.Parse(Console.ReadLine());
        _points = points;
        _finishedPoints = finishedPoints;
    }

    public override void DisplayGoal()
    {   
        if (_timesDone == _repetitions)
        {
            Console.WriteLine($"[x] {_title}: {_description}, {_timesDone}/{_repetitions}");
        }
        else
        {
            Console.WriteLine($"[ ] {_title}: {_description}, {_timesDone}/{_repetitions}");
        }
    }

    public override int CompleteGoal()
    {
        _timesDone ++;

        if (_timesDone == _repetitions)
        {
            return _points + _finishedPoints;
        }
        else
        {
            return _points;
        }
    }

    public override string StringifyGoal()
    {
        //  index     0            1            2          3           4               5               6
        return $"Checklist Goal|{_title}|{_description}|{_points}|{_timesDone}|{_finishedPoints}|{_repetitions}";
    }
}