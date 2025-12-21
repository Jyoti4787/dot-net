using System;
class Debit{
    //ATM Withdrwal

    public static void ATMWithdrawl(){
        const int limit = 40000;
        Console.Write("Enter Withdrawl amount: ");
        int amount = int.Parse(Console.ReadLine()!);
        if (amount<=limit)
            Console.WriteLine("withdrawl permitted.");
        else
            Console.WriteLine("Daily limit exceed.");
    }

    //EMI burden

    public static void EMICheck(){
        Console.Write("Enter monthly income: ");
        int income = int.Parse(Console.ReadLine()!);

        Console.Write("enter EMI ammount: ");
        int emi = int.Parse(Console.ReadLine()!);

        if(emi<=0.4*income)
            Console.WriteLine("EMI is financially manageable.");
        else
            Console.WriteLine("EMI exceeds safe income limit.");
    }

    //Transaction-Based Daily Spending Calculator

    public static void DailySpending(){
        Console.Write("enter number of transactions: ");
        int n = int.Parse(Console.ReadLine()!);

        int total=0;
        for (int i = 1; i <= n; i++){
            Console.Write($"enter amount for transaction {i}: ");
            int amount = int.Parse(Console.ReadLine()!);
            total+=amount;
        }
        Console.WriteLine($"Total debit amount for the day: {total}");
    }

     // Function 4: Minimum Balance Compliance Check

     public static void MinimumBalance(){
        const int minBalance = 2000;
        Console.Write("Enter current balance: ");
        int balance = int.Parse(Console.ReadLine()!);

        if(balance < minBalance)
            Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
        else
            Console.WriteLine("Minimum balance requirement satisfied.");     
     }
}
