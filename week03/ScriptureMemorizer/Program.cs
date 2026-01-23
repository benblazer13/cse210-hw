class Program

// added a library of scriptures so the scripture can be random
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>();

        scriptureLibrary.Add(new Scripture(
            new Reference("John", 3, 16), 
            "For God so loved the world that he gave his only begotten Son"));

        scriptureLibrary.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6), 
            "Trust in the LORD with all thine heart and lean not unto thine own understanding"));

        scriptureLibrary.Add(new Scripture(
            new Reference("Philippians", 4, 13), 
            "I can do all things through Christ which strengtheneth me"));

        scriptureLibrary.Add(new Scripture(
            new Reference("Alma", 37, 35), 
            "O remember my son and learn wisdom in thy youth"));

        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[randomIndex];

        string input = "";

        while (input.ToLower() != "quit" && !selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                int wordsToHide = random.Next(2, 5); 
                selectedScripture.HideRandomWords(wordsToHide);
            }
        }

        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine("\nGood job! You've finished this scripture.");
    }
}