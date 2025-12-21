using System;

namespace DotNetBasics
{
    class AreaOfCircle
    {
        public static void Calculate()
        {
            Console.Write("Enter radius: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * r * r;

            Console.WriteLine("Area of Circle = " + area);
        }
    }
}
