using System;
using System.Text;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hotel Reservation System!");

            // Initialize StringBuilder to construct summary message
            StringBuilder summaryBuilder = new StringBuilder();

            try
            {
                // Prompt user for check-in date
                Console.Write("Enter check-in date (DD/MM/YYYY): ");
                string checkInInput = Console.ReadLine();

                // Parse check-in date
                DateTime checkInDate = DateTime.ParseExact(checkInInput, "dd/MM/yyyy", null);

                // Prompt user for check-out date
                Console.Write("Enter check-out date (DD/MM/YYYY): ");
                string checkOutInput = Console.ReadLine();

                // Parse check-out date
                DateTime checkOutDate = DateTime.ParseExact(checkOutInput, "dd/MM/yyyy", null);

                // Check if check-out is before check-in
                if (checkOutDate <= checkInDate)
                {
                    Console.WriteLine("Invalid dates. Check-out date must be after check-in date.");
                    return;
                }

                // Calculate duration of stay
                TimeSpan stayDuration = checkOutDate - checkInDate;

                // Convert dates to readable format
                string formattedCheckIn = checkInDate.ToString("MMMM dd, yyyy");
                string formattedCheckOut = checkOutDate.ToString("MMMM dd, yyyy");

                // Calculate total cost of reservation (dummy value)
                double totalCost = stayDuration.TotalDays * 100; // $100 per day

                // Construct summary message using StringBuilder
                summaryBuilder.AppendLine("Reservation Summary:");
                summaryBuilder.AppendLine($"Check-in: {formattedCheckIn}");
                summaryBuilder.AppendLine($"Check-out: {formattedCheckOut}");
                summaryBuilder.AppendLine($"Duration of stay: {stayDuration.Days} days");
                summaryBuilder.AppendLine($"Total cost: ${totalCost}");

                // Display summary to user
                Console.WriteLine(summaryBuilder.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format. Please use the format DD/MM/YYYY.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
