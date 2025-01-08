// Instructions:
// This program calculates compound interest for a bank account.
// Formula: A = P(1 + r/n)^(n*t)
// Example:
// Input: Principal = $1000, Rate = 5%, Time = 2 years
// Output: Total = $1102.50

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter principal amount:");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter annual interest rate (in %):");
        double rate = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.WriteLine("Enter time in years:");
        int time = Convert.ToInt32(Console.ReadLine());

        double total = principal * Math.Pow((1 + rate), time);

        Console.WriteLine("Total amount after interest: $" + total);
    }
}
