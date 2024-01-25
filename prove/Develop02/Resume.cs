using System;
public class Resume
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Past Jobs:");

        foreach (Job job in jobs)
        {
            job.JobSummary();
        }
    }
}