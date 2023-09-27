using System;

public class Resume

{
    public string Name;
    public List<Job> Jobs = new List<Job>();

    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in Jobs)
        {
            job.Show();
        }
    }

    public Resume()
    {
        
    }      
}