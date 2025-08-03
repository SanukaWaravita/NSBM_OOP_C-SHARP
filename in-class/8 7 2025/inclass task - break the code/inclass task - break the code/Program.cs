using System;
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Bulb livingRoomBulb = new Bulb();
            livingRoomBulb.Status(); // Before turning on the switch
            livingRoomBulb.isOn = true; // Assigning true value to isOn within the main method
            livingRoomBulb.Status(); // After turning on the switch
            Console.ReadKey();
        }
    }
    public class Bulb
    {
        public bool isOn; // Variable or Field
        public void bulbSwitch()
        {
            isOn = !isOn;
        }
        public void Status()
        {
            if (isOn)
            {
                Console.WriteLine("Light is ON!");
            }
            else
            {
                Console.WriteLine("Light is OFF!");
            }
        }
    }
}
