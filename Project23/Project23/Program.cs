using System;

namespace TemperatureReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Define arrays for timestamps and temperature readings
            DateTime[] timestamps = {
                new DateTime(2023, 7, 1),
                new DateTime(2023, 7, 2),
                new DateTime(2023, 7, 3),
                new DateTime(2023, 7, 4),
                new DateTime(2023, 7, 5)
            };

            double[] fahrenheitTemperatures = { 78.60, 82.16, 75.40, 81.32, 77.00 };

            // Step 2: Calculate average temperature in Celsius
            double totalCelsiusTemperature = 0;
            foreach (double fahrenheitTemp in fahrenheitTemperatures)
            {
                double celsiusTemp = (fahrenheitTemp - 32) * 5 / 9;
                totalCelsiusTemperature += celsiusTemp;
            }
            double averageCelsiusTemperature = totalCelsiusTemperature / fahrenheitTemperatures.Length;

            // Step 3: Display the data in a well-formatted table
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("{0,-25} {1,12} {2,12} {3,12}", "Timestamp", "Fahrenheit", "Celsius", "Note");
            Console.WriteLine(new string('-', 60));

            for (int i = 0; i < timestamps.Length; i++)
            {
                double fahrenheitTemp = fahrenheitTemperatures[i];
                double celsiusTemp = (fahrenheitTemp - 32) * 5 / 9;
                string note = celsiusTemp > averageCelsiusTemperature ? "Above Avg" : "Below Avg";

                Console.WriteLine("{0,-25:yyyy-MM-dd HH:mm:ss} {1,12:F2} {2,12:F2} {3,12}", timestamps[i], fahrenheitTemp, celsiusTemp, note);
            }

            Console.WriteLine(new string('-', 60));

            // Step 4: Display the average Celsius temperature
            Console.WriteLine("Average Celsius Temperature: {0:F2}°C", averageCelsiusTemperature);
            Console.WriteLine(new string('-', 60));
        }
    }
}
