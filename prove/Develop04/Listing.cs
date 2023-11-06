public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private int _itemsListed;
    public Listing()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void PracticeListing()
    {
        WelcomeMessage();
        SetTime();
        ShowRandomPrompt(_prompts);

        Console.WriteLine("Get ready...");
        TimerAnimation();
        //this clears timer animation.
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                 ");
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_time);
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            _itemsListed += ListItem();
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_itemsListed} things");
        TimerAnimation();
        EndingMessage();
        AddPractice();
    }

    public int ListItem()
    {
        Console.ReadLine();
        return 1;
    }
}