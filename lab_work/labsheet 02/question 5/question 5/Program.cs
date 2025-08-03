
using System;
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Develop an application that stimulate a library system.
            // Create a class named LibraryBook with properties Title, Author, and Available.
            // Implement a method BorrowBook that updates the availability status.
            // Instantiate multiple book objects, perform book borrowing, and display the update library status.
            LibraryBook book1 = new LibraryBook("Necormance", "Grim Reaper");
            LibraryBook book2 = new LibraryBook("Dead man Wonderland", "Grim Reaper");
            book1.BorrowBook();
            book2.BorrowBook();
            Console.ReadKey();
        }
    }
    public class LibraryBook
    {
        public String Title;
        public String Author;
        public bool Available;
        public LibraryBook(String title, String author)
        {
            this.Title = title;
            this.Author = author;
            Available = true;
        }
        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"You borrowed the book {Title}");
            }
            else
            {
                Console.WriteLine($"The book '{Title}' has already been borrowed.");
            }
        }
    }
}
