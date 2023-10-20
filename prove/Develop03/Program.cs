using System;

class Program
{
    static void Main(string[] args)
    {
        Reference nephi = new Reference("2 Nephi","1","29");
        Scripture blessings = new Scripture(nephi,"But if ye will not hearken unto him I take away my first blessing, yea, even my blessing, and it shall rest upon him.");
        string userInput = "";
        while (userInput != "quit")
        {
            Console.Clear();
            blessings.Display();
            Console.WriteLine("Press enter to remove a word or type 'quit' to exit: ");
            userInput = Console.ReadLine();
            blessings.HideWords(2);
            if (blessings.AllHidden())
            {
                Console.Clear();
                blessings.Display();
                break;
            }
        }
    }
}