using System;
using System.Globalization;
using System.Text;

public class Solution
{
    public static string CleanProductName(string input)
    {
        input = input.Trim();
        StringBuilder sb = new StringBuilder();
        char prev = '\0';

        foreach (char c in input)
        {
            if (c != prev)
            {
                sb.Append(c);
                prev = c;
            }
        }

        string cleaned = sb.ToString();
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        cleaned = textInfo.ToTitleCase(cleaned.ToLower());

        return cleaned;
    }

    public static void Main()
    {
        string input = " llapppptop bag ";
        Console.WriteLine(CleanProductName(input));
    }
}
