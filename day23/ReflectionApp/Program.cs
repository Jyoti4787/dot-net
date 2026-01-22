using System;
using System.Reflection;
using MyLibrary;

class Program
{
    static void Main()
    {
        try
        {
            // Reflection part
            Assembly asm = Assembly.Load("MyLibrary");
            
            Console.WriteLine(" Reflection Output ");
            foreach (Type t in asm.GetTypes())
            {
                Console.WriteLine("\nType: " + t.Name);
                foreach (var m in t.GetMembers())
                {
                    Console.WriteLine("  " + m.Name);
                }
            }

            Console.WriteLine("\n Method Execution ");

            ClassB obj = new ClassB();
            obj.M1();
            obj.M2();
            obj.M3();
            obj.M4();
            obj.M5();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program finished (finally block)");
        }
    }
}

