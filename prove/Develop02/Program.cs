using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> entries= new List<string>();
        int userInput = 0;
        while (userInput < 6)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal program!");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Add a prompt");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            userInput = Int32.Parse(System.Console.ReadLine());
            Console.WriteLine();
            Journal passage = new Journal();
            Entry myEntry = new Entry();
            Prompt myPrompt = new Prompt();
            switch (userInput)
            {
                case 1: 
                    (string,string,string) entryLines = myEntry.CreateEntry();
                    entries.Add(entryLines.Item1);
                    entries.Add(entryLines.Item2);
                    entries.Add(entryLines.Item3);
                    entries.Add("");
                    break;
                case 2:
                    foreach (string entry in entries)
                    {
                        Console.WriteLine(entry); 
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("What file would you like to Load?");
                    Console.Write(">");
                    string filename = Console.ReadLine();
                    passage.Load(filename,entries);
                    break;
                case 4:
                    Console.WriteLine("Where would you like to save your entries?");
                    Console.Write(">");
                    filename = Console.ReadLine();
                    passage.Load(filename,entries);
                    passage.Save("journal.txt",entries);
                    break;
                case 5:
                    Console.WriteLine("Please enter the prompt you would like to add");
                    string newPrompt = Console.ReadLine();
                    myPrompt.addPrompt(newPrompt);
                    break;
                default:
                    break;

            }       
        }
    }
}