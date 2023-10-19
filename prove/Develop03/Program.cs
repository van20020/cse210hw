using System;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        Reference reference1 = new Reference("John", 11, 35);
        Scripture scripture1 = new Scripture(reference1, "Jesus wept");
        List<int> hiddenWords1 = new List<int>();
        List<int> hiddenWords2 = new List<int>();

        Console.Write("Press ENTER to hide a word. ");
        int totalWords1 = scripture1.GetWords().Count;
        Console.WriteLine("");

        while (hiddenWords1.Count < totalWords1)
        {
            Console.WriteLine(reference1.GetString() + scripture1.GetRenderedText());
            Console.ReadLine(); 

            int randomIndex;
            do
            {
                randomIndex = random.Next(totalWords1);
            } while (hiddenWords1.Contains(randomIndex));

            scripture1.GetWords()[randomIndex].Hide();
            hiddenWords1.Add(randomIndex);

            Console.Write("Press ENTER to hide a word. ");
            Console.ReadLine();
        }

        Console.WriteLine("All words are now hidden.");

        Console.WriteLine("");
        Reference reference2 = new Reference("Proverbs" , 3 , 5 , 6);
        Scripture scripture2 = new Scripture(reference2, "Trust in the Lord with all thy heart. In all thy ways acknowledge and He shall direct thy paths.");

        Console.Write("Press ENTER to hide a word. ");
        int totalWords2 = scripture2.GetWords().Count;
        Console.WriteLine("");

        while (hiddenWords2.Count < totalWords2)

        {
            Console.WriteLine(reference2.GetStringEnd() + scripture2.GetRenderedText());
            Console.ReadLine(); 

            int randomIndex;
            do
            {
                randomIndex = random.Next(totalWords2);
            } while (hiddenWords2.Contains(randomIndex));

            scripture2.GetWords()[randomIndex].Hide();
            hiddenWords2.Add(randomIndex);

            Console.Write("Press ENTER to hide a word. ");
            Console.ReadLine();
        }

        Console.WriteLine("All words are now hidden.");
    }
}