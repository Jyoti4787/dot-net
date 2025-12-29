// using System;
// using System.Collections.Generic;
// public class CreatorStats
// {
//     public string CreatorName { get; set; }
//     public double[] WeeklyLikes { get; set; }
// }

// public class Program
// {
//     // Given template requirement
//     public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();
//     // Registers a creator
//     public void RegisterCreator(CreatorStats record)
//     {
//         EngagementBoard.Add(record);
//     }
//     // Counts weeks where likes >= threshold
//     public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
//     {
//         Dictionary<string, int> result = new Dictionary<string, int>();
//         for (int i=0;i<records.Count;i++)
//         {
//             int count=0;
//             for(int j=0;j<records[i].WeeklyLikes.Length;j++)
//             {
//                 if(records[i].WeeklyLikes[j]>=likeThreshold)
//                 {
//                     count++;
//                 }
//             }
//             if(count>0)
//             {
//                 result.Add(records[i].CreatorName, count);
//             }
//         }
//         return result;
//     }
//     // Calculates overall average likes
//     public double CalculateAverageLikes()
//     {
//         double totalLikes = 0;
//         int totalWeeks = 0;

//         for (int i=0;i<EngagementBoard.Count;i++)
//         {
//             for (int j=0;j<EngagementBoard[i].WeeklyLikes.Length;j++)
//             {
//                 totalLikes+=EngagementBoard[i].WeeklyLikes[j];
//                 totalWeeks++;
//             }
//         }
//         if(totalWeeks==0)
//             return 0;
//         return totalLikes/totalWeeks;
//     }
//     static void Main()
//     {
//         Program app=new Program();
//         bool running=true;
//         while (running)
//         {
//             Console.WriteLine();
//             Console.WriteLine("1. Register Creator");
//             Console.WriteLine("2. Show Top Posts");
//             Console.WriteLine("3. Calculate Average Likes");
//             Console.WriteLine("4. Exit");
//             Console.Write("Enter your choice:\n");
//             string choice = Console.ReadLine();
//             switch (choice)
//             {
//                 case "1":
//                     CreatorStats creator = new CreatorStats();
//                     Console.WriteLine("Enter Creator Name:");
//                     creator.CreatorName = Console.ReadLine();
//                     creator.WeeklyLikes = new double[4];
//                     Console.WriteLine("Enter weekly likes (Week 1 to 4):");
//                     for (int i=0;i<4;i++)
//                     {
//                         creator.WeeklyLikes[i] = double.Parse(Console.ReadLine());
//                     }
//                     app.RegisterCreator(creator);
//                     Console.WriteLine("Creator registered successfully");
//                     break;
//                 case "2":
//                     Console.WriteLine("Enter like threshold:");
//                     double threshold = double.Parse(Console.ReadLine());
//                     Dictionary<string, int> topPosts =
//                         app.GetTopPostCounts(EngagementBoard, threshold);
//                     if (topPosts.Count==0)
//                     {
//                         Console.WriteLine("No top-performing posts this week");
//                     }
//                     else
//                     {
//                         foreach (KeyValuePair<string, int> entry in topPosts)
//                         {
//                             Console.WriteLine(entry.Key + " - " + entry.Value);
//                         }
//                     }
//                     break;
//                 case "3":
//                     double avg = app.CalculateAverageLikes();
//                     Console.WriteLine("Overall average weekly likes: " + avg);
//                     break;
//                 case "4":
//                     Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
//                     running = false;
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice");
//                     break;
//             }
//         }
//     }
// }


//exception handling

// using System;

// class Program
// {
//     static void Main()
//     {
//         int a = 10;
//         int b = 0;

//         try
//         {
//             int result = a / b;   
//             Console.WriteLine("Result: " + result);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("Error occurred: " + ex.Message);
//         }

//         Console.WriteLine("Program executed successfully.");
//     }
// }


using System;
using System.IO;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message) { }
}

class BankAccount
{
    public decimal Balance { get; private set; } = 5000;

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be greater than zero.");

        if (amount > Balance)
            throw new InsufficientBalanceException("Insufficient balance.");

        Balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // 1 FormatException
            Console.WriteLine("Enter withdrawal amount:");
            decimal amount = decimal.Parse(Console.ReadLine());

            // 2 DivideByZeroException (intentional)
            int serviceCharge = 100;
            int divisionCheck = serviceCharge / int.Parse("0");

            // 3 FileNotFoundException
            string data = File.ReadAllText("account.txt");

            // 4 Business Logic
            BankAccount account = new BankAccount();
            account.Withdraw(amount);

            Console.WriteLine("Withdrawal successful");
        }
        catch (FormatException ex)
        {
            LogException(ex);
            Console.WriteLine("Invalid input format.");
        }
        catch (DivideByZeroException ex)
        {
            LogException(ex);
            Console.WriteLine("Arithmetic error occurred.");
        }
        catch (FileNotFoundException ex)
        {
            LogException(ex);
            Console.WriteLine("Required file not found.");
        }
        catch (InsufficientBalanceException ex)
        {
            LogException(ex);
            Console.WriteLine("Business rule violation.");
        }
        catch (Exception ex)
        {
            LogException(ex);
            Console.WriteLine("Unexpected error occurred.");
        }
        finally
        {
            Console.WriteLine("Transaction process completed.");
        }
    }

    static void LogException(Exception ex)
    {
        Console.WriteLine("LOG: " + ex.Message);
    }
}

