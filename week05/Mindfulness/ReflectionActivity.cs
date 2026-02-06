using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity()
        : base("Reflection Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. So stop being depressed and answer these questions honestly")
    {
        _prompts = new List<string>
            {
                //this was difficult to come up with these
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

        _questions = new List<string>
            {
                //these too
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
    }

    protected override void PerformActivity()
    {
        DisplayPrompt();

        Console.WriteLine("\n\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Random random = new Random();

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion(random);
            Console.Write($"\n\n> {question} ");
            ShowSpinner(10);
        }
    }

    private void DisplayPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("\n\nConsider the following prompt:\n");
        Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine("\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private string GetRandomQuestion(Random random)
    {
        return _questions[random.Next(_questions.Count)];
    }
}
