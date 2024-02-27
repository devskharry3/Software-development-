using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int input = int.Parse(Console.ReadLine());

        if (input < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            int factorial = 1;

            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {input} is: {factorial}");
        }
    }
}
