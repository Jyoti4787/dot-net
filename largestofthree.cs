using System;

namespace DotNetBasics
{
    class Lot
    {
        public static void Calculate()
        {
            int a = 10, b = 25, c = 15;

            if (a > b && a > c)
                Console.WriteLine("A is largest");
            else if (b > c)
                Console.WriteLine("B is largest");
            else
                Console.WriteLine("C is largest");

            Console.ReadLine();
        }
    }
}
