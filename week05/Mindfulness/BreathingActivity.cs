using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void Execute()
    {
        int interval = 4;
        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(interval);
            elapsed += interval;

            if (elapsed >= _duration) break;

            Console.Write("Breathe out... ");
            ShowCountdown(interval);
            elapsed += interval;
        }
    }
}