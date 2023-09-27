// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Learning02 World!");
//     }
// }

using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1.CompanyName = "BYUI";
        job1.JobTitle = "Technician";
        job1.StartYear = 2020;
        job1.EndYear= 2024;

        Job job2 = new Job();
        
        job2.CompanyName = "McDonalds";
        job2.JobTitle = "Seasonal Employee";
        job2.StartYear = 2025;
        job2.EndYear = 2026;

        Resume myResume = new Resume();
        myResume.Name = "Tony Stark";
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        myResume.Show();
    }
}