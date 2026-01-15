using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");
        
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    
                    Entry newEntry = new Entry(prompt, response);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully!\n");
                    break;
                    
                case "2":
                    journal.DisplayAll();
                    break;
                    
                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                    
                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                    
                case "5":
                    Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
                    break;
                    
                default:
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 5.\n");
                    break;
            }
        }
    }
}