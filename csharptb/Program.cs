using System;
using System.Text;

public class Solution
{
    static bool IsVowel(char c)
    {
        c = char.ToLower(c);
        return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
    }

    public static void Main(string[] args)
    {
        string? first = Console.ReadLine();
        string? second = Console.ReadLine();

        if (string.IsNullOrEmpty(first) || string.IsNullOrEmpty(second))
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        string secondLower = second.ToLowerInvariant();

        // Step 1: Remove common consonants
        StringBuilder step1 = new StringBuilder();

        foreach (char c in first)
        {
            char lowerC = char.ToLower(c);
            if (!IsVowel(lowerC) && secondLower.IndexOf(lowerC) >= 0)
            {
                continue; // skip common consonant
            }

            step1.Append(c);
        }

        // Step 2: Remove consecutive duplicates
        StringBuilder result = new StringBuilder();
        char prev = '\0';

        foreach (char c in step1.ToString())
        {
            if (c != prev)
            {
                result.Append(c);
                prev = c;
            }
        }

        Console.WriteLine(result.ToString());
    }
}
