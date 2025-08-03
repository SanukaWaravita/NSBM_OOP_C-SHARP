using System;
namespace c__inclass_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Car honda_Civic = new Car();
            // Constructor

            Console.WriteLine(honda_Civic);
            Console.ReadKey();
        }
    }
    public class Car
    {
        public String Name;
        public int Id;
        public String Color;
        public int top_Speed;
        public void engine_Start()
        {
            Console.WriteLine("Engine started!");
        }
        public void brake()
        {
            Console.WriteLine("Brake applied!");
        }
        public void accelerate()
        {
            Console.WriteLine("Accelerating!");
        }
        public void repair()
        {
            Console.WriteLine("Repairing!");
        }
        // Constructor
        public Car() // No-parameter constructor
        {
            Name = "Honda Civic";
            top_Speed = 180;
        }
        // Parameterized constructor
        public Car(int iD, int t_S)
        {
            Id = iD;
            top_Speed = t_S;
        }
    }
}
