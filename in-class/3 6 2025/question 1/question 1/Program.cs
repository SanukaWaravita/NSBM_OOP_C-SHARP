using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a program to display your name and your batch by using user inputs.

            Console.WriteLine("What is your name? ");
            String name = Console.ReadLine();
            
            Console.WriteLine("What is your batch? ");
            String batch = Console.ReadLine();
            
            Console.WriteLine("Hello" + name);
            Console.WriteLine("Your batch is " + batch);

            Console.ReadKey();
        }
    }
}
