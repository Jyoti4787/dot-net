using System;

class LoanEligibility
{
    public static void CheckEligibility()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your monthly income: ₹");
        double income = Convert.ToDouble(Console.ReadLine());

        if (age < 21)
        {
            Console.WriteLine("Not eligible: Age must be 21 or above.");
        }
        else if (income < 30000)
        {
            Console.WriteLine("Not eligible: Monthly income must be ₹30,000 or more.");
        }
        else
        {
            double maxLoan = income * 20;
            Console.WriteLine($"You are eligible for a loan up to: ₹{maxLoan}");
        }
    }
}
