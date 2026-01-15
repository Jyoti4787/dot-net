//Threading 

// using System.Threading;
// Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));

// thread.Start("Hello from thread");


// static void PrintMessage(object message)
// {
//     Console.WriteLine(message);
// }

// using System;
// using System.Threading;

// class Program
// {
//     static void Main()
//     {
//         Thread worker = new Thread(DoWork);

     
//         worker.Start();

//         Console.WriteLine("Main thread continues...");
//     }

//     static void DoWork()
//     {
//         for (int i = 1; i <= 5; i++)
//         {
//             Console.WriteLine("Worker thread: " + i);

//             Thread.Sleep(1000);
//         }
//     }
// }


// using System;
// using System.Threading.Tasks;

// Parallel.For(0, 5, i=>{
//     Console.WriteLine($"Processing item{i}");
// });

// using System;
// using System.Threading.Tasks;

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = new int[10];

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = i + 1;
//         }

//         int sum = 0;
//         object lockObj = new object();

//         Parallel.For(0, numbers.Length, i =>
//         {
//             lock (lockObj)
//             {
//                 sum += numbers[i];
//             }
//         });

//         Console.WriteLine("Sum = " + sum);
//     }
// }


// using System;
// using System.Threading;
// using System.Threading.Tasks;

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = {1,2,3,4,5,6,7,8,9,10};
//         int sum = 0;

//         Parallel.For(
//             0,
//             numbers.Length,

//             // Thread-local initialization
//             () => 0,

//             // Loop body
//             (i, loopState, localSum) =>
//             {
//                 return localSum + numbers[i];
//             },

//             // Final aggregation
//             localSum =>
//             {
//                 Interlocked.Add(ref sum, localSum);
//             }
//         );

//         Console.WriteLine("Sum = " + sum);
//     }
// }

// using System;
// using System.IO;
// using System.Threading.Tasks;

// class Program
// {
//     static async Task Main()
//     {
//         Console.WriteLine("Start reading file...");

//         string content = await File.ReadAllTextAsync("data.txt");

//         Console.WriteLine("File content:");
//         Console.WriteLine(content);

//         Console.WriteLine("End of program");
//     }
// }

