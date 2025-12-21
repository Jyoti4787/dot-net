using System;

class Credit
{
    // Net Salary Credit Calculation

    public static void NetSalary()
    {
        Console.Write("Enter gross salary: ");
        int salary = int.Parse(Console.ReadLine()!);

        int deduction = (salary * 10) / 100;
        int netSalary = salary - deduction;

        Console.WriteLine($"Net salary credited: {netSalary}");
    }

    // Fixed Deposit Maturity Calculation

    public static void FixedDeposit()
    {
        Console.Write("Enter principal amount: ");
        int principal = int.Parse(Console.ReadLine()!);

        Console.Write("Enter rate of interest (%): ");
        int rate = int.Parse(Console.ReadLine()!);

        Console.Write("Enter time (years): ");
        int time = int.Parse(Console.ReadLine()!);

        int interest = (principal * rate * time) / 100;
        int maturityAmount = principal + interest;

        Console.WriteLine($"Fixed Deposit maturity amount: {maturityAmount}");
    }

    // Credit Card Reward Points Evaluation

    public static void RewardPoints()
    {
        Console.Write("Enter total credit card spending: ");
        int spending = int.Parse(Console.ReadLine()!);

        int points = spending / 100;

        Console.WriteLine($"Reward points earned: {points}");
    }

    // Employee Bonus Eligibility Check

    public static void BonusEligibility()
    {
        Console.Write("Enter annual salary: ");
        int salary = int.Parse(Console.ReadLine()!);

        Console.Write("Enter years of service: ");
        int years = int.Parse(Console.ReadLine()!);

        if (salary >= 500000 && years >= 3)
            Console.WriteLine("Employee is eligible for bonus.");
        else
            Console.WriteLine("Employee is not eligible for bonus.");
    }
}
