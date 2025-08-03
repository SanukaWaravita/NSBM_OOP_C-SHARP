using System;

namespace ShapeInheritanceDemo
{
    // Base class: Shape
    public class Shape
    {
        // Virtual method - can be overridden in derived classes
        public virtual double CalculateArea()
        {
            return 0; // Default implementation for base class
        }

        // Optional: Virtual method to display shape info
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"This is a generic shape with area: {CalculateArea():F2}");
        }
    }

    // Derived class: Circle
    public class Circle : Shape
    {
        // Private field for radius
        private double radius;

        // Constructor to initialize radius
        public Circle(double r)
        {
            radius = r;
        }

        // Property to get radius (optional, for better encapsulation)
        public double Radius
        {
            get { return radius; }
            set { radius = value > 0 ? value : 0; } // Validation
        }

        // Override the CalculateArea method
        public override double CalculateArea()
        {
            return Math.PI * radius * radius; // π × r²
        }

        // Override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine($"Circle with radius {radius:F2} has area: {CalculateArea():F2}");
        }
    }

    // Derived class: Rectangle
    public class Rectangle : Shape
    {
        // Private fields for dimensions
        private double length;
        private double width;

        // Constructor to initialize dimensions
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        // Properties for length and width (optional, for better encapsulation)
        public double Length
        {
            get { return length; }
            set { length = value > 0 ? value : 0; } // Validation
        }

        public double Width
        {
            get { return width; }
            set { width = value > 0 ? value : 0; } // Validation
        }

        // Override the CalculateArea method
        public override double CalculateArea()
        {
            return length * width; // length × width
        }

        // Override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine($"Rectangle with length {length:F2} and width {width:F2} has area: {CalculateArea():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Shape Inheritance Demo ===\n");

            // Create a Circle object
            Circle circle = new Circle(5.0);
            Console.WriteLine("--- CIRCLE ---");
            Console.WriteLine($"Radius: {circle.Radius}");
            Console.WriteLine($"Area: {circle.CalculateArea():F2} square units");
            circle.DisplayInfo();
            Console.WriteLine();

            // Create a Rectangle object
            Rectangle rectangle = new Rectangle(4.0, 6.0);
            Console.WriteLine("--- RECTANGLE ---");
            Console.WriteLine($"Length: {rectangle.Length}");
            Console.WriteLine($"Width: {rectangle.Width}");
            Console.WriteLine($"Area: {rectangle.CalculateArea():F2} square units");
            rectangle.DisplayInfo();
            Console.WriteLine();

            // Demonstrate polymorphism
            Console.WriteLine("--- POLYMORPHISM DEMONSTRATION ---");
            Console.WriteLine("Using Shape references to call overridden methods:\n");

            // Create an array of Shape references
            Shape[] shapes = {
                new Circle(3.0),
                new Rectangle(5.0, 8.0),
                new Circle(7.5),
                new Rectangle(2.5, 4.0)
            };

            // Loop through shapes and call CalculateArea() - polymorphism in action!
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Shape {i + 1}:");
                shapes[i].DisplayInfo(); // Calls the overridden method in each derived class
                Console.WriteLine($"Area calculated: {shapes[i].CalculateArea():F2}\n");
            }

            // Additional demonstration: Creating shapes with different values
            Console.WriteLine("--- ADDITIONAL EXAMPLES ---");

            Circle smallCircle = new Circle(2.5);
            Rectangle largeRectangle = new Rectangle(10.0, 12.0);

            Console.WriteLine($"Small circle (radius 2.5): Area = {smallCircle.CalculateArea():F2}");
            Console.WriteLine($"Large rectangle (10×12): Area = {largeRectangle.CalculateArea():F2}");

            Console.WriteLine("\n--- KEY CONCEPTS DEMONSTRATED ---");
            Console.WriteLine("✓ Base class Shape with virtual CalculateArea() method");
            Console.WriteLine("✓ Circle class inherits from Shape and overrides CalculateArea()");
            Console.WriteLine("✓ Rectangle class inherits from Shape and overrides CalculateArea()");
            Console.WriteLine("✓ Polymorphism: Same method call, different behavior based on object type");
            Console.WriteLine("✓ Encapsulation: Private fields with public properties");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}