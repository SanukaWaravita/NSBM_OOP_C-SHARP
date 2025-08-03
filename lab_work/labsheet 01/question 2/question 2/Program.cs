using System;

namespace MyFirstC
{
    class Program
    {
        // Write a Console Application program to check if the given 10 number inputs are even or odd.
        // Prompt the user to enter the numbers, and display whether it's even or odd.

        static void Main(string[] args)
        {
            int evencounter = 0;
            int oddcounter = 0;

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Enter a number here: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number you entered is even");
                }
                else
                {
                    Console.WriteLine("The number you entered is odd");
                }
            }
        }

    }
}
