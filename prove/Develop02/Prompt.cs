using System.IO;

public class Prompt 
{
    private List<string> _prompts = new List<string>();
    
    public void PresetPrompt()
    {
        string[] lines = System.IO.File.ReadAllLines("Prompt.txt");
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
    }

    public void addPrompt(string prompt)
    {
        Console.WriteLine("Saving to file....");
        string[] inFile = System.IO.File.ReadAllLines("Prompt.txt");
        List<string> lines = inFile.ToList();
        lines.Add(prompt);
        using (StreamWriter outputFile = new StreamWriter("Prompt.txt"))
        {
            foreach (string line in lines)
            {
                outputFile.WriteLine(line);
            }
        }
    }
    public string GetPrompt()
    {
        PresetPrompt();
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}