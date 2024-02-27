using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextAnalysisProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text:");
            string inputText = Console.ReadLine();
            
            // Uncomment the following lines if you want to read from a text file instead
            string filePath = "path_to_your_text_file.txt";
            string inputText = File.ReadAllText(filePath);

            // Count lines, words, and characters
            int lineCount = inputText.Split('\n').Length;
            int wordCount = inputText.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int charCount = inputText.Length;

            Console.WriteLine($"Number of lines: {lineCount}");
            Console.WriteLine($"Number of words: {wordCount}");
            Console.WriteLine($"Number of characters: {charCount}");
            Console.WriteLine();

            // Find longest and shortest words
            string[] words = inputText.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = words.OrderByDescending(word => word.Length).First();
            string shortestWord = words.OrderBy(word => word.Length).First();

            Console.WriteLine($"Longest word: {longestWord} (Length: {longestWord.Length})");
            Console.WriteLine($"Shortest word: {shortestWord} (Length: {shortestWord.Length})");
            Console.WriteLine();

            // Compute word frequency
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                    wordFrequency[word]++;
                else
                    wordFrequency[word] = 1;
            }

            Console.Write("Enter the number of top N most frequent words to display: ");
            int topN = int.Parse(Console.ReadLine());

            var topWords = wordFrequency.OrderByDescending(pair => pair.Value).Take(topN);
            Console.WriteLine($"Top {topN} most frequent words:");
            foreach (var pair in topWords)
            {
                Console.WriteLine($"\"{pair.Key}\" {pair.Value} times");
            }
            Console.WriteLine();

            // Identify and output palindromic words
            var palindromicWords = words.Where(word => IsPalindrome(word)).Distinct();
            Console.WriteLine("Palindromic words:");
            foreach (var word in palindromicWords)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();

            // Identify and output word pairs with frequency above threshold
            Console.Write("Enter the threshold for word pair frequency: ");
            int threshold = int.Parse(Console.ReadLine());

            Dictionary<string, int> wordPairFrequency = new Dictionary<string, int>();
            for (int i = 0; i < words.Length - 1; i++)
            {
                string pair = $"{words[i]} {words[i + 1]}";
                if (wordPairFrequency.ContainsKey(pair))
                    wordPairFrequency[pair]++;
                else
                    wordPairFrequency[pair] = 1;
            }

            var frequentPairs = wordPairFrequency.Where(pair => pair.Value > threshold);
            Console.WriteLine($"Word pairs with frequency above {threshold}:");
            foreach (var pair in frequentPairs)
            {
                Console.WriteLine($"\"{pair.Key}\" {pair.Value} times");
            }
        }

        static bool IsPalindrome(string word)
        {
            return word.SequenceEqual(word.Reverse());
        }
    }
}
