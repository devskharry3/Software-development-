using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a string (type 'exit' to quit): ");
            string input = Console.ReadLine();

            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            bool isPalindrome;
            int charactersRemoved;

            (isPalindrome, charactersRemoved) = IsPalindrome(input);

            Console.WriteLine($"Is Palindrome: {isPalindrome}");
            Console.WriteLine($"Characters Removed: {charactersRemoved}");
        }
    }

    static (bool, int) IsPalindrome(string input)
    {
        string cleanInput = Regex.Replace(input, @"\W", "").ToLower();
        int charactersRemoved = input.Length - cleanInput.Length;
        
        int left = 0;
        int right = cleanInput.Length - 1;

        while (left < right)
        {
            if (cleanInput[left] != cleanInput[right])
                return (false, charactersRemoved);

            left++;
            right--;
        }

        return (true, charactersRemoved);
    }
}
