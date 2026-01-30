using System;

public class Solution
{
    public static string GetHeightCategory(int heightCm)
    {
        if (heightCm < 150)
            return "Short";
        else if (heightCm < 180)
            return "Average";
        else
            return "Tall";
    }

    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        if (int.TryParse(input, out int heightCm))
        {
            string category = GetHeightCategory(heightCm);
            Console.WriteLine(category);
        }
    }
}
