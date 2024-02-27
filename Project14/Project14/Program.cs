using System;

namespace LoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 15, 7, 12, 23, 41, 28, 9, 17, 36 };

            Console.WriteLine("Using break and continue:");
            foreach (int val in values)
            {
                // The continue statement skips the rest of the loop iteration
                // and jumps to the next iteration (if there is one)
                if (val >= 20 && val <= 29)
                {
                    continue;
                }

                // Print the value
                Console.WriteLine($"val is currently {val}");

                // The break statement stops the loop and exits
                if (val >= 40)
                {
                    break;
                }
            }

            Console.WriteLine();

            int[] numbers = { 2, 10, 20, 30, 12, 14, 15, 3, 6, 5, 8, 11, 14, 17, 20, 23 };

            Console.WriteLine("Skipping even numbers and exiting on the first odd prime:");
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"Skipping even number: {num}");
                    continue;
                }

                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"Number {num} is prime.");
                }
            }

            int[] moreNumbers = { 5, -3, 8, 10, -2, 7, -1, 4, 9, -6 };

            Console.WriteLine("Calculating the sum of positive numbers with early exit");
            int sum = 0;
            foreach (int num in moreNumbers)
            {
                if (num < 0)
                {
                    Console.WriteLine($"Skipping negative number: {num}");
                    continue;
                }

                sum += num;

                if (sum >= 20)
                {
                    Console.WriteLine($"Sum reached or exceeded 20. Exiting loop.");
                    break;
                }
            }

            Console.WriteLine($"Final sum of positive numbers: {sum}");
        }
    }
}
