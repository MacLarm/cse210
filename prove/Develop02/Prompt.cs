public class Prompt 
{
    private List<string> _prompts = new List<string>();
    
    public void PresetPrompt()
    {
        _prompts.Add("What was a tender mercy you saw today?");
        _prompts.Add("What was something that made you smile?");
        _prompts.Add("What is something you are proud of today?");
    }

    public string GetPrompt()
    {
        PresetPrompt();
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}