// using System;
// class Program
// {
//     public static void Main()
//     {
//         int[] numbers = new int[5];
//         numbers = [1,2,3,4,5];
//         foreach(int i in numbers)
//         {
//             Console.Write(i+" ");
//         }

//         int[,] matrix =
//         {
//             {1,2,5},
//             {3,4,8}
//         };
//         for(int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for(int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i,j]+" ");
//             }
//         }
//         int[][] jagged = new int[2][];
//         jagged[0] = new int[] {1,2};
//         jagged[1] = new int[] {3,4,5};
//         Console.Write(jagged[0][1]);
//     }
// }

// using System;

// class Program
// {
//     public static void Main()
//     {
//         int[] src = { 1, 2, 3 };          // source array
//         int[] dest = new int[3];          // destination array

//         // Copy only first 2 elements from src to dest
//         Array.Copy(src, dest, 2);

//         // foreach loop to print destination array
//         foreach (int i in dest)
//         {
//             Console.WriteLine(i);
//         }
//     }
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] nums = { 1, 2 };
//         int[] nums1= {1,2};

//         Array.Resize( ref nums, 1);

//         foreach (int i in nums)
//         {
//             Console.WriteLine(i);
//         }
//     }
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] nums = {10,15,20,25 };

//         bool found = Array.Exists(nums, x => x > 25);

//         Console.WriteLine(found);
//     }
// }


// using System;
// using System.Collections;

// class Program
// {
//     static void Main()
//     {
//         Stack stack = new Stack();

//         stack.Push(10);
//         stack.Push(20);

//         Console.WriteLine(stack.Pop()); 
//     }
// }

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // HashSet<int> set = new HashSet<int>();

//         // set.Add(10);
//         // set.Add(20);

//         // foreach (int i in set)
//         // {
//         //     Console.WriteLine(i);
//         // }

//         SortedList<string, string> list = new SortedList<string, string>();
//         list.Add("b","B");
//         list.Add("a","A");
//         Console.WriteLine(list["b"]);
//     }
// }

using System;
using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Dictionary<int, string> employees = new Dictionary<int, string>();

//         // employees.Add(101, "Amit");
//         // employees.Add(102, "Neha");
//         // employees.Add(103, "Rahul");

//         // foreach (KeyValuePair<int, string> emp in employees)
//         // {
//         //     Console.WriteLine(emp.Key + " " + emp.Value);
//         // }

//         int[] arr = { 1, 2, 3, 2, 1, 4, 2 };
//         Dictionary<int, int> map = new Dictionary<int, int>();

//         for (int i=0; i<arr.Length; i++)
//         {
//             if (map.ContainsKey(arr[i]))
//             {
//                 map[arr[i]]=map[arr[i]]+1;
//             }
//             else
//             {
//                 map.Add(arr[i], 1);
//             }
//         }

//         foreach (KeyValuePair<int, int> maping in map)
//         {
//             Console.WriteLine(maping.Key+" : "+maping.Value);
//         }



//     }
// }

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         int[] arr = { 1, 2, 3, 2, 1, 4, 2 };
//         Dictionary<int, int> freq = new Dictionary<int, int>();

//         foreach (int num in arr)
//         {
//             if (freq.ContainsKey(num))
//                 freq[num]++;
//             else
//                 freq[num] = 1;
//         }

//         foreach (var item in freq)
//         {
//             Console.WriteLine($"{item.Key} : {item.Value}");
//         }
//     }
// }



// using System;

// class Program
// {
//     public static string CleanAndInvert(string input)
//     {
//         if(string.IsNullOrEmpty(input)||input.Length<6)
//         return "";

//         foreach(char c in input)
//         {
//             if(!char.IsLetter(c))
//             return"";
//         }


//         input=input.ToLower();


//         string filtered="";
//         foreach (char c in input)
//         {
//             if((int)c%2!=0)
//             filtered+=c;
//         }


//         char[] arr=filtered.ToCharArray();
//         Array.Reverse(arr);


//         for(int i = 0; i < arr.Length; i++)
//         {
//             if(i%2==0)
//             arr[i]=char.ToUpper(arr[i]);
//         }

//         return new string(arr);
//     }

//     static void Main()
//     {
//         Console.WriteLine("Enter the word");
//         string input=Console.ReadLine();

//         string result=CleanAndInvert(input);

//         if(result=="")
//             Console.WriteLine("Invalid Input");
//         else
//             Console.WriteLine("The generated key is - "+result);
//     }
// }


//PAYROLL PRO
using System;
using System.Collections.Generic;
using System.Linq;

// BASE ABSTRACT CLASS 
public abstract class EmployeeRecord
{
    public string EmployeeName {get;set;}
    public double[] WeeklyHours {get;set;}

    public abstract double GetMonthlyPay();
}

// FULL TIME EMPLOYEE 
public class FullTimeEmployee : EmployeeRecord
{
    public double HourlyRate {get;set;}
    public double MonthlyBonus {get;set;}

    public override double GetMonthlyPay()
    {
        return WeeklyHours.Sum()*HourlyRate+MonthlyBonus;
    }
}

// CONTRACT EMPLOYEE
public class ContractEmployee:EmployeeRecord
{
    public double HourlyRate {get;set;}

    public override double GetMonthlyPay()
    {
        return WeeklyHours.Sum()*HourlyRate;
    }
}

// PAYROLL MANAGER 
public class PayrollManager
{
    public static List<EmployeeRecord> PayrollBoard = new List<EmployeeRecord>();

    public void RegisterEmployee(EmployeeRecord record)
    {
        PayrollBoard.Add(record);
    }

    public Dictionary<string,int> GetOvertimeWeekCounts(List<EmployeeRecord> records,double hoursThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (var emp in records)
        {
            int count = emp.WeeklyHours.Count(h => h >= hoursThreshold);
            if (count > 0)
                result.Add(emp.EmployeeName, count);
        }

        return result;
    }

    public double CalculateAverageMonthlyPay()
    {
        if (PayrollBoard.Count == 0)
            return 0;

        double total = 0;
        foreach (var emp in PayrollBoard)
        {
            total += emp.GetMonthlyPay(); // Polymorphism
        }

        return total / PayrollBoard.Count;
    }
}

// PROGRAM CLASS 
class Program
{
    static void Main()
    {
        PayrollManager manager = new PayrollManager();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Register Employee");
            Console.WriteLine("2. Show Overtime Summary");
            Console.WriteLine("3. Calculate Average Monthly Pay");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter your choice:");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Select Employee Type (1-Full Time, 2-Contract):");
                int type = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Enter Employee Name:");
                string name = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Enter Hourly Rate:");
                double rate = double.Parse(Console.ReadLine());

                double[] hours = new double[4];
                Console.WriteLine();
                Console.WriteLine("Enter weekly hours (Week 1 to 4):");
                for (int i = 0; i < 4; i++)
                {
                    hours[i] = double.Parse(Console.ReadLine());
                }

                if (type == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Monthly Bonus:");
                    double bonus = double.Parse(Console.ReadLine());

                    FullTimeEmployee ft = new FullTimeEmployee
                    {
                        EmployeeName = name,
                        HourlyRate = rate,
                        MonthlyBonus = bonus,
                        WeeklyHours = hours
                    };

                    manager.RegisterEmployee(ft);
                }
                else
                {
                    ContractEmployee ct = new ContractEmployee
                    {
                        EmployeeName = name,
                        HourlyRate = rate,
                        WeeklyHours = hours
                    };

                    manager.RegisterEmployee(ct);
                }

                Console.WriteLine();
                Console.WriteLine("Employee registered successfully");
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Enter hours threshold:");
                double threshold = double.Parse(Console.ReadLine());

                var result = manager.GetOvertimeWeekCounts(PayrollManager.PayrollBoard, threshold);

                Console.WriteLine();
                if (result.Count == 0)
                {
                    Console.WriteLine("No overtime recorded this month");
                }
                else
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.Key + " - " + item.Value);
                    }
                }
            }
            else if (choice == 3)
            {
                double avg = manager.CalculateAverageMonthlyPay();
                Console.WriteLine();
                Console.WriteLine("Overall average monthly pay: " + avg);
            }
            else if (choice == 4)
            {
                Console.WriteLine();
                Console.WriteLine("Logging off — Payroll processed successfully!");
                break;
            }
        }
    }
}
