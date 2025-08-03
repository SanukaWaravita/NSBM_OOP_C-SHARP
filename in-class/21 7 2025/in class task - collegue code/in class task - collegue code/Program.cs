using System;
namespace AmarapalaCar
{
    public abstract class Car
    {
        public string name;
        public Car()
        {
            name = "SIRIGEAR";
        }
        public Car(string name)
        {
            this.name = name;
        }
        public abstract void DisplayInfo();
    }
    public class Batta : Car
    {
        private string engine = "V6";
        public string fuel = "petrol";
        public int trunkSize = 1000;
        public Batta(string name) : base(name)
        {
        }
        public string getEngine()
        {
            return engine;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Car Name: {name}");
            Console.WriteLine($"Engine: {engine}");
            Console.WriteLine($"Fuel Type: {fuel}");
            Console.WriteLine($"Trunk Size: {trunkSize}");
        }
    }
    public class RealWorld
    {
        public static void Main(string[] args)
        {
            Batta batta1 = new Batta("Picasso");
            batta1.DisplayInfo();
            Console.ReadLine();
        }
    }
}
