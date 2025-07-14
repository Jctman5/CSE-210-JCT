using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "Who helped me get through today?",
        "What was the most interesting part of my day?",
        "How did I grow spiritually today?",
        "What upset me today?",
        "Was today a good day?"
    };

    public void AddEntry()
    {
        var random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry newEntry = new Entry(date, prompt, response);
        entries.Add(newEntry);

        Console.WriteLine("Entry added!\n");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\n--- Journal Entries ---");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved.\n");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        entries.Clear();

        foreach (var line in File.ReadAllLines(filename))
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
        }

        Console.WriteLine("Journal loaded.\n");
    }
}