using System;
using System.Collections.Generic;

public class Solution
{
    public static int GetTotalSalary(List<int> ids, Dictionary<int, int> salaryDict)
    {
        int total = 0;

        foreach (int id in ids)
        {
            if (salaryDict.ContainsKey(id))
            {
                total += salaryDict[id];
            }
        }

        return total;
    }

    public static void Main()
    {
        List<int> ids = new List<int> { 1, 4, 5 };
        Dictionary<int, int> salaryDict = new Dictionary<int, int>
        {
            {1, 20000},
            {4, 40000},
            {5, 15000}
        };

        int result = GetTotalSalary(ids, salaryDict);
        Console.WriteLine(result);
    }
}

