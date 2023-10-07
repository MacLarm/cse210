using System.IO;

public class Journal
{
    private List<string> _entries = new List<string>();

    public void Save(string filename,List<string> entries)
    {
        Console.WriteLine("Saving to file....");
        string[] inFile = System.IO.File.ReadAllLines(filename);
        List<string> lines = inFile.ToList();;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(string entry in entries)
            {
                lines.Add(entry);
            }
            foreach(string line in lines)
            {
                outputFile.WriteLine(line);
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