using System;

class Program
{
    static void Main(string[] args)
    {
        int[] data = { 5, -2, 10, -8, 3, 7, -4, 1, -6, 9, 12 };

        int sumOfPositiveValues = 0;
        int positiveCount = 0;

        foreach (int value in data)
        {
            if (value > 0)
            {
                sumOfPositiveValues += value;
                positiveCount++;
            }
        }

        Console.WriteLine($"Sum of positive values: {sumOfPositiveValues}");
        Console.WriteLine($"Total positive values encountered: {positiveCount}");
    }
}
