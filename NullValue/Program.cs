using System;

public class Solution
{
    public static double? AverageNonNull(double?[] values)
    {
        double sum = 0;
        int count = 0;

        foreach (var v in values)
        {
            if (v.HasValue)
            {
                sum += v.Value;
                count++;
            }
        }

        if (count == 0)
            return null;

        double avg = sum / count;
        return Math.Round(avg, 2, MidpointRounding.AwayFromZero);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        double?[] arr = { 10.0, null, 20.0, 30.0 };

        var result = Solution.AverageNonNull(arr);

        if (result.HasValue)
            Console.WriteLine(result.Value);
        else
            Console.WriteLine("null");
    }
}
