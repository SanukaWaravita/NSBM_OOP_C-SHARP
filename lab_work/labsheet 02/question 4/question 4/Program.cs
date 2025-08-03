using System;
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construct a C# program for a basic inventory system.
            // Define a class named Product with properties ProductName and Price. 
            // Implement a parameterized constructor to initialize these properties. 
            // Instantiate objects using the constructor and display the product details.
            Product product1 = new Product("Cake", 45.67);
            Product product2 = new Product("Apple", 56.78);
            product1.Display();
            product2.Display();
            Console.ReadKey();
        }
    }
    public class Product
    {
        public String ProductName;
        public double Price;
        public Product(String name, double price)
        {
            this.ProductName = name;
            this.Price = price;
        }
        public void Display()
        {
            Console.WriteLine($"Product: {ProductName}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}
