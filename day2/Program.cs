// using System;

// namespace DotNetBasics
// {
//     class Program
//     {
//         static void Main()
//         {
//             // Console.WriteLine("Hello from Main method");
//             // Console.ReadLine();
//             // area of circle 
//              //AreaOfCircle.Calculate();

//              //largest of three
//              //Lot.Calculate();
            
//             //print table 
//             //

//             //game
//             //GameFlow.StartGame();
//             Console.ReadLine();
            
//         }
//     }
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         int choice;

//         do
//         {
//             Console.WriteLine("\n--- Finance Control System Menu ---");
//             Console.WriteLine("1. Check Loan Eligibility");
//             Console.WriteLine("2. Calculate Tax");
//             Console.WriteLine("3. Enter Transactions");
//             Console.WriteLine("4. Exit");
//             Console.Write("Enter your choice: ");
//             choice = Convert.ToInt32(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     LoanEligibility.CheckEligibility();
//                     break;
//                 case 2:
//                     IncomeTax.CalculateTax();
//                     break;
//                 case 3:
//                     Transaction.EnterTransactions();
//                     break;
//                 case 4:
//                     Console.WriteLine("Exiting system...");
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice! Please try again.");
//                     break;
//             }

//         } while (choice != 4);

//         Console.WriteLine("\nExit!");
//     }
// }


using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n Finance Management System ");
            Console.WriteLine("1. Debit Operations");
            Console.WriteLine("2. Credit Operations");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1: DebitMenu(); break;
                case 2: CreditMenu(); break;
                case 3: Console.WriteLine("Exiting program..."); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }

        } while (choice != 3);
    }

    static void DebitMenu()
    {
        Console.WriteLine("\n Debit Operations ");
        Console.WriteLine("1. ATM Withdrawal Check");
        Console.WriteLine("2. EMI Evaluation");
        Console.WriteLine("3. Daily Spending Calculation");
        Console.WriteLine("4. Minimum Balance Check");
        Console.Write("Enter choice: ");

        int option = int.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1: Debit.ATMWithdrawl(); break;
            case 2: Debit.EMICheck(); break;
            case 3: Debit.DailySpending(); break;
            case 4: Debit.MinimumBalance(); break;
            default: Console.WriteLine("Invalid option!"); break;
        }
    }

    static void CreditMenu()
    {
        Console.WriteLine("\n Credit Operations ");
        Console.WriteLine("1. Net Salary Calculation");
        Console.WriteLine("2. Fixed Deposit Maturity");
        Console.WriteLine("3. Reward Points Calculation");
        Console.WriteLine("4. Bonus Eligibility Check");
        Console.Write("Enter choice: ");

        int option = int.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1: Credit.NetSalary(); break;
            case 2: Credit.FixedDeposit(); break;
            case 3: Credit.RewardPoints(); break;
            case 4: Credit.BonusEligibility(); break;
            default: Console.WriteLine("Invalid option!"); break;
        }
    }
}




