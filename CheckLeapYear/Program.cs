 using System;
public class Solution
{
    /// <summary>
    /// Checks if a year is a leap year and prints the result.
    /// </summary>
    /// <param name="year">The year to check</param>
     public static void PrintLeapYearResult(int year)
    {
        if (IsLeapYear(year))
    {
        Console.WriteLine($"{year} is a leap year");
    }
    else
    {
        Console.WriteLine($"{year} is not a leap year");
    }
    }

    /// <summary>
    /// Determines whether a given year is a leap year.
    /// </summary>
    /// <param name="year">The year to check</param>
    /// <returns>True if the year is a leap year, false otherwise</returns>
    static bool IsLeapYear(int year)
    {
        // implement code here
        if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
                return true;
            else
                return false;
        }
        else
            return true;
    }
    else
        return false;
       
    }
}