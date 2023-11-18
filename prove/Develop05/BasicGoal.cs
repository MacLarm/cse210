public class BasicGoal : Goal
{
    private bool _completed = false;

    public BasicGoal() 
    {}

    public BasicGoal(string title, string description, int points, bool completed) :base(title, description, points)
    {
        _completed = completed;
    }

    public override void DisplayGoal()
    {
        if (_completed)
        {
            Console.WriteLine($"[x] {_title}: {_description}");
        }
        else
        {
            Console.WriteLine($"[ ] {_title}: {_description}");
        }
    }

    public override string StringifyGoal()
    {
        //  index 0            1           2            3           4
        return $"Basic Goal|{_title}|{_description}|{_points}|{_completed}";
    }

    public override int CompleteGoal()
    {
        _completed = true;
        return _points;
    }
}