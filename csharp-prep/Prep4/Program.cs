using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter as many numbers as you would like, when you are done, enter '0'. ");
        List<int> Numbers = new List<int>();
        int userInput;
        do {
            userInput = int.Parse(Console.ReadLine());
            Numbers.Add(userInput);

        } while (userInput != 0);

        Console.WriteLine(Numbers);
    }
}