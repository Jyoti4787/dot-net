// using System;

// class BankAccount
// {
//     private int accountNumber;
//     private double balance;

//     public static string BankName = "State Bank of India";

//     // Constructor
//     public BankAccount(int accNo, double initialBalance)
//     {
//         accountNumber = accNo;
//         balance = initialBalance;
//     }

//     public void Deposit(double amount)
//     {
//         if (amount > 0)
//         {
//             balance += amount;
//             Console.WriteLine("Amount Deposited: " + amount);
//         }
//         else
//         {
//             Console.WriteLine("Invalid deposit amount");
//         }
//     }

//     public void Withdraw(double amount)
//     {
//         if (amount > 0 && amount <= balance)
//         {
//             balance -= amount;
//             Console.WriteLine("Amount Withdrawn: " + amount);
//         }
//         else
//         {
//             Console.WriteLine("Insufficient balance or invalid amount");
//         }
//     }

    
//     public void Display()
//     {
//         Console.WriteLine("Bank Name     : " + BankName);
//         Console.WriteLine("Account Number: " + accountNumber);
//         Console.WriteLine("Balance       : " + balance);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         BankAccount acc = new BankAccount(123456, 5000);

//         acc.Deposit(2000);
//         acc.Withdraw(1500);
//         acc.Display();

//         Console.ReadLine();
//     }
// }

// using System;

// class BankAccount
// {
//     private int accountNumber;
//     private double balance;

//     public static string BankName;

//     // Static Constructor
//     static BankAccount()
//     {
//         BankName = "State Bank of India";
//         Console.WriteLine("Static constructor called");
//     }

//     // Instance Constructor
//     public BankAccount(int accNo, double initialBalance)
//     {
//         accountNumber = accNo;
//         balance = initialBalance;
//         Console.WriteLine("Instance constructor called");
//     }

//     public void Display()
//     {
//         Console.WriteLine("Bank Name     : " + BankName);
//         Console.WriteLine("Account Number: " + accountNumber);
//         Console.WriteLine("Balance       : " + balance);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         BankAccount acc1 = new BankAccount(101, 5000);
//         acc1.Display();

//         Console.WriteLine();

//         BankAccount acc2 = new BankAccount(102, 8000);
//         acc2.Display();

//         Console.ReadLine();
//     }
// }


// using System;

// class Student
// {
//     // Private fields
//     private string name;
//     private int age;
//     private int marks;
//     private string password;

//     // PART A: Auto-Implemented Property
//     public int StudentId { get; set; }

//     // PART D: Normal Property - Name
//     public string Name
//     {
//         get
//         {
//             return name;
//         }
//         set
//         {
//             if (!string.IsNullOrEmpty(value))
//             {
//                 name = value;
//             }
//         }
//     }

//     // PART D: Normal Property - Age
//     public int Age
//     {
//         get
//         {
//             return age;
//         }
//         set
//         {
//             if (value > 0)
//             {
//                 age = value;
//             }
//         }
//     }

//     // PART D: Normal Property - Marks
//     public int Marks
//     {
//         get
//         {
//             return marks;
//         }
//         set
//         {
//             if (value >= 0 && value <= 100)
//             {
//                 marks = value;
//             }
//         }
//     }

//     // PART B: Read-Only Property
//     public string Result
//     {
//         get
//         {
//             return marks >= 40 ? "Pass" : "Fail";
//         }
//     }

//     // PART C: Write-Only Property
//     public string Password
//     {
//         set
//         {
//             if (value.Length >= 6)
//             {
//                 password = value;
//             }
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Student s = new Student();

//         s.StudentId = 101;
//         s.Name = "Jyoti";
//         s.Age = 20;
//         s.Marks = 78;
//         s.Password = "secure123";

//         Console.WriteLine("Student ID : " + s.StudentId);
//         Console.WriteLine("Name       : " + s.Name);
//         Console.WriteLine("Age        : " + s.Age);
//         Console.WriteLine("Marks      : " + s.Marks);
//         Console.WriteLine("Result     : " + s.Result);
//     }
// }


using System;
using System.Collections.Generic;
using System.Linq;

class EmployeeDirectory
{
    private Dictionary<int, string> employees = new Dictionary<int, string>();

    public string this[int id]
    {
        get
        {
            return employees.ContainsKey(id) ? employees[id] : "Employee ID not found";
        }
        set
        {
            employees[id] = value;
        }
    }
    public string this[string name]
    {
        get
        {
            return employees.FirstOrDefault(e => e.Value == name).Value
                   ?? "Employee name not found";
        }
    }
}

class Program
{
    static void Main()
    {
        EmployeeDirectory directory = new EmployeeDirectory();

        directory[101] = "Jyoti";
        directory[102] = "Amit";
        directory[103] = "Riya";

       
        Console.WriteLine(directory[101]);
        Console.WriteLine(directory[102]);

     
        Console.WriteLine(directory["Jyoti"]);

       
        Console.WriteLine(directory["Rahul"]);
    }
}
