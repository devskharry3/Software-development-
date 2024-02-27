using System;

class Program {
    //function to convert miles to kilometers
    float MilesToKm(float miles) {
        float result = miles * 1.6f;
        return result;
    }

    //function to convert kilometres to miles
    float KmToMiles(float km) {
        float result = km/1.6f;
        return result;
    }

    //function to print a given message with a specified prefix
    void PrintWithPrefix(string prefix, string message) {
        Console.WriteLine($"[{prefix}] {message}");
    }

    //function to calculate the area of a rectangle
    float CalculateRectangleArea(float length, float width) {
        float area = length * width;
        return area;

    }

    static void Main(string[] args) {
        Program program = new Program();

        //Example 1: Convert miles to kilometres
        float miles1 = 8.0f;
        float miles2 = 52.0f;
        float km1 = program.MilesToKm(miles1);
        float km2 = program.MilesToKm(miles2);

Console.WriteLine($"{miles1} miles is approximately {km1} kilometres.");
Console.WriteLine($"{miles2} miles is approximately {km2} kilometres.");

//Example 2: Convert kilometres to miles
float km3 = 100.0f;
float miles3 = program.KmToMiles(km3);
Console.WriteLine($"{km3} kilometres is approxiamtely {miles3} miles.");

//Example 3: Print message with prefixes
program.PrintWithPrefix("INFO", "This is an informational message.");
program.PrintWithPrefix("WARNING", "This is a warning message");
program.PrintWithPrefix("ERROR", "This is an error message");

//Example 4: Calculate rectangle areas
float length = 5.0f;
float width = 3.0f;
float area = program.CalculateRectangleArea(length,width);
Console.WriteLine($"The area of a rectangle with length {length} and width {width} is {area} square units. ");

    }
}