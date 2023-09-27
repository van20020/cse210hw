using System;
public class Job

{
    public string CompanyName;
    public string JobTitle;
    public int StartYear;
    public int EndYear;
    public void Show()
    {
        Console.WriteLine($"{JobTitle} ({CompanyName}) {StartYear}-{EndYear}");
    }

    public Job()
    {
        
    }      
}