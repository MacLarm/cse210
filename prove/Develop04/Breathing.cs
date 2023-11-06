public class Breathing : Activity
{
    private int _breaths = 0;
    public Breathing()
    {
        _name = "Breathing";
        _description = "This activity will walk you through breaathing exercises, clear your mind and follow the directions.";
    }

    public void PracticeBreathing()
    {
        WelcomeMessage();
        SetTime();
        Console.WriteLine("Get ready..");
        TimerAnimation();

        DateTime endTime = DateTime.Now.AddSeconds(_time);
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            BreathIn();
            BreathOut();
            currentTime = DateTime.Now;
            _breaths += 1;
        }
        Console.WriteLine();
        EndingMessage();
        AddPractice();
    }

    private void BreathIn()
    {
        int time = 700;
        Console.Clear();
        Console.WriteLine("Breath in");
        Console.Write(
            "* * * * * ");
        Thread.Sleep(time);
        Console.Write("\b\b\b\b\b\b\b\b\b\b" + 
            "0 * * * * ");
        Thread.Sleep(time);
        Console.Write("\b\b\b\b\b\b\b\b\b\b" + 
            "0 0 * * * ");
        Thread.Sleep(time);
        Console.Write("\b\b\b\b\b\b\b\b\b\b" + 
            "0 0 0 * * ");
        Thread.Sleep(time);
        Console.Write("\b\b\b\b\b\b\b\b\b\b" + 
            "0 0 0 0 * ");
        Thread.Sleep(time);
        Console.Write("\b\b\b\b\b\b\b\b\b\b" + 
            "0 0 0 0 0 ");
        Thread.Sleep(time);
        Console.WriteLine();
    }

    private void BreathOut()
    {
        int time = 700;
        Console.Clear();
        Console.WriteLine("Breath out");
        Console.Write(
            "0 0 0 0 0 ");
        Thread.Sleep(time);
        Console.Write("\b\b\b\b\b\b\b\b\b\b" + 
            "0 0 0 0 * ");
        Thread.Sleep(time);
        Console.Write("\b\b\b\b\b\b\b\b\b\b" + 
            "0 0 0 * * ");
        Thread.Sleep(time);
        Console.Write("\b\b\b\b\b\b\b\b\b\b" + 
            "0 0 * * * ");
        Thread.Sleep(time);
        Console.Write("\b\b\b\b\b\b\b\b\b\b" + 
            "0 * * * * ");
        Thread.Sleep(time);
        Console.Write("\b\b\b\b\b\b\b\b\b\b" + 
            "* * * * * ");
        Thread.Sleep(time);
        Console.WriteLine();
    }
}