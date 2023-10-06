using System.IO;

public class Journal
{
    private List<string> _entries = new List<string>();

    public void Save(string filename,List<string> entries)
    {
        Console.WriteLine("Saving to file....");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(string entry in entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
    public void Load(string filename,List<string> entries)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}