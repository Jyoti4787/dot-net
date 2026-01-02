// //using System;

// // class Program
// // {
    
// //         // Console.WriteLine("Creating Objects...");
// //         // for(int i = 0; i < 5; i++)
// //         // {
// //         //     MyClass obj=new MyClass();
// //         // }

// //         // Console.WriteLine("Forcing garbage collection...");
// //         // GC.Collect();
// //         // GC.WaitForPendingFinalizers();

// //         // Console.WriteLine("Garbage Collection Collected");

// //         // (int Id, string Name) student1 = (101, "Ravi");
// //         // var student2 = (Id: 102, Name: "Amit");

// //         // Console.WriteLine(student1.Id);
// //         // Console.WriteLine(student2.Name);

// //        static void Main()
// //         {
// //         // static (int sum, int Average, int difference) Calculate(int a, int b, int c)
// //         // {
// //         //     return (a + b + c, (a + b + c) / 3, a - b - c);
// //         // }
// //         // var result = Calculate(10, 5, 2);
// //         // Console.WriteLine(result.sum);
// //         // Console.WriteLine(result.Average);

// //         // static(bool IsValid, string Message) ValidateUser(string username)
// //         // {
// //         //     if (string.IsNullOrEmpty(username))
// //         //         return (false, "Username is required");

// //         //     return (true, "Valid user");
// //         // }

// //         // var response = ValidateUser("Admin");
// //         // Console.WriteLine(response.Message);

// //         // var person = (Id: 1, Name: "Neha");
// //         // Console.WriteLine(person.Id);
// //         // Console.WriteLine(person.Name);
// //         // var (id, name) = person;

// //         // Console.WriteLine(id);
// //         // Console.WriteLine(name);
// //         // Console.WriteLine(id.GetType());


// //         var person = (Id: 1, Name: "Janvi");
// //         var (_, username) = person;
// //         Console.WriteLine(username);


// //         }


// using System;
// using System.Linq;

// // class Student
// // {
// //     public int Id { get; set; }
// //     public string Name { get; set; }

// //     public void Deconstruct(out int id, out string name)
// //     {
// //         id = Id;
// //         name = Name;
// //     }
// // }

// class Program
// {
//     static void Main()
//     {
//         // var s = new Student { Id = 1, Name = "Amit" };

//         // Console.WriteLine(s.GetType());

//         // var (sid, sname) = s;

//         // Console.WriteLine(sid);
//         // Console.WriteLine(sname);


//         //int[] numbers = { 1, 2, 3,4, 5, 6,7, 8 };
//         // var evenNumbers = numbers.Where(n=> n%2==0);
//         // evenNumbers.GetType(); //IEnumerable interface
//         // Console.WriteLine("Even numbers are");
//         // foreach(var n in evenNumbers) {
//         //     Console.WriteLine(n);
//         // }

//         v
//     }
// }


// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Student
// {
//     public string Name { get; set; }
//     public int Marks { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
        
//         List<Student> students = new List<Student>
//         {
//             new Student { Name = "Amit", Marks = 75 },
//             new Student { Name = "Neha", Marks = 55 },
//             new Student { Name = "Ravi", Marks = 68 }
//         };

//         var result = students.Select(s => new
//         {
//             s.Name,
//             Grade = s.Marks > 60 ? "Pass" : "Fail"
//         });

        
//         foreach (var item in result)
//         {
//             Console.WriteLine(item.Name + " - " + item.Grade);
//         }

        
//         Console.WriteLine(result.GetType());
//     }
// }

using System;
using System.Collections.Generic;
using System.Linq;

// class Student
// {
//     public string Name { get; set; } = "";   // ✅ fixes CS8618
//     public int Marks { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
//         List<Student> students = new List<Student>
//         {
//             new Student { Name = "Amit", Marks = 75 },
//             new Student { Name = "Neha", Marks = 55 },
//             new Student { Name = "Ravi", Marks = 68 }
//         };

//         // OrderBy (Ascending)
//         var resultAsc = students
//             .OrderBy(s => s.Marks)
//             .Select(s => new
//             {
//                 s.Name,
//                 Grade = s.Marks > 60 ? "Pass" : "Fail"
//             })
//             .ToList();

//         Console.WriteLine("Ascending Order:");
//         foreach (var item in resultAsc)
//         {
//             Console.WriteLine(item.Name + " - " + item.Grade);
//         }

//         // OrderByDescending
//         var resultDesc = students
//             .OrderByDescending(s => s.Marks)
//             .Select(s => new
//             {
//                 s.Name,
//                 Grade = s.Marks > 60 ? "Pass" : "Fail"
//             })
//             .ToList();

//         Console.WriteLine("\nDescending Order:");
//         foreach (var item in resultDesc)
//         {
//             Console.WriteLine(item.Name + " - " + item.Grade);
//         }
//     }
// }


using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; } = "";
    public int Salary { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Amit", Salary = 50000 },
            new Employee { Name = "Ravi", Salary = 70000 },
            new Employee { Name = "Neha", Salary = 60000 }
        };

        
        var sortedBySalary = employees.OrderBy(e => e.Salary);

        foreach (var emp in sortedBySalary)
        {
            Console.WriteLine(emp.Name + " - " + emp.Salary);
        }
    }
}
