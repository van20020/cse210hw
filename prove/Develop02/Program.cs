using System;

class Program
{
    static void Main(string[] args)
    {

        // Create Journal Object
        
        List<string> prompts = new List<string>();

            prompts.Add("Who was the most interesting person I interacted with today?");
            prompts.Add("What was the best part of my day?");
            prompts.Add("How did I see the hand of the Lord in my life today?");
            prompts.Add("What was the strongest emotion I felt today?");
            prompts.Add("If I had one thing I could do over today, what would it be?");
    

        //if user picks entry add new entry
        // 1. pick random prompt from lsit above
        // 2. display random prompt
        // 3. Save Entry from user

        // 4. Create Entry Object

        // 5. Save Entry object to Journal object

        Entry entry = new Entry();
        entry.EntryDate = DateTime.Now.ToShortDateString();
        entry.Prompt = ""; // From prompt up above;
        entry.Response = "";  // pull from user's response

        Journal journal = new Journal();
        journal.JournalName = ""; // ask user for name
        journal.Entries.Add(entry);

    }
}