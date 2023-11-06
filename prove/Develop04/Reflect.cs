public class Reflect : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflect()
    {
        _name = "Reflect";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
    }

    public void PracticeReflect()
    {
        WelcomeMessage();
        SetTime();
        ShowRandomPrompt(_prompts);

        Console.WriteLine("Think of an experience and press enter when you are ready...");
        string userInput = "!";
        while(userInput != "")
        {
            userInput = Console.ReadLine();
        }
        
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            ShowQuestions();
            TimerAnimation(175,26);
            currentTime = DateTime.Now;
        }

        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                 ");
        Console.WriteLine();
        EndingMessage();
        AddPractice();
    }

    public void ShowQuestions()
    {
        var random = new Random();
        int index = random.Next(_questions.Count);
        Console.WriteLine(_questions[index]);
        Console.WriteLine();
    }
}