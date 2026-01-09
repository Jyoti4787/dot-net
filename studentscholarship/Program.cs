using System;
using System.Collections.Generic;

// Delegate definition
public delegate bool IsEligibleforScholarship(Student std);

// Student class
public class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
    public char SportsGrade { get; set; }

    //  eligible students
    public static string GetEligibleStudents(
        List<Student> studentsList,
        IsEligibleforScholarship isEligible)
    {
        List<string> eligibleNames = new List<string>();

        foreach (Student std in studentsList)
        {
            if (isEligible(std))
            {
                eligibleNames.Add(std.Name);
            }
        }

        return string.Join(",", eligibleNames);
    }
}

// Program class
public class Program
{
    // Static eligibility method
    public static bool ScholarshipEligibility(Student std)
    {
        return std.Marks > 80 && std.SportsGrade == 'A';
    }

    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student { RollNo = 1, Name = "Deepak", Marks = 85, SportsGrade = 'A' },
            new Student { RollNo = 2, Name = "Jyoti", Marks = 75, SportsGrade = 'A' },
            new Student { RollNo = 3, Name = "Shivansh", Marks = 90, SportsGrade = 'B' },
            new Student { RollNo = 4, Name = "Shiva", Marks = 88, SportsGrade = 'A' }
        };

        IsEligibleforScholarship eligibilityCheck = ScholarshipEligibility;

        string result = Student.GetEligibleStudents(students, eligibilityCheck);
        Console.WriteLine(result);
    }
}



