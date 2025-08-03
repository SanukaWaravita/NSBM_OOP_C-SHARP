using System;
// Our Parent Class - The general blueprint for any vehicle
class Vehicle
{
    // Private data - How fast the vehicle is going
    private int speed;
    // Public property to safely get the current speed
    public int GetSpeed()
    {
        return speed;
    }
    // Public method - Makes the vehicle move faster
    public void Accelerate(int amount)
    {
        speed += amount;
        Console.WriteLine($"Vehicle is accelerating. Speed: {speed} Kmph");
    }
    // Public method - Makes the vehicle stop
    public void Stop()
    {
        speed = 0;
        Console.WriteLine("Vehicle has stopped.");
    }
}
// Our Child Class - Car inherits from Vehicle
// This means Car gets all the public stuff (like Accelerate and Stop) from; Vehicle!
class Car : Vehicle
{
    // Private data unique to a Car - Number of doors
    private int numberOfDoors;
    // Constructor for the Car class
    // It takes the number of doors for this specific car
    public Car(int doors)
    {
        numberOfDoors = doors;
        Console.WriteLine($"A new car with {numberOfDoors} doors has been created.");
    }
    // Public method unique to a Car: Honk the horn!
    public void HonkHorn()
    {
        Console.WriteLine("Beep! Beep!");
    }
    // Public method to get the number of doors
    public int GetNumberOfDoors()
    {
        return numberOfDoors;
    }
}
// Main program class to run our code
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Testing our Vehicle ---");
        // Create a general Vehicle object
        Vehicle myGenericVehicle = new Vehicle();
        myGenericVehicle.Accelerate(30);
        myGenericVehicle.Stop();
        Console.WriteLine("\n--- Testing our Car (which is also a Vehicle!) ---");
        Car mySportsCar = new Car(2); // A sports car usually has 2 doors!

        mySportsCar.Accelerate(60);
        mySportsCar.HonkHorn(); // Make the car honk!
        mySportsCar.Stop();
        Console.WriteLine($"\nMy sports car has {mySportsCar.GetNumberOfDoors()} doors and its final speed is {mySportsCar.GetSpeed()} mph.");
        // Print out the details of the SEDAN car
        // SEDAN
        // Create a SEDAN Car object with 4 doors
        Car mySedan = new Car(4);
        // Use an inherited method from Vehicle
        mySedan.Accelerate(60);
        // Use a method unique to Car
        mySedan.HonkHorn();
        // Use another inherited method
        mySedan.Stop();

        Console.WriteLine($"\nMy sedan car has {mySedan.GetNumberOfDoors()} doors and its final speed is {mySedan.GetSpeed()} mph.");

        Console.WriteLine("\nPress any key to exit.");

        Console.ReadKey();
    }
}
