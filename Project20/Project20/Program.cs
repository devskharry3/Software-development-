using System;

class Program
{
    static void Main(string[] args)
    {
        string inputText = "";
        string secretMessage = "this is the secret message";
        string delimiter = "";

        while (true)
        {
            Console.WriteLine("Text Analyser Application\n");
            Console.WriteLine("1. Enter text");
            Console.WriteLine("2. Calculate the total characters");
            Console.WriteLine("3. Concatenate sentences");
            Console.WriteLine("4. Join sentences with delimiter");
            Console.WriteLine("5. Search for keyword");
            Console.WriteLine("6. Count occurrence of a character");
            Console.WriteLine("7. Compare with the secret message");
            Console.WriteLine("8. Exit\n");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the text: ");
                    inputText = Console.ReadLine();
                    break;

                case 2:
                    int totalCharacters = inputText.Length;
                    Console.WriteLine($"Total characters in the text: {totalCharacters}");
                    break;

                case 3:
                    string concatenatedParagraph = inputText.Replace(". ", " ");
                    Console.WriteLine($"Concatenated paragraph: {concatenatedParagraph}");
                    break;

                case 4:
                    Console.Write("Enter the delimiter: ");
                    delimiter = Console.ReadLine();
                    string joinedSentences = inputText.Replace(". ", delimiter);
                    Console.WriteLine($"Joined Sentences: {joinedSentences}");
                    break;

                case 5:
                    Console.Write("Enter the keyword to search: ");
                    string keyword = Console.ReadLine();
                    bool keywordFound = inputText.ToLower().Contains(keyword.ToLower());
                    Console.WriteLine(keywordFound ? "Keyword found in the text." : "Keyword not found in the text.");
                    break;

                case 6:
                    Console.Write("Enter the character to count: ");
                    char characterToCount = char.Parse(Console.ReadLine());
                    int occurrenceCount = 0;
                    foreach (char c in inputText)
                    {
                        if (c == characterToCount)
                            occurrenceCount++;
                    }
                    Console.WriteLine($"Occurrence of \"{characterToCount}\" in the text: {occurrenceCount}");
                    break;

                case 7:
                    Console.WriteLine("Comparing with the secret message...");
                    bool isSecretMessageMatch = inputText.Equals(secretMessage, StringComparison.OrdinalIgnoreCase);
                    Console.WriteLine(isSecretMessageMatch ? "The input text matches the secret message." : "The input text does not match the secret message.");
                    break;

                case 8:
                    Console.WriteLine("Exiting the application.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
