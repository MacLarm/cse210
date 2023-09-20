using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter as many numbers as you would like, when you are done, enter '0'. ");
        List<int> numbers = new List<int>();
        int userNumber;
        do {
            userNumber = int.Parse(Console.ReadLine());
            numbers.Add(userNumber);

        } while (userNumber != 0);

        Console.WriteLine(userNumber);
    }
}