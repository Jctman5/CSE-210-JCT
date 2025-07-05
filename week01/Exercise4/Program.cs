using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();

        
        int userInput;
        do
        {
            Console.Write("Enter a number (0 to stop): ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

        } while (userInput != 0);

        
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        
        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average:F2}");
        }
        else
        {
            Console.WriteLine("No numbers entered to compute an average.");
        }

        
        if (numbers.Count > 0)
        {
            int max = numbers.Max();
            Console.WriteLine($"The largest number is: {max}");
        }
    }
}