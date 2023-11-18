using System.Diagnostics;
using System.IO;

public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>();
    private Level _level = new Level();

    public void DisplayLevel()
    {
        _level.DisplayPoints();
    }

    public void CreateNewGoal()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple goal");
        Console.WriteLine("  2. Eternal goal");
        Console.WriteLine("  3. Checklist goal");
        Console.WriteLine();
        Console.Write("Which type of goal would you like to create? ");
        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                BasicGoal basicGoal = new BasicGoal();
                basicGoal.CreateGoal();
                _goals.Add(basicGoal);
                break;
            case "2":
                Goal goal = new Goal();
                goal.CreateGoal();
                _goals.Add(goal);
                break;
            case "3":
                ChecklistGoal cGoal = new ChecklistGoal();
                cGoal.CreateGoal();
                _goals.Add(cGoal);
                break;
            default:
                break;
        }
    }

    public void DisplayGoals()
    {
        int index = 1;
        Console.WriteLine();
        foreach(Goal g in _goals)
        {
            Console.Write(index + ". ");
            g.DisplayGoal();
            index ++;
        }
    }

    public void CompleteGoal()
    {
        DisplayGoals();
        Console.WriteLine();
        Console.Write("Which goal would you like to complete? ");
        int userInput = Int32.Parse(Console.ReadLine());
        _level.AddPoints(_goals[userInput - 1].CompleteGoal());
    }

    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            outputFile.WriteLine(_level.StringifyLevel());
            foreach(Goal g in _goals)
            {
                outputFile.WriteLine(g.StringifyGoal());
            }
        }
    }

    public void LoadGoals()
    {
        string[] lines = System.IO.File.ReadAllLines("goals.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string type = parts[0];
            string title = parts[1];
            string description = parts[2];
            int points = Int32.Parse(parts[3]);

            switch (type)
            {
                case "Level":
                    int currentPoints = Int32.Parse(parts[1]);
                    int totalPoints = Int32.Parse(parts[2]);
                    int level = Int32.Parse(parts[3]);
                    _level = new Level(currentPoints, totalPoints, level);
                    break;
                case "Basic Goal":
                    bool completed = Boolean.Parse(parts[4]);
                    BasicGoal bGoal = new BasicGoal(title, description, points, completed);
                    _goals.Add(bGoal);
                    break;
                case "Eternal Goal":
                    Goal goal = new Goal(title, description, points);
                    _goals.Add(goal);
                    break;
                case "Checklist Goal":
                    int timesDone = Int32.Parse(parts[4]);
                    int finishedPoints = Int32.Parse(parts[5]);
                    int repetitions = Int32.Parse(parts[6]);
                    ChecklistGoal cGoal = new ChecklistGoal(title, description, points, finishedPoints, repetitions, timesDone);
                    _goals.Add(cGoal);
                    break;
                default:
                    break;
            }
        }
    }
}