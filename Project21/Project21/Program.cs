using System;

namespace TextAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Text Analyzer!");

            while (true)
            {
                Console.WriteLine("1. Calculate sentence length");
                Console.WriteLine("2. Concatenate with predefined phrase");
                Console.WriteLine("3. Join words with hyphens");
                Console.WriteLine("4. Count vowels");
                Console.WriteLine("5. Check for \"important\"");
                Console.WriteLine("6. Compare with predefined sentence");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CalculateSentenceLength();
                        break;
                    case 2:
                        ConcatenateWithPredefinedPhrase();
                        break;
                    case 3:
                        JoinWordsWithHyphens();
                        break;
                    case 4:
                        CountVowels();
                        break;
                    case 5:
                        CheckForImportant();
                        break;
                    case 6:
                        CompareWithPredefinedSentence();
                        break;
                    case 7:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        static void CalculateSentenceLength()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            int length = sentence.Length;
            Console.WriteLine($"Sentence length: {length}");
        }

        static void ConcatenateWithPredefinedPhrase()
        {
            string predefinedPhrase = "This is the extra phrase";
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string concatenated = sentence + "." + predefinedPhrase;
            Console.WriteLine($"Concatenated: {concatenated}");
        }

        static void JoinWordsWithHyphens()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            string hyphenJoined = string.Join("-", words);
            Console.WriteLine($"Joined: {hyphenJoined}");
        }

        static void CountVowels()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            int vowelCount = 0;
            foreach (char c in sentence.ToLower())
            {
                if ("aeiou".Contains(c))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine($"Number of vowels: {vowelCount}");
        }

        static void CheckForImportant()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            bool containsImportant = sentence.ToLower().Contains("important");
            Console.WriteLine($"Contains \"important\": {containsImportant}");
        }

        static void CompareWithPredefinedSentence()
        {
            string predefinedSentence = "Hello, this is a sample sentence";
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            bool sentencesMatch = sentence.Equals(predefinedSentence);
            Console.WriteLine($"Sentences match: {(sentencesMatch ? "Yes" : "No")}");
        }
    }
}
