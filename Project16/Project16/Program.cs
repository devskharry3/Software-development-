using System;

class Program
{
    static bool IsPalindrome(int number)
    {
        string str = number.ToString();
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Input n: ");
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        int num = 2;

        while (count < n)
        {
            if (IsPalindrome(num) && IsPrime(num))
            {
                Console.WriteLine($"Prime Palindrome {count}: {num}");
            }
            num++;
        }
    }
}

