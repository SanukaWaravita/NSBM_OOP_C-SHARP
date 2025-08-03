using System;
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build an application to store and display the temperature of a week using an array.
            // Create a class named 'TemperatureTracker' with an array to store daily temperatures.
            // Implement a method to display the temperatures.
            // Instantiate an object, instantiate an object, input temperatures, and display the weekly temperature report.
            TemperatureTracker temperatureTracker = new TemperatureTracker();
            temperatureTracker.tempInput();
            temperatureTracker.tempDisplay();
            Console.ReadKey();
        }
    }
    public class TemperatureTracker
    {
        public int[] temperatures = new int[7];
        public void tempInput()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Enter temperature for day {i + 1}: ");
                temperatures[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void tempDisplay()
        {
            Console.WriteLine("\nWeekly Temperature Report: ");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Day {i + 1}: {temperatures[i]}°C");
            }
        }
    }
}
