//What is File I/O in C#?
//File I/O means reading data from a file and writing data to a file instead of using only memory.

using System;
using System.IO;

class User
{
    public int id;
    public string name;
}
class Program
{
    public static void Main()
    {
        // string path = "data.txt";
        
        // File.WriteAllText(path, "File I/O Example in C# Wihout Creating a New File"); 
        //replace all text and also create a new file if the specified file is not there
        //Creates a file if it doesn’t exist
        // Overwrites existing content
        // Best for small data

        // Console.WriteLine("Data written to the file.");

        // string content = File.ReadAllText("data.txt");
        //Reads entire file content at once
        // Console.WriteLine($"File Content: {content}");

        // using (StreamWriter writer = new StreamWriter("data.txt"))
        //Writes data line by line


        // {
        //     writer.WriteLine("Application Started");
        //     writer.WriteLine("Processing Data");
        //     writer.WriteLine("Application Ended");
        // }

        // using (StreamReader reader = new StreamReader("data.txt"))
        //Reading Text Line-by-Line


        // {
        //     string line;
        //     while((line = reader.ReadLine()) != null)
        //     {
        //         Console.WriteLine(line);
        //     }
        // }

        // User user = new User {id = 1, name = "Alice"};
        // using(StreamWriter writer = new StreamWriter("log.txt"))
        // {

        //     writer.WriteLine(user.id);
        //Writing Object Data to Text File


        //     writer.WriteLine(user.name);
        //     user.id = 2;
        //     user.name = "Bob";
        //     writer.WriteLine(user.id);
        //     writer.WriteLine(user.name);
        // }
        // Console.WriteLine("Done");

        // User user = new User();
        // using(StreamReader reader = new StreamReader("log.txt"))
        // {
        //     user.id = int.Parse(reader.ReadLine());
        //     user.name = reader.ReadLine();
        // }
        // Console.WriteLine($"UserId: {user.id} Name: {user.name}");

        User user = new User
        {
            id = 3,
            name = "James"
        };


        //Writing Binary Data (BinaryWriter)
        //Stores data in binary format
        using(BinaryWriter writer = new BinaryWriter(File.Open("user.bin", FileMode.Create)))
        {
            writer.Write(user.id);
            writer.Write(user.name);
        }
        Console.WriteLine("Binary data saved succesfully");


        //Reading Binary Data (BinaryReader)
        //Read data in same order as written
        //Wrong order ❌ = runtime error


        using(BinaryReader reader = new BinaryReader(File.Open("user.bin", FileMode.Open)))
        {
            Console.WriteLine(reader.ReadInt32());
            Console.WriteLine(reader.ReadString());
        }
    }
}

//FileMode.Create  // Creates or overwrites file
//FileMode.Open    // Opens existing file

// Why using Statement?
// using(...)
// {
//    // file operations
// }


// Automatically closes file
//  Prevents memory leaks
//  Best practice in C#


// System.IO is used for file handling

// File class → simple file operations

// StreamWriter/StreamReader → text streaming

// BinaryWriter/BinaryReader → binary data storage

// Binary files are faster, secure, compact

// Data must be read in the same order as written

// using ensures proper resource cleanup

