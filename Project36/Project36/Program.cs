using System;

namespace FinancialApplication
{
    class Program
    {
        static void CalculateMonthlyPayment(double loanAmount, double interestRate, int loanDuration, out double monthlyPayment, out double totalPayment)
        {
            // Convert annual interest rate to monthly rate
            double monthlyInterestRate = interestRate / 12 / 100;

            // Calculate monthly payment using the formula for a fixed-rate loan
            monthlyPayment = (loanAmount * monthlyInterestRate) / (1 - Math.Pow(1 + monthlyInterestRate, -loanDuration));

            // Calculate total payment over the entire loan term
            totalPayment = monthlyPayment * loanDuration;
        }

        static void Main(string[] args)
        {
            double loanAmount = 10000;
            double interestRate = 5.0;
            int loanDuration = 12;
            double monthlyPayment;
            double totalPayment;

            CalculateMonthlyPayment(loanAmount, interestRate, loanDuration, out monthlyPayment, out totalPayment);

            Console.WriteLine($"Monthly Payment: {monthlyPayment:C2}");
            Console.WriteLine($"Total Payment: {totalPayment:C2}");

            //Using the out keyword is suitable for this scenario because it allows the function to return multiple values. 
            //In this case, the function needs to return both the monthly payment and the total payment. Instead of returning a single value
            // (which could be done using a tuple or a custom class), the out keyword directly communicates the purpose of these output values
            //. It's a clear and explicit way to indicate that the function is expected to provide both the monthly payment 
            //and the total payment as results.



        }
    }
}
