public class Activity
{
    protected string _name;
    protected string _description;
    private int _time;

    public Activity(int time)
    {
        _time = time;
    }

    public void DisplayTime()
    {
        Console.WriteLine(_time);
    }

    public void TimerAnimation()
    {
        
    }
}