using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter as many numbers as you would like, when you are done, enter '0'. ");
        List<int> numbers = new List<int>();
        int userInput;
        int total = 0;
        int largestNum = 0;
        do {
            userInput = int.Parse(Console.ReadLine());
            numbers.Add(userInput);

        } while (userInput != 0);

        foreach (int number in numbers)
        {
            total += number;

            if (number > largestNum)
            {
                largestNum = number;
            }
        }
        int average = total/ (numbers.Count - 1);
        Console.WriteLine($"the sum is {total}");
        Console.WriteLine($"the average is {average}");
        Console.WriteLine($"the largest number is {largestNum}");
        
    }
}