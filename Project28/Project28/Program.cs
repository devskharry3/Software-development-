using System;
using System.Text;

class TextTransformationUtility
{
    public void ReverseText(string text)
    {
        StringBuilder reversedText = new StringBuilder();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversedText.Append(text[i]);
        }
        Console.WriteLine("Reversed Text: " + reversedText);
    }

    public void StringInterpolation(string firstName, string lastName, int age, string city)
    {
        string introduction = $"Hello, I am {firstName} {lastName}, {age} years old, from {city}";
        Console.WriteLine(introduction);
    }

    public void CapitalizeWords(string sentence)
    {
        StringBuilder capitalizedSentence = new StringBuilder();
        bool newWord = true;

        foreach (char c in sentence)
        {
            if (char.IsWhiteSpace(c))
            {
                newWord = true;
                capitalizedSentence.Append(c);
            }
            else
            {
                if (newWord)
                {
                    capitalizedSentence.Append(char.ToUpper(c));
                    newWord = false;
                }
                else
                {
                    capitalizedSentence.Append(char.ToLower(c));
                }
            }
        }
        Console.WriteLine("Capitalized Sentence: " + capitalizedSentence);
    }

    // Other transformation methods can be implemented here
}

class Program
{
    static void Main(string[] args)
    {
        TextTransformationUtility utility = new TextTransformationUtility();

        while (true)
        {
            Console.WriteLine("Choose a transformation option:");
            Console.WriteLine("1. Reverse Text");
            Console.WriteLine("2. String Interpolation");
            Console.WriteLine("3. Capitalize Words");
            Console.WriteLine("4. Text Encryption");
            Console.WriteLine("5. Text Compression");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter text to reverse: ");
                    string textToReverse = Console.ReadLine();
                    utility.ReverseText(textToReverse);
                    break;

                case "2":
                    Console.Write("Enter first name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter city: ");
                    string city = Console.ReadLine();
                    utility.StringInterpolation(firstName, lastName, age, city);
                    break;

                case "3":
                    Console.Write("Enter sentence to capitalize words: ");
                    string sentence = Console.ReadLine();
                    utility.CapitalizeWords(sentence);
                    break;

                case "4":
                    Console.Write("Enter the text to encrypt: ");
                    string inputText = Console.ReadLine();

                    Console.Write("Enter the shift value: ");
                    int shiftValue;
                    if (!int.TryParse(Console.ReadLine(), out shiftValue))
                    {
                        Console.WriteLine("Invalid shift value. Encryption canceled.");
                        break;
                    }

                    string encryptedText = Encrypt(inputText, shiftValue);
                    Console.WriteLine($"Encrypted text: {encryptedText}");
                    break;

                case "5":
                    Console.Write("Enter the text to compress: ");
                    string inputTextForCompression = Console.ReadLine();

                    string compressedText = Compress(inputTextForCompression);
                    Console.WriteLine($"Compressed text: {compressedText}");
                    break;

                case "6":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }

            Console.Write("Do you want to perform another transformation? (y/n): ");
            string anotherTransformation = Console.ReadLine();
            if (anotherTransformation.ToLower() != "y")
            {
                break;
            }
        }
    }

    static string Encrypt(string text, int shift)
    {
        StringBuilder encrypted = new StringBuilder();

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char shifted = (char)(c + shift);
                if ((char.IsLower(c) && shifted > 'z') || (char.IsUpper(c) && shifted > 'Z'))
                {
                    shifted = (char)(shifted - 26);
                }
                encrypted.Append(shifted);
            }
            else
            {
                encrypted.Append(c);
            }
        }

        return encrypted.ToString();
    }

    static string Compress(string text)
    {
        StringBuilder compressed = new StringBuilder();

        char currentChar = text[0];
        int count = 1;

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] == currentChar)
            {
                count++;
            }
            else
            {
                compressed.Append(currentChar);
                if (count > 1)
                {
                    compressed.Append(count);
                }
                currentChar = text[i];
                count = 1;
            }
        }

        compressed.Append(currentChar);
        if (count > 1)
        {
            compressed.Append(count);
        }

        return compressed.ToString();
    }
}
