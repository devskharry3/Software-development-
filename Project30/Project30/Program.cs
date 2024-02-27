using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your age: ");
        string userInput = Console.ReadLine();

        try
        {
            if (int.TryParse(userInput, out int age))
            {
                Console.WriteLine($"Your age is: {age}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while parsing: {ex.Message}");
        }
    }
}
