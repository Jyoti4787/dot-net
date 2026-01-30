using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // In-memory storage using Generic Collection + dynamic
    static List<dynamic> books = new List<dynamic>();
    static int bookIdCounter = 1;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n===== BOOK LIBRARY MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. User");
            Console.WriteLine("3. Exit");
            Console.Write("Choose Role: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AdminMenu();
                    break;
                case 2:
                    UserMenu();
                    break;
                case 3:
                    return;
            }
        }
    }

    // ---------------- ADMIN MENU ----------------
    static void AdminMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- ADMIN MENU ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Update Book");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. View All Books");
            Console.WriteLine("5. Back");
            Console.Write("Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddBook(); break;
                case 2: UpdateBook(); break;
                case 3: DeleteBook(); break;
                case 4: ViewBooks(); break;
                case 5: return;
            }
        }
    }

    // ---------------- USER MENU ----------------
    static void UserMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- USER MENU ---");
            Console.WriteLine("1. Browse Books");
            Console.WriteLine("2. Search by Name");
            Console.WriteLine("3. Search by Publisher");
            Console.WriteLine("4. Highest Price Book");
            Console.WriteLine("5. Lowest Price Book");
            Console.WriteLine("6. Back");
            Console.Write("Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: ViewBooks(); break;
                case 2: SearchByName(); break;
                case 3: SearchByPublisher(); break;
                case 4: HighestPriceBook(); break;
                case 5: LowestPriceBook(); break;
                case 6: return;
            }
        }
    }

    // ---------------- CRUD OPERATIONS ----------------
    static void AddBook()
    {
        Console.Write("Book Name: ");
        string name = Console.ReadLine();

        Console.Write("Publisher: ");
        string publisher = Console.ReadLine();

        Console.Write("Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        dynamic book = new
        {
            Id = bookIdCounter++,
            Name = name,
            Publisher = publisher,
            Price = price
        };

        books.Add(book);
        Console.WriteLine("Book Added Successfully!");
    }

    static void UpdateBook()
    {
        Console.Write("Enter Book ID to update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            Console.WriteLine("Book not found!");
            return;
        }

        Console.Write("New Name: ");
        string name = Console.ReadLine();

        Console.Write("New Publisher: ");
        string publisher = Console.ReadLine();

        Console.Write("New Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        books.Remove(book);
        dynamic updatedBook = new
        {
            Id = id,
            Name = name,
            Publisher = publisher,
            Price = price
        };

        books.Add(updatedBook);
        Console.WriteLine("Book Updated Successfully!");
    }

    static void DeleteBook()
    {
        Console.Write("Enter Book ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var book = books.FirstOrDefault(b => b.Id == id);
        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine("Book Deleted Successfully!");
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }

    static void ViewBooks()
    {
        Console.WriteLine("\n--- BOOK LIST ---");
        foreach (var b in books)
        {
            Console.WriteLine($"ID: {b.Id}, Name: {b.Name}, Publisher: {b.Publisher}, Price: {b.Price}");
        }
    }

    // ---------------- SEARCH OPERATIONS ----------------
    static void SearchByName()
    {
        Console.Write("Enter book name: ");
        string name = Console.ReadLine().ToLower();

        var result = books.Where(b => b.Name.ToLower().Contains(name));

        foreach (var b in result)
        {
            Console.WriteLine($"ID: {b.Id}, Name: {b.Name}, Publisher: {b.Publisher}, Price: {b.Price}");
        }
    }

    static void SearchByPublisher()
    {
        Console.Write("Enter publisher: ");
        string publisher = Console.ReadLine().ToLower();

        var result = books.Where(b => b.Publisher.ToLower().Contains(publisher));

        foreach (var b in result)
        {
            Console.WriteLine($"ID: {b.Id}, Name: {b.Name}, Publisher: {b.Publisher}, Price: {b.Price}");
        }
    }

    static void HighestPriceBook()
    {
        if (books.Count == 0) return;
        var book = books.OrderByDescending(b => b.Price).First();
        Console.WriteLine($"Highest Price Book: {book.Name} - Rs.{book.Price}");
    }

    static void LowestPriceBook()
    {
        if (books.Count == 0) return;
        var book = books.OrderBy(b => b.Price).First();
        Console.WriteLine($"Lowest Price Book: {book.Name} - Rs.{book.Price}");
    }
}
