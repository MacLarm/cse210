using System;
using System.Collections;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        Breathing breath = new Breathing();
        Reflect reflect = new Reflect();
        Listing listing = new Listing();
        while (userInput != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Breathing activity");
            Console.WriteLine("2. Reflecting activity");
            Console.WriteLine("3. Listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Enter the number of the activity you would like to do: ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    breath.PracticeBreathing();
                    break;
                case "2":
                    reflect.PracticeReflect();
                    break;
                case "3":
                    listing.PracticeListing();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Thank you for using the mindfulness program");
                    breath.Summary();
                    reflect.Summary();
                    listing.Summary();
                    break;
                default:
                    Console.WriteLine("please enter a number 1-4");
                    Thread.Sleep(3000);
                    break;
            }
        }
    }
}