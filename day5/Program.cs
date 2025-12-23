using System;
using System.Collections.Generic;

// ✅ Alias MUST be here (not inside Main)
using ItemsAlias = LibrarySystem.Items;

// ================= TASK 5: Namespaces & Nested Namespaces =================
namespace LibrarySystem
{
    public enum UserRole
    {
        Admin,
        Librarian,
        Member
    }

    public enum ItemStatus
    {
        Available,
        Borrowed,
        Reserved,
        Lost
    }

    public abstract class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ItemID { get; set; }

        public abstract void DisplayItemDetails();
        public abstract double CalculateLateFee(int days);
    }

    namespace Items
    {
        public interface IReservable
        {
            void ReserveItem();
        }

        public interface INotifiable
        {
            void SendNotification(string message);
        }

        public class Book : LibraryItem, IReservable, INotifiable
        {
            void IReservable.ReserveItem()
            {
                Console.WriteLine("Book reserved successfully.");
            }

            void INotifiable.SendNotification(string message)
            {
                Console.WriteLine($"Notification sent: {message}");
            }

            public override void DisplayItemDetails()
            {
                Console.WriteLine("Item Type: Book");
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Author: {Author}");
                Console.WriteLine($"Item ID: {ItemID}");
            }

            public override double CalculateLateFee(int days)
            {
                return days * 1.0;
            }
        }

        public class Magazine : LibraryItem
        {
            public override void DisplayItemDetails()
            {
                Console.WriteLine("Item Type: Magazine");
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Author: {Author}");
                Console.WriteLine($"Item ID: {ItemID}");
            }

            public override double CalculateLateFee(int days)
            {
                return days * 0.5;
            }
        }

        public class eBook : LibraryItem
        {
            public override void DisplayItemDetails()
            {
                Console.WriteLine("Item Type: eBook");
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Author: {Author}");
                Console.WriteLine($"Item ID: {ItemID}");
            }

            public override double CalculateLateFee(int days)
            {
                return 0;
            }

            public void Download()
            {
                Console.WriteLine("eBook downloaded successfully.");
            }
        }
    }

    namespace Users
    {
        public class Member
        {
            public string Name { get; set; }
            public UserRole Role { get; set; }
        }
    }

    public partial class LibraryAnalytics
    {
        public static int TotalBorrowedItems { get; set; }
    }

    public partial class LibraryAnalytics
    {
        public static void DisplayAnalytics()
        {
            Console.WriteLine($"Total Items Borrowed: {TotalBorrowedItems}");
        }
    }
}

class Program
{
    static void Main()
    {
        var book = new ItemsAlias.Book
        {
            Title = "C# Fundamentals",
            Author = "John Doe",
            ItemID = 101
        };

        var magazine = new ItemsAlias.Magazine
        {
            Title = "Tech Today",
            Author = "Jane Doe",
            ItemID = 201
        };

        book.DisplayItemDetails();
        Console.WriteLine($"Late Fee for 3 days: {book.CalculateLateFee(3)}\n");

        magazine.DisplayItemDetails();
        Console.WriteLine($"Late Fee for 3 days: {magazine.CalculateLateFee(3)}\n");

        ItemsAlias.IReservable r = book;
        ItemsAlias.INotifiable n = book;

        r.ReserveItem();
        n.SendNotification("Your reserved book is ready.");

        List<LibrarySystem.LibraryItem> items = new()
        {
            book,
            magazine
        };

        foreach (var item in items)
        {
            item.DisplayItemDetails();
            Console.WriteLine();
        }

        LibrarySystem.LibraryAnalytics.TotalBorrowedItems += 5;
        LibrarySystem.LibraryAnalytics.DisplayAnalytics();

        var member = new LibrarySystem.Users.Member
        {
            Name = "Alice",
            Role = LibrarySystem.UserRole.Member
        };

        Console.WriteLine($"User Role: {member.Role}");
        Console.WriteLine($"Item Status: {LibrarySystem.ItemStatus.Borrowed}");

        var ebook = new ItemsAlias.eBook
        {
            Title = "Learn C# Digitally",
            Author = "Tech Author",
            ItemID = 301
        };

        ebook.Download();
    }
}
