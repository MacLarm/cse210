public class Activity
{
    protected string _name;
    protected string _description;
    protected int _time;
    private int _timesPracticed;

    public void WelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void EndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Console.WriteLine($"You completed another {_time} seconds of {_name}.");
        Console.WriteLine();
        TimerAnimation();
    }

    public void Summary()
    {
        if (_timesPracticed > 0)
        {
            Console.WriteLine($"You completed {_name} {_timesPracticed} times.");
        }
        else
        {
            Console.WriteLine($"You did not practice {_name} this time.");
        }
    }

    public void SetTime()
    {
        Console.WriteLine("How long in seconds would you like to do this activity? ");
        string userInput = Console.ReadLine();
        int time = Convert.ToInt32(userInput);
        _time = time;
    }

    public void TimerAnimation(int speed = 200, int repetitions = 24)
    {
        //°º¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤º°`°º¤ø,¸
        string[] symbol = {
        "¸", ",", "ø", "¤", "º", "°", "`", "°", "º", "¤", "ø", ",", "¸",        
        "¸", ",", "ø", "¤", "º", "°", "`", "°", "º", "¤", "ø", ",", "¸",
        "¸", ",", "ø", "¤", "º", "°", "`", "°", "º", "¤", "ø", ",", "¸",
        "¸", ",", "ø", "¤", "º", "°", "`", "°", "º", "¤", "ø", ",", "¸",
        "¸", ",", "ø", "¤", "º", "°", "`", "°", "º", "¤", "ø", ",", "¸"};

        for(int i = repetitions; i > 0; i --)
        {
            Console.Write(symbol[0+i] + symbol[1+i] + symbol[2+i] + symbol[3+i] + symbol[4+i] +
            symbol[5+i] + symbol[6+i] + symbol[7+i] + symbol[8+i] + symbol[9+i] + symbol[10+i] +
            symbol[11+i] + symbol[12+i] + " ");
            Thread.Sleep(speed);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        } 
    }

    public void ShowRandomPrompt(List<string> prompts)
    //Selects a random prompt and displays it with some styling.
    {
        Console.Clear();

        var random = new Random();
        int index = random.Next(prompts.Count);
        Console.WriteLine(prompts[index]);

        //makes a line under the prompt that is the same length as the prompt.
        foreach(char i in prompts[index])
        {
            Console.Write("-");
        }

        Console.WriteLine();
    }

    public void AddPractice()
    {
        _timesPracticed += 1;
    }
}
