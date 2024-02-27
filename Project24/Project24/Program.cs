using System;

namespace StringInterpolation
{
    class Program 
    {
        static void Main(string[] args) 
        {
            //declare some variables 
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            //Example1: string interpolation with custom formatting 
            Console.WriteLine($"Example 1: Custom Formatting");
            Console.WriteLine($"Price: {price,15:C2}");
            Console.WriteLine($"Miles:  {miles,15:N2}");
            Console.WriteLine($"Year:   {year,15: D4}");
            Console.WriteLine();

            //Example 2: Interpolation with conditional expression 
            Console.WriteLine($"Example 2: Conditional Expression");
            string condition = miles > 10_000? "high" : "low";
            Console.WriteLine($"This car has a {condition} mileage of {miles:N2} miles.");
            Console.WriteLine();

            //Example 3: Interpolation with mathematical expressions
            Console.WriteLine($"Example 3 : Matthematical Expression");
            double taxRate = 0.88;
            decimal taxAmount = price * (decimal)taxRate;
            Console.WriteLine($"Tax Amount: (taxAmount:C2)");
            Console.WriteLine();

            //Example 4: Displaying a bar graph 
            int[] dataPoints = {10,25,15,30,28};
            Console.WriteLine("Example 4: Bar Graph");
            for (int i = 0; i < dataPoints.Length; i++)
            {
                string bar = new string ('#',dataPoints[i]);
                Console.WriteLine($"{i + 1,2}: {bar, -30}");
            }
            Console.WriteLine();

            //Example 5: Interpolation with unicode charcters
            string musicalNote = "\u266B";
            string happyFace = "\u263A";
            Console.WriteLine("Example 5: Unicode Characters");
            Console.WriteLine($"Enjoy the {musicalNote} of life, and always stay {happyFace}!");

            //unicode and musical Note Example (Extended) 
            Console.WriteLine();
            Console.WriteLine("Unicode and Musical Note Example (Extended)");

           //in this example, we'll explore the use of unicode characters and string interpolation
           // to create visually appealing and expressive text output 

           //Unicode characters allows us to include a wide range of symbls, icons and special
           //characters in our strings. These characters can enhance the visual apperance of
           // our output and add a touch of creativity. 

           //Let's start by using a unicode character to represent a musical note:
           string extendedMusicalNote = "\u266B"; //unicode character for a musical note 

           //unicode characters are represented using escape sequences in the form \uXXXX,
           //where XXXX is the hexadecimal Unicode code point of the character 

           //now , let's use string interpolation to create a senetnce incorporating the musical note:
           string message1 = $"Feel the {extendedMusicalNote} of the music as it fills the air.";

           //The unicode character for a musical note is embedded within string,
           // adding a visual representation of the concept of music.

           //Next, ;et's explore another unicode character. we'll use the Unicode character 
           //for a happy face emotion:
           string extendedHappyFace = "\u263A"; //unicode character for a happy face emotion 

           //Similar to the musical note, we'll use string interpolation to create a sentence 
           //with the happy face emotion: 
           string message2 = $"Keep smilling and {extendedHappyFace} aleways";

           //The use of the happy face emotion adds a positive and cheerful element to the text.

           //Now, let's combine both unicode characters in asingle message using string interpolation:
           string combinedMessage = $"Let the {extendedMusicalNote} of life fill your days, and remember to {extendedHappyFace} every moment .";

           //By combining the musical note and ahppy face, we create a message that encourages
           // a joful and positive outlook on life. 

           //Finally, Let's dispklay the messages we've created 
           Console.WriteLine();
           Console.WriteLine(message1);
           Console.WriteLine(message2);
           Console.WriteLine();
           Console.WriteLine(combinedMessage); 


           //The Unicode code point for the letter "A" is U+0041
           // The Unicode code point for the dollar sign "$" is U+0024
           //The Unicode point for the heart emoji is U+2764 

        }
    }
}