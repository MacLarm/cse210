public class Resume
{
    private string _name;
    public List<Job> _jobs = new List<Job>();

    public Resume(string name)
    {
        _name = name;
    }

    public void DisplayResume()
    {
        foreach(Job j in _jobs)
        {
            j.Display();
        }
    }
}