using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Maneger","Microsoft",2020,2021);
        //job1.Display();
        Job job2 = new Job("Janitor","bucky's",2018,2020);

        Resume myResume = new Resume("Bill Billbert");
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.DisplayResume();
    }
}