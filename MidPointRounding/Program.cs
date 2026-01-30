using System;

public class Solution
{
    public static double GetCircleArea(double radius)
    {
        double area = Math.PI * radius * radius;
        return Math.Round(area, 2, MidpointRounding.AwayFromZero);
    }

    public static void Main(string[] args)
    {
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        input = input.Trim();
        if (double.TryParse(input, out double radius) && radius >= 0)
        {
            double area = GetCircleArea(radius);
            Console.WriteLine(area.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}
