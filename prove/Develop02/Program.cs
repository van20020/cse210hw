using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //TODO:
        // Create a Journal Object
        // Prompt the User with menu

        List<string> prompts = new List<string>();

        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        // if user picks option to add a new entry
        

        // 1. Pick a random prompt from list above.
        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Count);

        string selectedPrompt = prompts[randomIndex];

        // 2. Display the random selected prompt.
        Console.WriteLine($"Journal Prompt: {selectedPrompt}");
        // 3. Save response from user
        // 4. Create Response Object
        Console.Write("Your Entry: ");
        string Entry = Console.ReadLine();

        // 5. Save Response object to Journal Object

        Entry entry = new Entry();
        entry.EntryDate = DateTime.Now.ToShortDateString();
        entry.Prompt = selectedPrompt; // from prompt above 
        entry.Response = Entry; // pull from user's response

        Journal journal = new Journal();
        journal.JournalName = ""; // ask user for name
        journal.Entries = new List<Entry>();
        journal.Entries.Add(entry);



        List<Entry> entries = new List<Entry>();
        entries.Add(entry);

        foreach (Entry e in entries)
        {
            Console.WriteLine(e.Response);
        }

        SaveToFile(entries);



        List<Entry> newEntries = ReadFromFile();
        foreach (Entry e in newEntries)
        {
            Console.WriteLine(e.Response);
        }

    }


    // save jorunal to file system

    public static void SaveToFile(List<Entry> entries)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 10000000);

        Console.WriteLine("Saving to file...");

        string filename = "entries.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in entries)
            {
                outputFile.WriteLine($"Today's Date: {e.EntryDate}\nToday's Prompt: {e.Prompt}\nYour Response: {e.Response}\nLucky Number of the Day: {randomNumber}");
            }
        }
    }

    public static List<Entry> ReadFromFile()
    {
        Console.WriteLine("Reading list from file...");
        List<Entry> entries = new List<Entry>();
        string filename = "entries.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        return entries;
    }
}