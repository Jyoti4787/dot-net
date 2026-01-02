// using System;
// using System.Text.RegularExpressions;

// class Program
// {
//     public static void Main()
//     {
//         /*

//         // string patt = "\\d";   string patt = @"\d";

//         string patt = @"\d";   // @ = verbatim string, \d = regex digit
//         // string sen = "abc123";
//         string sen = "123_123";
//         bool res = Regex.IsMatch(sen,patt);
//         Console.WriteLine(res);


//         // Match m = Regex.Match("Amount", @"\d+");  // "5000" --> must find at least one digit, one or more digits
//         Match m = Regex.Match("Amount: 5000", @"\d*");     // "" --> matches empty string immediately, zero or more digits
//         // Match m = Regex.Match("10Amount: 5000", @"\d*");     // "10" --> matches empty string immediately, zero or more digits
//         Console.WriteLine(m);

//         */

//         // MatchCollection mat = Regex.Matches("10 20 30", @"\d+");  
//         // MatchCollection mat = Regex.Matches("10 20 30", @"\D");  
//         // MatchCollection mat = Regex.Matches("10A20B30C", @"\D");
//         // MatchCollection mat = Regex.Matches("10A20B30C", @"\w");
//         // MatchCollection mat = Regex.Matches("10A20B30C!@_", @"\w");
//         // MatchCollection mat = Regex.Matches("10A20B30C!@_abc", @"\w");
//         // MatchCollection mat = Regex.Matches("10A20B30C!@ _@ abc\t as@", @"\W");
//         // MatchCollection mat = Regex.Matches("10A20B30C!@ _@ abc\t as@", @"\s");   // white space
//         // MatchCollection mat = Regex.Matches("10A20B30C!@ _@ abc\t as@", @"\S");   // non - white space
//         // MatchCollection mat = Regex.Matches("10A20B30C!@ _@ abc\t as@ file.txt", @"\.txt");   
//         // MatchCollection mat = Regex.Matches("10A20B30C!@ _@ abc\t as@ file.txt", @"\.txt");   
//         // foreach (Match m in mat)
//         // {
//         //     Console.Write(m.Value + " ");
//         // }


//         // 13.
//         // Match m = Regex.Match("Date: 2025-12-29", @"(\d{4})-{}")

//         // string sen = "Amount=5000";
//         // string patt = @"Amount=(?<value>\d+)";
//         // Match mt = Regex.Match(sen,patt);
//         // Console.WriteLine(mt.Value);
//         // Console.WriteLine(mt.Groups["value"].Value);


//         // string input = "1992-02-23";
//         string input = "1992-02-01, 1992-02-23";

//         string pattern = @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";

//         Match m = Regex.Match(input, pattern);

//         Console.WriteLine(m.Groups["year"].Value);
//         Console.WriteLine(m.Groups["month"].Value);
//     }
// }


// using System;
// using System.Collections.Generic;
// using System.Text.RegularExpressions;

// class Program
// {
//     static void Main()
//     {
//         List<string> Emails = new List<string>
//         {
//             "john.doe@gmail.com",
//             "alice_123@yahoo.in",
//             "mark.smith@company.com",
//             "support-abc@banking.co.in",
//             "user.nametag@domain.org",
//             "john.doe@gmail",
//             "alice@@yahoo.com",
//             "mark.smith@.com",
//             "support@banking..com",
//             "user name@gmail.com",
//             "@domain.com",
//             "admin@domain",
//             "info@domain,com",
//             "finance#dept@corp.com",
//             "plainaddress"
//         };

//         string pattern = @"^[a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

//         foreach (string email in Emails)
//         {
//             bool isValid = Regex.IsMatch(email, pattern);
//             Console.WriteLine($"{email,-30} => {(isValid ? "Valid" : "Invalid")}");
//         }
//     }
// }


//Log Analysis Utility Using Regular Expressions in C#


using System;

 class Program
 {
    static void Main()
    {
        LogProcessing.LogParserCaller.LogParserCallerM();
    }
 }