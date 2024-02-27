using System;

namespace OnlineShoppingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Online Shopping Order Simulator\n");

            // Get user inputs
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine().Trim(); // Remove leading and trailing spaces

            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine()); // Assuming positive integer input

            Console.Write("Enter price per unit: ");
            double pricePerUnit = double.Parse(Console.ReadLine()); // Assuming positive floating-point input

            // Calculate total cost
            double totalCost = quantity * pricePerUnit;

            // Display summary using string interpolation
            Console.WriteLine("\nOnline Shopping Order Summary");
            Console.WriteLine($"Product: {productName}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Price per unit: ${pricePerUnit:F2}");
            Console.WriteLine($"Total cost: ${totalCost:F2}\n");
            Console.WriteLine("Thank you for shopping with us!");
        }
    }
}
