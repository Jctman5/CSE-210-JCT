using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void Execute()
    {
        Random rand = new();
        Console.WriteLine("\n" + prompts[rand.Next(prompts.Count)]);
        Console.WriteLine("You will begin listing in:");
        ShowCountdown(5);
        Console.WriteLine("Start listing (press Enter after each item):");

        List<string> items = new();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    items.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
    }
}