using System;
using System.Text.RegularExpressions;

namespace LogProcessing
{
    class LogParser
    {
        private readonly string validLineRegexPattern = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
        private readonly string splitLineRegexPattern = @"<\*{3}>|<={4}>|<\^\*>";
        private readonly string quotedPasswordRegexPattern = "\"[^\"]*password[^\"]*\"";
        private readonly string endOfLineRegexPattern = @"end-of-line\d+";
        private readonly string weakPasswordRegexPattern = @"password[a-zA-Z0-9]+";


        // task 1 -> Validate Log Line Format
        public bool IsValidLine(string text)
        {
            if(string.IsNullOrEmpty(text))
            {
                return false;
            }
            return Regex.IsMatch(text, validLineRegexPattern);
        }

        // Task 2 -> Split Log Line Using Delimiters
        public string[] SplitLogLine(string text)
        {
            if (string.IsNullOrEmpty(text))
                return Array.Empty<string>();

            return Regex.Split(text, splitLineRegexPattern);
        }

        // Task 3 -> Count Quoted Password Occurrences
        public int CountQuotedPasswords(string lines)
        {
            if (string.IsNullOrEmpty(lines))
                return 0;

            MatchCollection matches = Regex.Matches(
                lines,
                quotedPasswordRegexPattern,
                RegexOptions.IgnoreCase
            );

            return matches.Count;
        }

        // Task 4 -> Remove End-of-Line Markers
        public string RemoveEndOfLineText(string line)
        {
            if (string.IsNullOrEmpty(line))
                return line;

            return Regex.Replace(line, endOfLineRegexPattern, "").Trim();
        }

        //  Task 5 -> Identify and Label Weak Passwords
        public string[] ListLinesWithPasswords(string[] lines)
        {
            if (lines == null)
                return Array.Empty<string>();

            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                Match match = Regex.Match(
                    lines[i],
                    weakPasswordRegexPattern,
                    RegexOptions.IgnoreCase
                );

                if (match.Success)
                {
                    result[i] = $"{match.Value}: {lines[i]}";
                }
                else
                {
                    result[i] = $"--------: {lines[i]}";
                }
            }

            return result;
        }

    }


    public class LogParserCaller
    {
        public static void LogParserCallerM()
        {
            LogParser parser = new LogParser();

            Console.WriteLine("---- Task 1: Validate Log Lines ----");
            Console.WriteLine(parser.IsValidLine("[INF] Application started"));   // True
            Console.WriteLine(parser.IsValidLine("[ABC] Invalid log"));           // False

            Console.WriteLine("\n---- Task 2: Split Log Line ----");
            string logLine = "User login<***>Password check<====>Access granted<^*>Session end";
            string[] parts = parser.SplitLogLine(logLine);
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }

            Console.WriteLine("\n---- Task 3: Count Quoted Passwords ----");
            string logs = "\"password\" failed\n\"PASSWORD123\" rejected\n\"user\" ok";
            Console.WriteLine("Quoted password count: " + parser.CountQuotedPasswords(logs));

            Console.WriteLine("\n---- Task 4: Remove End-of-Line Markers ----");
            string eolLine = "Process completed end-of-line45";
            Console.WriteLine(parser.RemoveEndOfLineText(eolLine));

            Console.WriteLine("\n---- Task 5: Identify Weak Passwords ----");
            string[] lines =
            {
                "User password123 failed login",
                "System started successfully",
                "Warning: passwordABC detected"
            };

            string[] result = parser.ListLinesWithPasswords(lines);
            foreach (string line in result)
            {
                Console.WriteLine(line);
            }
        }
    }
}
