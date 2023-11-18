using System;

string userInput = "";
GoalTracker user = new GoalTracker();

while (userInput != "6")
{
    Console.WriteLine();
    user.DisplayLevel();
    //Console.WriteLine($"You have {user.DisplayPoints()} points");
    Console.WriteLine();
    Console.WriteLine("Menu Options:");
    Console.WriteLine("  1. Create New Goal");
    Console.WriteLine("  2. List Goals");
    Console.WriteLine("  3. Save Goals");
    Console.WriteLine("  4. Load Goals");
    Console.WriteLine("  5. Record Event");
    Console.WriteLine("  6. Quit");
    Console.WriteLine();
    Console.Write("Select a choice from the menu  ");
    userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            user.CreateNewGoal();
            break;
        case "2":
            user.DisplayGoals();
            break;
        case "3":
            user.SaveGoals();
            break;
        case "4":
            user.LoadGoals();
            break;
        case "5":
            user.CompleteGoal();
            break;
        case "6":
            Console.WriteLine("Thank you for using GoalTracker!");
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
}