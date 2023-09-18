using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess;
        int numberOfGuesses = 0;
        do 
        {
            Console.Write("what is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            numberOfGuesses += 1;

        } while (guess != magicNumber); 

        Console.WriteLine($"You took {numberOfGuesses} guesses");
    }
}