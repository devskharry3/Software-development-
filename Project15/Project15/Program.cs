using System;

class Program
{
    static void Main(string[] args)
    {
        int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int targetSum = 15;

        Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
        Console.WriteLine($"Target Sum: {targetSum}");
        Console.WriteLine("Output:");

        for (int i = 0; i < inputArray.Length - 2; i++)
        {
            for (int j = i + 1; j < inputArray.Length - 1; j++)
            {
                for (int k = j + 1; k < inputArray.Length; k++)
                {
                    int sum = inputArray[i] + inputArray[j] + inputArray[k];
                    if (sum == targetSum)
                    {
                        Console.WriteLine($"Triplet found: {inputArray[i]}, {inputArray[j]}, {inputArray[k]}");
                        break; // Break to avoid duplicate triplets with the same starting element
                    }
                }
            }
        }
    }
}
