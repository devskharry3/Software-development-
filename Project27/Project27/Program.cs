using System;
using System.Text;

class Program
{
    static string ManipulateText(string input)
    {
        StringBuilder sb = new StringBuilder();
        char prevChar = '\0'; // Initialize with a character that won't be in the input

        foreach (char c in input)
        {
            if (c != prevChar)
            {
                sb.Append(c);
                prevChar = c;
            }
        }

        // Create a new StringBuilder to store the modified result
        StringBuilder modifiedSb = new StringBuilder();
        for (int i = 0; i < sb.Length; i++)
        {
            if (i % 2 == 0)
            {
                modifiedSb.Append('_');
            }
            else
            {
                modifiedSb.Append(sb[i]);
            }
        }

        modifiedSb.Append(input.Length);
        return modifiedSb.ToString();
    }

    static void Main(string[] args)
    {
        string input = "aabbccddeeff";
        string result = ManipulateText(input);
        Console.WriteLine(result);
    }
}
