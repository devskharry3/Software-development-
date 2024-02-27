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

            // Split input into words using commas or hyphens as delimiters
            string[] words = input.Split(new[] { ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

            int palindromeCount = 0; // To count palindromic words
            int charactersRemovedTotal = 0; // To track total characters removed

            foreach (string word in words)
            {
                bool isPalindrome;
                int charactersRemoved;

                (isPalindrome, charactersRemoved) = IsPalindrome(word);

                charactersRemovedTotal += charactersRemoved;

                if (isPalindrome)
                {
                    palindromeCount++;
                }
            }

            Console.WriteLine($"Number of palindromes: {palindromeCount}");
            Console.WriteLine($"Number of non-palindromes: {words.Length - palindromeCount}");
            Console.WriteLine($"Total characters removed: {charactersRemovedTotal}");
        }
    }

    static (bool, int) IsPalindrome(string input)
    {
        //Regex.Replace(input, @"\W", "") uses a regular expression (\W) to match all non-word characters (like punctuation, spaces, etc.) 
        //in the input string input. The Regex.Replace function then replaces these non-word characters 
        //with an empty string, effectively removing them from the input.
//This step ensures that only the alphanumeric characters (letters and digits) remain in the cleanInput string.
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
