using System;
using System.IO;

public class Solution
{
    public static void Main()
    {
        string inputPath = "log.txt";
        string outputPath = "error.txt";
        try
        {
            if (!File.Exists(inputPath))
            {
                Console.WriteLine($"Input file '{inputPath}' not found.");
                return;
            }

            using (var reader = new StreamReader(inputPath))
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("ERROR"))
                    {
                        writer.WriteLine(line);
                    }
                }
            }

            Console.WriteLine("ERROR logs extracted to error.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

