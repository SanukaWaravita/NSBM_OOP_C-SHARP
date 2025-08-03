using System;
namespace c__inclass_code
{
    public class Book
    {
        // Properties
        public String title;
        public String author;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a C# console application that defines a class called Book with properties Title and Author.
            // Instantiate an object of this class, set values for the properties, and display the information on the console.
            // Create an object
            Book book1 = new Book();
            // Set values
            book1.author = "Jack Ripper";
            book1.title = "Serial Killer";
            // Display values
            Console.WriteLine("Book Details\n"); // \n Line break
            Console.WriteLine("Book Author: " + book1.author);
            Console.WriteLine("Book Title: " + book1.title);
            Console.ReadKey();
        }
    }
}
