public class Entry
{
    public (string, string, string) CreateEntry()
    {
        string date = DateTime.Now.ToString("mm/dd/yyy");
        Prompt passer = new Prompt();
        string prompt = passer.GetPrompt();
        Console.WriteLine(date);
        Console.WriteLine(prompt);
        Console.Write(">");
        string text = System.Console.ReadLine();
        return (date,prompt,text);
    }

}