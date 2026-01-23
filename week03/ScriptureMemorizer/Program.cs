class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scrip = new Scripture(ref1, "Trust in the LORD with all thine heart and lean not unto thine own understanding");

        string input = "";

        while (input.ToLower() != "quit" && !scrip.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scrip.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                scrip.HideRandomWords(3); 
            }
        }

        Console.Clear();
        Console.WriteLine(scrip.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Goodbye!");
    }
}