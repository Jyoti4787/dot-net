// using System;
// using System.Data.Common;
// class Wallet
// {
//     public double money;
//     public void addmoney(double amt)
//     {
//         Console.WriteLine("Amount is added");
//         money+=amt;
//     }
//     public double GetBalance()
//     {
//         return money;
//     }
// }
// class Bank
// {
//     public int accname;
//     private double balance = 50000;
//     public void Deposite(double amount)
//     {
//         balance += amount;
//         Console.WriteLine("updated balance is " + balance);
//     }

// }
// class employee
// {
//     public int id;
//     public string name;
//     public float salary;

//     public void display()
//     {
//         Console.WriteLine("ID: " + id);
//         Console.WriteLine("Name: " + name);
//         Console.WriteLine("Salary: " + salary);
//     }
// }
// class Program
// {
//     static void Main()
//     {
        // employee emp = new employee();
        // emp.id = 24;
        // emp.name = "ramu setii";
        // emp.salary = 450000;
        // emp.display();
        // Bank bn = new Bank();
        // bn.Deposite(50000);
        // Wallet wal = new Wallet();
        // wal.money = 1000;
        // wal.addmoney(2000);
        // double total  = wal.GetBalance();
        //Console.WriteLine("Updated money is  = "+ total);

        // string name = "jyoti";
        // foreach(char c in name)
        // {
        //     Console.WriteLine(c);
        // }

//         Params.sum(1,2,3,4);

//     }

//  }

//using System;

// class Calculator
// {
//     public static void Divide(int a, int b, out int quotient, out int remainder)
//     {
//         quotient = a / b;
//         remainder = a % b;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         int q, r;   
//         Calculator.Divide(10, 3, out q, out r);

//         Console.WriteLine("Quotient = " + q);
//         Console.WriteLine("Remainder = " + r);
//     }
// }


// class Student
// {
//     public static void GetResult(int marks, out string grade)
//     {
//         if (marks >= 60)
//             grade = "Pass";
//         else
//             grade = "Fail";
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         string result;

//         Student.GetResult(75, out result);

//         Console.WriteLine(result);
//     }
// }

//using System;

// class Test
// {
    
//     static void Show(params int[] a, params int[] b)
//     {
//     }

//     static void Main()
//     {
//         Show(1, 2, 3);
//     }
// }

// using System;

// class Program
// {
//     static int Sum(int a = 10, params int[] num)
//     {
//         int total = 0;

//         foreach (int i in num)
//         {
//             total += i;
//         }

//         total += a;
//         return total;
//     }

//     static void Main()
//     {
//         Console.WriteLine(Sum());    
//         Console.WriteLine(Sum(1,2));                
//         Console.WriteLine(Sum(1,2,3));    
// }
// }

//using System;

// class Program
// {
//     static void Process()
//     {
//         string status = "Processing...";

//         void PrintMsg()
//         {
            
//             Console.WriteLine(status);
//         }

//         PrintMsg();
//     }

//     static void Main()
//     {
//         Process();
//     }
// }

// using System;

// class BankAccount
// {
//     private int accountNo;
//     private double balance;

//     public static string BankName = "State Bank of India";

//     // Constructor
//     public BankAccount(int accNo, double initialBalance)
//     {
//         accountNo = accNo;
//         balance = initialBalance;
//     }

//     // Deposit using ref
//     public void Deposit(ref double amount)
//     {
//         balance += amount;
//         Console.WriteLine("Amount Deposited Successfully.");
//     }

//     // Deposit using out (method overloading)
//     public void Deposit(string inputAmount, out bool status)
//     {
//         status = double.TryParse(inputAmount, out double amount);
//         if (status && amount > 0)
//         {
//             balance += amount;
//             Console.WriteLine("Amount Deposited Successfully.");
//         }
//         else
//         {
//             Console.WriteLine("Invalid deposit amount.");
//         }
//     }

//     public void Withdraw(double amount)
//     {
//         if (amount <= balance && amount > 0)
//         {
//             balance -= amount;
//             Console.WriteLine("Withdrawal Successful.");
//         }
//         else
//         {
//             Console.WriteLine("Insufficient balance or invalid amount.");
//         }
//     }

//     public void Display()
//     {
//         Console.WriteLine("Bank Name   : " + BankName);
//         Console.WriteLine("Account No : " + accountNo);
//         Console.WriteLine("Balance    : " + balance);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter Account Number: ");
//         int accNo = int.Parse(Console.ReadLine()!);

//         Console.Write("Enter Initial Balance: ");
//         double initialBalance = double.Parse(Console.ReadLine()!);

//         BankAccount account = new BankAccount(accNo, initialBalance);

//         int choice;
//         do
//         {
//             Console.WriteLine("\n1. Deposit");
//             Console.WriteLine("2. Withdraw");
//             Console.WriteLine("3. Display Balance");
//             Console.WriteLine("4. Exit");
//             Console.Write("Enter choice: ");
//             int.TryParse(Console.ReadLine(), out choice);

//             switch (choice)
//             {
//                 case 1:
//                     Console.Write("Enter amount to deposit: ");
//                     string depAmount = Console.ReadLine()!;
//                     account.Deposit(depAmount, out bool success);
//                     break;

//                 case 2:
//                     Console.Write("Enter amount to withdraw: ");
//                     double.TryParse(Console.ReadLine(), out double wAmount);
//                     account.Withdraw(wAmount);
//                     break;

//                 case 3:
//                     account.Display();
//                     break;

//                 case 4:
//                     Console.WriteLine("Thank you!");
//                     break;

//                 default:
//                     Console.WriteLine("Invalid choice.");
//                     break;
//             }
//         } while (choice != 4);
//     }
// }

// constructor


using System;
using Project2.Core;
using Project2.Services;
using Project2.Utilities;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hospital Name: " + HospitalConfig.HospitalName);

        Cardiologist cardiologist = new Cardiologist(
            "Dr Mehta",
            "LIC-99999",
            15
        );

        Console.WriteLine("Total Doctors (via child class): " + Cardiologist.TotalDoctors);

        Console.WriteLine("Doctor Name: " + cardiologist.Name);
        Console.WriteLine("Specialization: " + cardiologist.Specialization);
        Console.WriteLine("License Number: " + cardiologist.LicenseNumber);
        Console.WriteLine("Experience Years: " + cardiologist.ExperienceYears);

        Doctor d2 = new Doctor("Dr Sharma", "Physician", "LIC-12345");

        Console.WriteLine("Updated Total Doctors (via child class): "
            + Cardiologist.TotalDoctors);
    }
}

//static member: cardiolosit.TotalDoctors
//non static members: cardiologist.Name
//cardiologist.Specialization

