using System;

class Transaction
{
    static double balance = 50000; 
    static int transactionCount = 0;

    public static void EnterTransactions()
    {
        while (transactionCount < 5)
        {
            Console.WriteLine($"\nTransaction {transactionCount + 1} of 5");

            Console.Write("Enter transaction type (1 = Deposit, 2 = Withdrawal): ");
            int type = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter amount: ₹");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount! Skipping transaction.");
                continue;
            }

            switch (type)
            {
                case 1:
                    balance += amount;
                    Console.WriteLine($"Deposited ₹{amount}. New Balance: ₹{balance}");
                    transactionCount++;
                    break;
                case 2:
                    if (amount > balance)
                    {
                        Console.WriteLine("Insufficient funds! Transaction skipped.");
                    }
                    else
                    {
                        balance -= amount;
                        Console.WriteLine($"Withdrawn ₹{amount}. New Balance: ₹{balance}");
                        transactionCount++;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid transaction type! Skipping.");
                    break;
            }
        }

        Console.WriteLine("\nTransaction limit reached (5 transactions).");
    }

    public static void ShowBalance()
    {
        Console.WriteLine($"Current Balance: ₹{balance}");
    }
}
