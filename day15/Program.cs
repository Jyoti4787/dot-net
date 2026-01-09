// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {

//         FileInfo file = new FileInfo("sample.txt");
// What is FileInfo?
// FileInfo is a class-based approach to work with files.
// It provides detailed information and instance methods for a specific file.

//         if (!file.Exists)
//         {

//             using (StreamWriter writer = file.CreateText())
//             {
//                 writer.WriteLine("Hello FileInfo Class");
//             }
// CreateText()
// Creates the file
//  Opens a StreamWriter

// using ensures the file is closed automatically
//         }

//         Console.WriteLine("File Name: " + file.Name);
//         Console.WriteLine("File Size: " + file.Length + " bytes");
//         Console.WriteLine("Created On: " + file.CreationTime);
// Properties Explained:

// Name → File name only

// Length → File size in bytes

// CreationTime → Date & time when file was created

// These properties are read-only metadata.


//     }
// }

// When to Use FileInfo?

//  When you need:

// File metadata

// Repeated operations on the same file

// Object-oriented file handling





//Directory is a static class used to create, delete, and check folders.
// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         Directory.CreateDirectory("Logs");
// //  Creates a folder named Logs
// //  If folder already exists → no error
// //  Returns a DirectoryInfo object (optional)

//         if (Directory.Exists("Logs"))
//         {
//             Console.WriteLine("Logs directory created successfully.");
//         }

// //  Confirms directory creation
// // Avoids runtime errors when accessing folders
//     }
// }


// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         DirectoryInfo dir = new DirectoryInfo("Logs");

//         if (!dir.Exists)
//         {
//             dir.Create();
//         }

//         Console.WriteLine("Directory Name: " + dir.Name);
//         Console.WriteLine("Created On: " + dir.CreationTime);
//         Console.WriteLine("Full Path: " + dir.FullName);


//     }
// }

// using System;
// using System.IO;
// using System.Text.Json;

// class Program
// {
//     static void Main()
//     {
//         User user = new User
//         {
//             Id = 1,
//             Name = "Alice"
//         };

//         string json = JsonSerializer.Serialize(user);

//         File.WriteAllText("user.json", json);

//         Console.WriteLine("User serialized successfully");
//     }
// }

// class User
// {
//     public int Id { get; set; }
//     public string Name { get; set; } = string.Empty;
// }


using System;
using System.IO;
using System.Xml.Serialization;

[Serializable]
public class User
{
    public int Id;
    public string Name;
}
class Program
{
    static void Main()
    {
        User user = new User { Id = 1, Name = "Alice" };
        XmlSerializer serializer = new XmlSerializer(typeof(User));
        using (FileStream fs = new FileStream("user.xml", FileMode.Create))
        {
            serializer.Serialize(fs, user);
        }

        Console.WriteLine("XML Serialized");
    }
}
