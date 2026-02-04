using System;

public class Merger
{
    public static T[] MergeSorted<T>(T[] a, T[] b) where T : IComparable<T>
    {
        int n = a?.Length ?? 0;
        int m = b?.Length ?? 0;

        T[] merged = new T[n + m];

        int i = 0, j = 0, k = 0;

        // Merge while both arrays have elements
        while (i < n && j < m)
        {
            if (a[i].CompareTo(b[j]) <= 0)
            {
                merged[k++] = a[i++];
            }
            else
            {
                merged[k++] = b[j++];
            }
        }

        // Copy remaining elements of a[]
        while (i < n)
        {
            merged[k++] = a[i++];
        }

        // Copy remaining elements of b[]
        while (j < m)
        {
            merged[k++] = b[j++];
        }

        return merged;
    }

    // Example usage
    public static void Main()
    {
        int[] a = { 1, 4, 7 };
        int[] b = { 2, 3, 9 };

        var result = MergeSorted(a, b);

        Console.WriteLine(string.Join(", ", result));
        // Output: 1, 2, 3, 4, 7, 9
    }
}
