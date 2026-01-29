using System;
using System.Collections.Generic;

namespace CustomSortingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Jyoti", Age = 20, Marks = 85 },
                new Student { Name = "Deepak", Age = 18, Marks = 85 },
                new Student { Name = "Shivansh", Age = 22, Marks = 90 },
                new Student { Name = "Srikaran", Age = 19, Marks = 90 },
                new Student { Name = "Aditya", Age = 23, Marks = 91 }
            };
            students.Sort(new StudentComparer());

            Console.WriteLine("Sorted Students:");
            foreach (var student in students)
            {
                Console.WriteLine(
                    $"Name: {student.Name}, Age: {student.Age}, Marks: {student.Marks}"
                );
            }

            Console.ReadLine();
        }
    }
}
