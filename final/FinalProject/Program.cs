using System;
using System.Diagnostics;
using System.Net.Quic;

string userInput = "";
string name = "";
string saveLocation = "";
bool conditionsMet = false;
Cookbook cookbook = new Cookbook();
while(!conditionsMet)
{
    Console.Clear();
    Console.WriteLine("Welcome to your Digital Cookbook!");
    Console.WriteLine("Please select from the following options.");
    Console.WriteLine("1. Open Cookbook");
    Console.WriteLine("2. Create new Cookbook");
    Console.WriteLine("3. Exit Program");
    userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            Console.Write("Which cookbook would you like? ");
            name = Console.ReadLine();
            saveLocation = name + ".txt";
            cookbook.LoadCookbook(name, saveLocation);
            conditionsMet = true;
            break;
        case "2":
            Console.Write("What will you call this cookbook? ");
            name = Console.ReadLine();
            saveLocation = name + ".txt";
            cookbook = new Cookbook(name, saveLocation);
            conditionsMet = true;
            break;
        case "3":
            Console.WriteLine("Thank you for using the Digital Cookbook.");
            return; //ends the program.
        default:
            Console.WriteLine("Enter a valid option");
            Thread.Sleep(1500);
            break;
    }
}

//Cookbook cookbook = new Cookbook(name, saveLocation);

while(userInput != "quit")
{
    Console.Clear();
    Console.WriteLine("Select from the following options:");
    Console.WriteLine("1. Select recipe");
    Console.WriteLine("2. Review recipies");
    Console.WriteLine("3. Add recipe");
    Console.WriteLine("4. Delete recipe");
    Console.WriteLine("5. Exit Program");
    userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            Console.Clear();
            cookbook.SelectRecipe();
            break;
        case "2":
            Console.Clear();
            cookbook.DisplayRecipies();
            Console.WriteLine();
            Console.WriteLine("Press enter when you are ready to move on.");
            Console.ReadLine();
            break;
        case "3":
            Console.Clear();
            cookbook.AddRecipe();
            cookbook.SaveCookbook();
            break;
        case "4":
            Console.Clear();
            cookbook.DeleteRecipe();
            break;
        case "5":
            Console.Clear();
            cookbook.SaveCookbook();
            Console.WriteLine("Thank you for using the Digital Cookbook.");
            return; //ends the program.
        default:
            Console.WriteLine("Enter a valid option");
            Thread.Sleep(1500);
            break;
    }

}