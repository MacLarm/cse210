public class SmartDevice
{
    protected bool _isOn = false;
    protected DateTime _time;
    private string _name;

    public SmartDevice(string name)
    {
        _name = name;
    }

    public void TurnOn()
    {
        _isOn = true;
        _time = DateTime.Now;
        string time = _time.ToString("h:mm tt");
        Console.WriteLine($"{_name} turned on at {time}");
    }

    public void TurnOff()
    {
        _isOn = false;
        CheckTime();
        _time = DateTime.Now;
    }

    public void CheckTime()
    {
        TimeSpan timeElapsed = DateTime.Now - _time;
        Console.WriteLine($"{_name} was on for {timeElapsed}");
    }

    public void CheckStatus()
    {
        if(_isOn)
        {
            Console.WriteLine($"{_name} is on");
        }
        else
        {
            Console.WriteLine($"{_name} is off");
        }
    }
}