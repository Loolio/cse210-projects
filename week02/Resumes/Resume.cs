using System;

public class Resume
{
    public string _name;

    // Initialize new list  
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Use for each loop to iterate through the list of jobs 
        foreach (Job job in _jobs)
        {
            // Diplay method for each job
            job.Display();
        }
    }
}