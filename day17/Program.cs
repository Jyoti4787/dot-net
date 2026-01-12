// using System;
// using System.Diagnostics;

// class Program
// {
//     static void Main()

//     {
//         Trace.Listeners.Add(new ConsoleTraceListener());
//         Trace.WriteLine("Application started");

//         int a = 10;
//         int b = 0;

//         try
//         {
//             int result = a / b;
//             Console.WriteLine(result);
//         }
//         catch (Exception ex)
//         {
//             Trace.WriteLine("Exception occurred: " + ex.Message);
//         }

//         Trace.WriteLine("Application ended");
//     }
// }


// using System;
// using System.Diagnostics;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Add a listener so Trace output appears in the console
//         Trace.Listeners.Add(new ConsoleTraceListener());

//         Trace.WriteLine("Program started");
//         //Logs the start of the program

//         PerformCalculation(10, 5);
//         PerformCalculation(10, 0);   // Error case
//         //First call → valid division
//         // Second call → division by zero scenario
//         // This helps demonstrate error detection using Trace
//         int total = 0;

//         for (int i = 1; i <= 5; i++)
//         {
//              total += i;
//        }

//         Trace.WriteLine("Program ended");
//         //Program End Log
//     }

//     static void PerformCalculation(int a, int b)
//     {
//         Trace.WriteLine($"Entering PerformCalculation | a={a}, b={b}");

//         //Error Detection (Root Cause Logging)
//         //Prevents application crash
//         // Logs the exact reason of failure
//         // This log is crucial for Root Cause Analysis

//         if (b == 0)
//         {
//             Trace.WriteLine("Error: Division by zero detected");
//             Trace.WriteLine("Exiting PerformCalculation due to error");
//             return;
//         }

//         //Calling Divide Method
//         int result = Divide(a, b);

//         //Successful Calculation Log
//         Trace.WriteLine($"Calculation successful | Result={result}");
//         Trace.WriteLine("Exiting PerformCalculation");
//     }

//     static int Divide(int x, int y)
//     {
//         //Divide Method Logging
//         Trace.WriteLine($"Dividing values | x={x}, y={y}");
//         return x / y;
//     }
// }

// using System;
// using System.Diagnostics;

// class Program
// {
//     static void Main()
//     {
//         int total = 0;

//         for (int i = 1; i <= 5; i++)
//         {
//             total += i;
//         }

//         Console.WriteLine(total);
//     }
// }


// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // FOR LOOP 
//         Console.WriteLine("FOR LOOP DEBUGGING");
//         int[] items = new int[300];

//         for (int i = 0; i < items.Length; i++)
//         {
//             items[i] = i;
//             Process(items[i]);   //  Conditional breakpoint: items[i] == 250
//         }

//         //  FOREACH LOOP 
//         Console.WriteLine("\nFOREACH LOOP DEBUGGING");
//         List<User> users = new List<User>
//         {
//             new User { Name = "Ravi", Age = 45 },
//             new User { Name = "Meena", Age = 62 },
//             new User { Name = "Amit", Age = 70 }
//         };

//         foreach (var user in users)
//         {

//             Validate(user);   // Conditional breakpoint: user.Age > 60
//         }

//         //  WHILE LOOP 
//         Console.WriteLine("\nWHILE LOOP DEBUGGING");
//         Queue<int> queue = new Queue<int>();

//         queue.Enqueue(10);
//         queue.Enqueue(20);
//         queue.Enqueue(30);

//         while (queue.Count > 0)
//         {
//             Process(queue.Dequeue());   //  Conditional breakpoint: queue.Count == 1
//         }

//         Console.WriteLine("\nProgram completed");
//     }

//     static void Process(int value)
//     {
//         Console.WriteLine("Processing value: " + value);
//     }

//     static void Validate(User user)
//     {
//         Console.WriteLine($"Validating user: {user.Name}, Age: {user.Age}");
//     }
// }

// class User
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
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
//         // Creating three student objects
//         List<Student> students = new List<Student>()
//         {
//             new Student { Name = "Jyoti", Marks = 72 },
//             new Student { Name = "Akriti", Marks = 55 },
//             new Student { Name = "Sus", Marks = 68 }
//         };

//         //  DATA SHAPING USING LINQ 
//         var result = students.Select(s => new
//         {
//             s.Name,
//             Grade = s.Marks > 60 ? "Pass" : "Fail"
//         });

//         Console.WriteLine("Shaped Data:");
//         foreach (var item in result)
//         {
//             Console.WriteLine(item.Name + " - " + item.Grade);
//         }

//         // Type of result
//         Console.WriteLine("\nType of result:");
//         Console.WriteLine(result.GetType());
//     }
// }

// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Employee
// {
//     public string Name { get; set; }
//     public int Salary { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
//         List<Employee> employees = new List<Employee>
//         {
//             new Employee { Name = "Amit", Salary = 60000 },
//             new Employee { Name = "Ravi", Salary = 70000 },
//             new Employee { Name = "Neha", Salary = 60000 },
//             new Employee { Name = "Anu", Salary = 70000 },
//             new Employee { Name = "Sonal", Salary = 80000 }
//         };

//         // Sort employees
//         var sortedEmployees = employees
//                               .OrderBy(e => e.Salary)
//                               .ThenBy(e => e.Name);

//         //  WITHOUT CONDITION 
//         Employee firstEmployee = sortedEmployees.First();
//         Employee lastEmployee  = sortedEmployees.Last();

//         Console.WriteLine("WITHOUT CONDITION:");
//         Console.WriteLine("First Employee: " + firstEmployee.Name + " - " + firstEmployee.Salary);
//         Console.WriteLine("Last Employee : " + lastEmployee.Name + " - " + lastEmployee.Salary);

//         //  WITH CONDITION 
//         Employee firstWithCondition =
//             sortedEmployees.First(e => e.Salary >= 70000);

//         Employee lastWithCondition =
//             sortedEmployees.Last(e => e.Salary <= 60000);

//         Console.WriteLine("\nWITH CONDITION:");
//         Console.WriteLine("First Salary >= 70000: " +
//                           firstWithCondition.Name + " - " + firstWithCondition.Salary);

//         Console.WriteLine("Last Salary <= 60000 : " +
//                           lastWithCondition.Name + " - " + lastWithCondition.Salary);

//         //  SINGLE 
//         Employee singleEmployee =
//             sortedEmployees.Single(e => e.Salary == 80000);

//         Console.WriteLine("\nSINGLE:");
//         Console.WriteLine("Employee with Salary = 80000: " +
//                           singleEmployee.Name + " - " + singleEmployee.Salary);
//     }
// }

// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Employee
// {
//     public int EmpId{get; set;}
//     public string Name{get; set;}
//     public int DeptId{get; set;}
//     public int Salary{get; set;}
// }

// class Department
// {
//     public int DeptId { get; set; }
//     public string DeptName { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
//         List<Employee> employees = new List<Employee>
//         {
//             new Employee { EmpId = 1, Name = "Amit", DeptId = 1, Salary = 60000 },
//             new Employee { EmpId = 2, Name = "Abhay", DeptId = 2, Salary = 70000 },
//             new Employee { EmpId = 3, Name = "Ujjwal", DeptId = 1, Salary = 80000 },
//             new Employee { EmpId = 4, Name = "Kisan", DeptId = 2, Salary = 50000 },
//             new Employee { EmpId = 5, Name = "Jyoti", DeptId = 3, Salary = 90000 },
//         };

//         List<Department> departments = new List<Department>
//         {
//             new Department { DeptId = 1, DeptName = "HR" },
//             new Department { DeptId = 2, DeptName = "IT" },
//             new Department { DeptId = 3, DeptName = "Finance" },
//         };

//         //GroupBy
//         Console.WriteLine("GROUP BY (Employees by Department):");
//         var groupByDept = employees.GroupBy(e => e.DeptId);
//         foreach (var group in groupByDept)
//         {
//             Console.WriteLine("DeptId: " + group.Key);
//             foreach (var emp in group)
//                 Console.WriteLine("  " + emp.Name);
//         }

//         //ToLookUp
//         Console.WriteLine("\nTOLOOKUP (Employees by Department):");
//         var lookupDept = employees.ToLookup(e => e.DeptId);
//         foreach (var group in lookupDept)
//         {
//             Console.WriteLine("DeptId: " + group.Key);
//             foreach (var emp in group)
//                 Console.WriteLine("  " + emp.Name);
//         }

//         //Join
//         Console.WriteLine("\nJOIN (Employee with Department):");

//         var joinResult =
//             employees.Join(
//                 departments,
//                 e => e.DeptId,
//                 d => d.DeptId,
//                 (e, d) => new { e.Name, d.DeptName }
//             );

//         foreach (var item in joinResult)
//             Console.WriteLine(item.Name + " works in " + item.DeptName);

//         //GroupJoin
//         Console.WriteLine("\nGROUP JOIN (Departments with Employees):");

//         var groupJoinResult =
//             departments.GroupJoin(
//                 employees,
//                 d => d.DeptId,
//                 e => e.DeptId,
//                 (d, emps) => new { d.DeptName, Employees = emps }
//             );

//         foreach (var dept in groupJoinResult)
//         {
//             Console.WriteLine(dept.DeptName + ":");
//             foreach (var emp in dept.Employees)
//                 Console.WriteLine("  " + emp.Name);
//         }

//     }

// }

//LINQ-Based Autonomous Robot Sensor Fusion & AI Decision System

using System;
using System.Collections.Generic;
using System.Linq;

namespace AutonomousRobot.AI
{
    //Represent one sensor reading
    public class SensorReading
    {
        public int SensorId{get; set;}
        public string Type{get; set;}            // Distance, Battery, Temperature, Vibration
        public double Value{get; set;}           //Sensor value
        public DateTime Timestamp{get; set;}     //Time of reading
        public double Confidence{get; set;}      //Reliability of sensor
    }

    //possible robotic actions
    public enum RobotAction
    {
        Stop,
        SlowDown,
        Reroute,
        Continue
    }

    //Contains all LINQ-based decision logic
    public class DecisionEngine
    {
        //T1: Get readings after a given time
        public List<SensorReading> GetRecentReadings(List<SensorReading> sensorHistory, DateTime fromTime)
        {
            return sensorHistory
                .Where(r => r.Timestamp >= fromTime)
                .ToList();
        }

        //T2: Check if battery is critical
        public bool IsBatteryCritical(List<SensorReading> readings)
        {
            return readings.Any(r => r.Type == "Battery" && r.Value < 20);
        }

        //T3: Find nearest obstacle distance
         public double GetNearestObstacleDistance(List<SensorReading> readings)
        {
            return readings
                   .Where(r => r.Type == "Distance")
                   .Select(r => r.Value)
                   .DefaultIfEmpty(Double.MaxValue)
                   .Min();
        }

        //T4: Check temperature safety
        public bool IsTemperatureSafe(List<SensorReading> readings)
        {
            return readings
                   .Where(r => r.Type == "Temperature")
                   .All(r => r.Value < 90);
        }

        //T5: Calculate average vibration
        public double GetAverageVibration(List<SensorReading> readings)
        {
            return readings
                   .Where(r => r.Type == "Vibration")
                   .Select(r => r.Value)
                   .DefaultIfEmpty(0)
                   .Average();
        }

        //T6: Average confidence per sensor type
        public Dictionary<string, double> CalculateSensorHealth(
            List<SensorReading> sensorHistory)
        {
            return sensorHistory
                   .GroupBy(r => r.Type)
                   .ToDictionary(
                       g => g.Key,
                       g => g.Average(r => r.Confidence)
                   );
        }

        //T7: Detect faulty sensors(low confidence)
        public List<string> DetectFaultySensors(List<SensorReading> sensorHistory)
        {
            return sensorHistory
                    .GroupBy(r => r.Type)
                    .Where(g => g.Count(r => r.Confidence < 0.4) > 2)
                    .Select(g => g.Key)
                    .ToList();
        }

        //T8: Check fast battery drain trend
        public bool IsBatteryDrainingFast(List<SensorReading> sensorHistory)
        {
            var values = sensorHistory
                .Where(r => r.Type == "Battery")
                .OrderBy(r => r.Timestamp)
                .Select(r => r.Value)
                .ToList();

            return values
                   .Zip(values.Skip(1), (a, b) => b < a)
                   .All(x => x);
        }

        //T9: Confidence-weighted distance
        public double GetWeightedDistance(List<SensorReading> readings)
        {
            var distances = readings.Where(r => r.Type == "Distance");
            double totalConfidence = distances.Sum(r => r.Confidence);

            if (totalConfidence == 0)
                return Double.MaxValue;

            return distances.Sum(r => r.Value * r.Confidence)
                   / totalConfidence;
        }

        //T10: Decide robot action
        public RobotAction DecideRobotAction(
            List<SensorReading> recentReadings,
            List<SensorReading> sensorHistory)
        {
            if (IsBatteryCritical(recentReadings))
                return RobotAction.Stop;

            if (GetNearestObstacleDistance(recentReadings) < 1.0)
                return RobotAction.Reroute;

            if (!IsTemperatureSafe(recentReadings) ||
                GetAverageVibration(recentReadings) > 7.0)
                return RobotAction.SlowDown;

            return RobotAction.Continue;
        }
    }

    class Program
    {
        static void Main()
        {
            // Sample sensor history
            List<SensorReading> sensorHistory = new List<SensorReading>
            {
                new SensorReading { SensorId=1, Type="Distance", Value=0.8, Confidence=0.9, Timestamp=DateTime.Now.AddSeconds(-5) },
                new SensorReading { SensorId=2, Type="Battery", Value=18, Confidence=0.8, Timestamp=DateTime.Now.AddSeconds(-4) },
                new SensorReading { SensorId=3, Type="Temperature", Value=92, Confidence=0.7, Timestamp=DateTime.Now.AddSeconds(-3) },
                new SensorReading { SensorId=4, Type="Vibration", Value=8.2, Confidence=0.6, Timestamp=DateTime.Now.AddSeconds(-2) },
                new SensorReading { SensorId=5, Type="Battery", Value=75, Confidence=0.9, Timestamp=DateTime.Now.AddSeconds(-1) },
                new SensorReading { SensorId=6, Type="Distance", Value=2.5, Confidence=0.5, Timestamp=DateTime.Now }
            };
            DecisionEngine engine = new DecisionEngine();
            DateTime fromTime = DateTime.Now.AddSeconds(-10);

            // STRICT execution order
            var recentReadings = engine.GetRecentReadings(sensorHistory, fromTime);
            engine.IsBatteryCritical(recentReadings);
            engine.GetNearestObstacleDistance(recentReadings);
            engine.IsTemperatureSafe(recentReadings);
            engine.GetAverageVibration(recentReadings);
            engine.CalculateSensorHealth(sensorHistory);
            engine.DetectFaultySensors(sensorHistory);
            engine.IsBatteryDrainingFast(sensorHistory);
            engine.GetWeightedDistance(recentReadings);

            RobotAction action =
                engine.DecideRobotAction(recentReadings, sensorHistory);

            Console.WriteLine("Robot Action: " + action);
        }
    }


}