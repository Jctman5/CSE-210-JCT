using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your final grade percentage?");
        string grade = Console.ReadLine();
        int x = int.Parse(grade);
        string letter;
        if
        (x >= 90)
        {
            letter = "A";
        }
        else if
        (x >= 80)
        {
            letter = "B";
        }
        else if
        (x >= 70)
        {
            letter = "C";
        }
        else if
        (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your final grade is a {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Your score is not high enough to pass this course.");
        }

    }
}