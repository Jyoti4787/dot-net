using System;
using CalculatorLib;

class Program
{
    static void Main()
    {
        Calculate calc = new Calculate();

        Console.WriteLine("Addition: " + calc.Add(10, 5));
        Console.WriteLine("Subtraction: " + calc.Subtract(10, 5));
    }
}

