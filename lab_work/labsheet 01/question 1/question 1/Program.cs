using System;

namespace MyFirstC
{
    class Program
    {
        // Write a Console Application Program to calculate the area of a rectangle.
        // Prompt the user to enter the length and width.
        // Display the calculated area. 
        // (Use a separate function to calculate the area).

        // Correctly define the Main method with a capital 'S' in 'static'
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            int width = Convert.ToInt32(Console.ReadLine());
            // Call the function and store result
            int area = CalculateRectangleArea(length, width);
            Console.WriteLine("The area of the rectangle is: " + area);
        }
        // Function to calculate the area of a rectangle
        static int CalculateRectangleArea(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
    