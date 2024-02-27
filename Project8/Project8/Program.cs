using System;

class TemperatureConverter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Temperature Unit Converter");

        int numConversions = 1;

        do
        {
            Console.WriteLine($"\nConversion {numConversions}:");

            // Input
            Console.Write("Enter temperature value along with unit (e.g., '25 C' or '77 F' or '298.15 K'): ");
            string userInput = Console.ReadLine()?.Trim();

            while (string.IsNullOrEmpty(userInput) || !ValidateInput(userInput))
            {
                Console.Write("Invalid input. Please enter the temperature value with unit: ");
                userInput = Console.ReadLine()?.Trim();
            }

            // Conversion
            string[] inputParts = userInput.Split(' ');
            double inputValue = double.Parse(inputParts[0]);
            char unit = char.ToUpper(inputParts[1][0]);

            double convertedValue = unit switch
            {
                'C' => CelsiusToFahrenheit(inputValue),
                'F' => FahrenheitToCelsius(inputValue),
                'K' => CelsiusToKelvin(inputValue),
                _ => 0
            };

            // Determine hot or cold
            string temperatureCategory = convertedValue >= 30 ? "hot" : "cold";

            // Store conversion result
            double[] conversionResult = { inputValue, convertedValue };

            // Output
            Console.WriteLine($"Temperature: {inputValue} {unit}");
            Console.WriteLine($"Converted Temperature: {convertedValue} {unit}");
            Console.WriteLine($"Category: {temperatureCategory}");

            numConversions++;

            Console.Write("Do you want to perform more conversions? (y/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "y");
    }

    static bool ValidateInput(string input)
    {
        string[] inputParts = input.Split(' ');

        if (inputParts.Length != 2)
        {
            Console.WriteLine("Invalid input format.");
            return false;
        }

        char unit = char.ToUpper(inputParts[1][0]);

        if (unit != 'C' && unit != 'F' && unit != 'K')
        {
            Console.WriteLine("Invalid unit. Please use 'C', 'F', or 'K'.");
            return false;
        }

        return true;
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }
}
