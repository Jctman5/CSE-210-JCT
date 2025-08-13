using System;

class Program
{
    static void Main()
    {
        GoalTracker tracker = new GoalTracker();
        string input = "";

        while (input != "7")
        {
            Console.WriteLine("\n--- Goal Tracker ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Select an option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1": tracker.CreateGoal(); break;
                case "2": tracker.ListGoals(); break;
                case "3": tracker.RecordEvent(); break;
                case "4": tracker.ShowScore(); break;
                case "5": tracker.SaveGoals(); break;
                case "6": tracker.LoadGoals(); break;
                case "7": Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }
}