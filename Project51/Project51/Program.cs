using System;
using System.Collections.Generic;

class Account
{
    // Protected properties for account details
    protected string AccountNumber { get; }
    protected string AccountHolderName { get; }
    protected decimal Balance { get; set; }

    // Constructor to initialize account details
    public Account(string accountNumber, string accountHolderName, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }

    // Method to deposit money into the account
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid deposit amount.");
            return;
        }
        Balance += amount;
        Console.WriteLine($"Deposited ${amount} into {AccountNumber}. New balance: ${Balance}");
    }

    // Virtual method to withdraw money from the account (can be overridden by subclasses)
    public virtual void Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance)
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            return;
        }
        Balance -= amount;
        Console.WriteLine($"Withdrawn ${amount} from {AccountNumber}. New balance: ${Balance}");
    }

    // Method to transfer money from this account to another account
    public void Transfer(decimal amount, Account destinationAccount)
    {
        if (amount <= 0 || amount > Balance)
        {
            Console.WriteLine("Invalid transfer amount or insufficient balance.");
            return;
        }
        Balance -= amount;
        destinationAccount.Deposit(amount);
        Console.WriteLine($"Transferred ${amount} from {AccountNumber} to {destinationAccount.AccountNumber}");
    }
}

class SavingsAccount : Account
{
    private decimal InterestRate { get; }

    // Constructor to initialize a savings account with an interest rate
    public SavingsAccount(string accountNumber, string accountHolderName, decimal initialBalance, decimal interestRate)
        : base(accountNumber, accountHolderName, initialBalance)
    {
        InterestRate = interestRate;
    }

    // Method to calculate and add interest to the account balance
    public void CalculateInterest()
    {
        decimal interest = Balance * InterestRate / 100;
        Deposit(interest);
        Console.WriteLine($"Interest of ${interest} added to {AccountNumber}. New balance: ${Balance}");
    }
}

class CheckingAccount : Account
{
    private decimal MonthlyFee { get; }

    // Constructor to initialize a checking account with a monthly fee
    public CheckingAccount(string accountNumber, string accountHolderName, decimal initialBalance, decimal monthlyFee)
        : base(accountNumber, accountHolderName, initialBalance)
    {
        MonthlyFee = monthlyFee;
    }

    // Override of the Withdraw method to deduct monthly fee if balance goes negative
    public override void Withdraw(decimal amount)
    {
        base.Withdraw(amount);
        if (Balance < 0)
        {
            Balance -= MonthlyFee;
            Console.WriteLine($"Monthly fee of ${MonthlyFee} deducted from {AccountNumber}. New balance: ${Balance}");
        }
    }
}

class InvestmentAccount : Account
{
    private List<string> Investments { get; }

    // Constructor to initialize an investment account
    public InvestmentAccount(string accountNumber, string accountHolderName, decimal initialBalance)
        : base(accountNumber, accountHolderName, initialBalance)
    {
        Investments = new List<string>();
    }

    // Method to add an investment to the account
    public void AddInvestment(string investmentName)
    {
        Investments.Add(investmentName);
        Console.WriteLine($"Added investment: {investmentName} to {AccountNumber}");
    }

    // Method to remove an investment from the account
    public void RemoveInvestment(string investmentName)
    {
        if (Investments.Remove(investmentName))
            Console.WriteLine($"Removed investment: {investmentName} from {AccountNumber}");
        else
            Console.WriteLine($"Investment: {investmentName} not found in {AccountNumber}");
    }
}

class Program
{
    static void Main()
    {
        // Example usage of the banking system

        SavingsAccount savingsAccount = new SavingsAccount("SAV123", "John Smith", 1000, 2.5m);
        CheckingAccount checkingAccount = new CheckingAccount("CHK456", "Jane Kate", 1500, 10);
        InvestmentAccount investmentAccount = new InvestmentAccount("INV789", "Alice Ford", 20000);

        // Perform various operations on the accounts
        savingsAccount.CalculateInterest();
        checkingAccount.Withdraw(200);
        investmentAccount.AddInvestment("Stocks");
        savingsAccount.Transfer(500, checkingAccount);
        investmentAccount.RemoveInvestment("Bonds");

        Console.ReadLine();
    }
}
