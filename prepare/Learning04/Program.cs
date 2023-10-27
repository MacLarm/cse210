using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment sam = new Assignment("Sam","Multiplication");
        string summary = sam.GetSummary();
        Console.WriteLine(summary);

        MathAssignment rod = new MathAssignment("Rod", "Fractions", "7.3", "8-19");
        summary = rod.GetSummary();
        string homework = rod.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(homework);

        WritingAssignment matt = new WritingAssignment("matt", "US History", "Gettysburg");
        summary = matt.GetSummary();
        homework = matt.GetWritingInformation();
        Console.WriteLine(summary);
        Console.WriteLine(homework);
    }
}