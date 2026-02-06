using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _itemCount;

    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        _itemCount = 0;
    }

    protected override void PerformActivity()
    {
        DisplayPrompt();

        Console.Write("\nYou may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        _itemCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");

            string input = GetInputWithTimeout(endTime);

            if (input != null && DateTime.Now < endTime)
            {
                _itemCount++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"\nYou listed {_itemCount} items!");
    }

    private void DisplayPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("\n\nList as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {prompt} ---");
    }

    private string GetInputWithTimeout(DateTime endTime)
    {
        if (DateTime.Now >= endTime)
        {
            return null;
        }

        return Console.ReadLine();
    }
}
