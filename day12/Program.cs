// using System.Text;
// StringBuilder sb = new StringBuilder();

// sb.Append("Hello");
// sb.Append(" ");
// sb.Append("World");
// Console.WriteLine(sb.ToString());

// sb.Append("Text");
// sb.AppendLine("Line");
// sb.Insert(0, "Start");
// sb.Remove(0, 5);
// sb.Replace("old", "new");
// sb.Clear();


// using System;
// using System.Text;

// class Program
// {
//     static void Main()
//     {
//         StringBuilder sb = new StringBuilder();

//         sb.Append("Text").Append("text2");

//         Console.WriteLine("After Append: " + sb.ToString());

//         sb.AppendLine("Line");
//         Console.WriteLine("After AppendLine:\n" + sb.ToString());

//         sb.Insert(0, "Start");
//         Console.WriteLine("After Insert: " + sb.ToString());

//         sb.Remove(0, 5);
//         Console.WriteLine("After Remove: " + sb.ToString());

//         sb.Replace("old", "new");
//         Console.WriteLine("After Replace: " + sb.ToString());

//         sb.Clear();
//         Console.WriteLine("After Clear: " + sb.ToString());

//         Console.ReadLine();
//     }
// }

// using System.Text;
// StringBuilder sb = new StringBuilder();
// // sb.Append("hello");
// // sb.Append(" ");
// // sb.Append("World");
// // Console.WriteLine(sb.ToString());

// sb.Append("Text");
// sb.AppendLine("Line");
// // Console.WriteLine(sb.ToString());


// sb.Insert(0,"Start");
// // Console.WriteLine(sb.ToString());


// // sb.Remove(0,5);
// sb.Append("Old");
// sb.Replace("Old","New");
// // Console.WriteLine(sb.ToString());
// sb.Clear();
// Console.WriteLine(sb.ToString());



// for(int i=0 ; i<10000 ; i++)
// {
//     sb.Append(i);
// }

// string result = sb.ToString();
// Console.WriteLine(GC.GetTotalMemory(false));
// // Console.WriteLine(result);


// using System;
// using System.Text;

// class Program
// {
//     static void Main()
//     {
//         StringBuilder sb1 = new StringBuilder("Hello");
//         StringBuilder sb2 = new StringBuilder("Hello");

//         Console.WriteLine(sb1.Equals(sb2));  
      
//         Console.WriteLine(Object.ReferenceEquals(sb1, sb2));  

//         StringBuilder sb3 = sb2;

//         Console.WriteLine(sb3.Equals(sb2));  
       
//         Console.WriteLine(Object.ReferenceEquals(sb3, sb2));  
        
//         Console.ReadLine();
//     }
// }

using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb1 = new StringBuilder("Hello");
        StringBuilder sb2 = new StringBuilder("Hello");

        Console.WriteLine(sb1.Equals(sb2));              // False

        Console.WriteLine(Object.ReferenceEquals(sb1, sb2)); // False

        StringBuilder sb3 = sb2;

        Console.WriteLine(sb3.Equals(sb2));              // True

        Console.WriteLine(sb1 == sb2);                   // False
        Console.WriteLine(sb3 == sb2);                   // True

        Console.ReadLine();
    }
}


