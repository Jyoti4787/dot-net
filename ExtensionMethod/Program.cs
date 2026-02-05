using System;
using System.Collections.Generic;

public static class Extensions
{
    public static string[] DistinctById(this string[] items)
    {
        var seenIds = new HashSet<string>();
        var result = new List<string>();

        foreach (var item in items)
        {
            var parts = item.Split(':');
            if (parts.Length != 2) continue;

            string id = parts[0];
            string name = parts[1];

            if (!seenIds.Contains(id))
            {
                seenIds.Add(id);
                result.Add(name);
            }
        }

        return result.ToArray();
    }
}
class Program
{
    static void Main()
    {
        string[] items =
        {
            "1:Jyoti",
            "2:Kisan",
            "1:Anushka",
            "3:Sparsh",
            "2:Navneet"
        };

        var distinctNames = items.DistinctById();

        foreach (var name in distinctNames)
        {
            Console.WriteLine(name);
        }
    }
}
