using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountdown(4);

            if (DateTime.Now >= endTime) break;

            Console.Write("\nNow breathe out...");
            ShowCountdown(6);
        }
    }
}
