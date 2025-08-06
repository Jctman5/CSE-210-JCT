using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new()
    {
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

    public ReflectionActivity()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    protected override void Execute()
    {
        Random rand = new();
        Console.WriteLine("\n" + prompts[rand.Next(prompts.Count)]);
        Console.WriteLine("Consider the following questions:\n");

        int elapsed = 0;
        int interval = 5;

        while (elapsed < _duration)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine("> " + question);
            ShowSpinner(interval);
            elapsed += interval;
        }
    }
}