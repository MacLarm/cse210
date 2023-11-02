public class Breathing : Activity
{

    public Breathing(int time) :base(time)
    {
        _name = "whatever";
        _description = "yeah";
    }

    public void display()
    {
        Console.WriteLine($"{_name}, {_description},");
    }
}