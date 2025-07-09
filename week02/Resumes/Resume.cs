using System;

public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        
        foreach (Job job in _jobs)
        {
        Console.WriteLine($"Name: {_name}"); 
        Console.WriteLine("Jobs:");
        Console.WriteLine($"{job._jobTitle} ({job._company}) {job._startYear}-{job._endYear}");
        }
    }
}