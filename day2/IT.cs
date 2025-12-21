using System;

class IncomeTax
{
    public static void CalculateTax()
    {
        Console.Write("Enter your annual income: ₹");
        double income = Convert.ToDouble(Console.ReadLine());
        double tax = 0;

        if (income <= 250000)
            tax = 0;
        else if (income <= 500000)
            tax = 0.05 * (income - 250000);
        else if (income <= 1000000)
            tax = 12500 + 0.2 * (income - 500000);
        else
            tax = 112500 + 0.3 * (income - 1000000);

        Console.WriteLine($"Your calculated income tax is: ₹{tax}");
    }
}
