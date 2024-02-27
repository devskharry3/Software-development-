using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Analyzer");
            Console.WriteLine("Enter positive integers (enter a negative number to finish):\n");

            int totalCount = 0;
            int sum = 0;
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            while (true)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    break; // End the loop when a negative number is entered
                }

                if (number >= 0)
                {
                    totalCount++;
                    sum += number;
                    maxNumber = Math.Max(maxNumber, number);
                    minNumber = Math.Min(minNumber, number);
                }
            }

            if (totalCount > 0)
            {
                double average = (double)sum / totalCount;

                Console.WriteLine("\nStatistics:");
                Console.WriteLine($"Total numbers entered: {totalCount}");
                Console.WriteLine($"Sum of numbers: {sum}");
                Console.WriteLine($"Average of numbers: {average:F1}");
                Console.WriteLine($"Maximum number: {maxNumber}");
                Console.WriteLine($"Minimum number: {minNumber}");
            }
            else
            {
                Console.WriteLine("No valid numbers entered.");
            }
        }
    }
}
