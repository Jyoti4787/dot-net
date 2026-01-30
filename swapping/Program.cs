//Method 1 — using ref

// using System;

// public class Solution
// {
//     static void SwapRef(ref int a, ref int b)
//     {
//         a = a + b;
//         b = a - b;
//         a = a - b;
//     }

//     static void Main()
//     {
//         int x = 10, y = 20;

//         SwapRef(ref x, ref y);

//         Console.WriteLine($"After ref swap: x = {x}, y = {y}");
//     }
// }

//Method 2 — using out

// using System;

// public class Solution
// {
//     static void SwapOut(int a, int b, out int x, out int y)
//     {
//         x = a + b;
//         y = x - b;
//         x = x - y;
//     }

//     static void Main()
//     {
//         int a = 30, b = 40;
//         int x, y;

//         SwapOut(a, b, out x, out y);

//         Console.WriteLine($"After out swap: x = {x}, y = {y}");
//     }
// }


