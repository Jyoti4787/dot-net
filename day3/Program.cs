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

using System;

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

using System;

class Program
{
    static void Process()
    {
        string status = "Processing...";

        void PrintMsg()
        {
            Console.WriteLine(status);
        }

        PrintMsg();
    }

    static void Main()
    {
        Process();
    }
}
