// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         List<int> divisibleBy2 = new List<int>();
//         List<int> divisibleBy3 = new List<int>();
//         List<int> primeNumbers = new List<int>();

//         for (int i = 1; i <= 100; i++)
//         {
//             if (i % 2 == 0)
//                 divisibleBy2.Add(i);

//             if (i % 3 == 0)
//                 divisibleBy3.Add(i);

//             if (IsPrime(i))
//                 primeNumbers.Add(i);
//         }

//         Console.WriteLine("Divisible by 2:");
//         foreach (int n in divisibleBy2)
//         {
//             Console.Write(n + " ");
//         }

//         Console.WriteLine("\n\nDivisible by 3:");
//         foreach (int n in divisibleBy3)
//         {
//             Console.Write(n + " ");
//         }

//         Console.WriteLine("\n\nPrime Numbers:");
//         foreach (int n in primeNumbers)
//         {
//             Console.Write(n + " ");
//         }
//     }

//     static bool IsPrime(int num)
//     {
//         if (num <= 1)
//             return false;

//         for (int i = 2; i <= Math.Sqrt(num); i++)
//         {
//             if (num % i == 0)
//                 return false;
//         }
//         return true;
//     }
// }

// using System;
// interface IGear
// {
//     void Gear1();
//     void Gear2();
//     void Gear3();
//     void Gear4();
//     void Gear5();
//     void Gear6();
// }

// class JyotiMotors : IGear
// {
//     public void Gear1()
//     {
//         Console.WriteLine("Gear 1 is tested");
//     }

//     public void Gear2()
//     {
//         Console.WriteLine("Gear 2 is tested");
//     }

//     public void Gear3()
//     {
//         Console.WriteLine("Gear 3 is tested");
//     }

//     public void Gear4()
//     {
//         Console.WriteLine("Gear 4 is tested");
//     }

//     public void Gear5()
//     {
//         Console.WriteLine("Gear 5 is tested");
//     }

//     public void Gear6()
//     {
//         Console.WriteLine("Gear 6 is tested");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         IGear car = new JyotiMotors();

//         car.Gear1();
//         car.Gear2();
//         car.Gear3();
//         car.Gear4();
//         car.Gear5();
//         car.Gear6();

//         Console.ReadLine();
//     }
// }

// using System;
// abstract class NanoCar
// {
//     public abstract void Gear1();
//     public abstract void Gear2();

//     public virtual void ReverseCamera()
//     {
//         Console.WriteLine("Reverse camera not installed.");
//     }

//     public virtual void AudioSystem()
//     {
//         Console.WriteLine("Audio system not installed.");
//     }
// }

// class TataNano : NanoCar
// {
//     public override void Gear1()
//     {
//         Console.WriteLine("Nano Car Gear 1 is working");
//     }

//     public override void Gear2()
//     {
//         Console.WriteLine("Nano Car Gear 2 is working");
//     }

//     public override void AudioSystem()
//     {
//         Console.WriteLine("Nano Car Audio System is installed");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         NanoCar car = new TataNano();

//         car.Gear1();
//         car.Gear2();
//         //car.ReverseCamera();
//         car.AudioSystem();

//         Console.ReadLine();
//     }
// }

// using System;
// delegate int MyDelegate(int a, int b);

// class Program
// {
//     static int Add(int a,int b)
//     {
//         return a+b;
//     }

//     static int Subtract(int a,int b)
//     {
//         return a-b;
//     }

//     static void Main()
//     {
//         MyDelegate d;

//         //add
//         d = Add;
//         Console.WriteLine("Addition: " + d(10, 5));

//         // Subtract
//         d = Subtract;
//         Console.WriteLine("Subtraction: " + d(10, 5));

//         Console.ReadLine();
//     }
// }

