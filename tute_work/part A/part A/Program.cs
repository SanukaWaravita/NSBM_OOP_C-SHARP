using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a class MedicineTablet with the following private fields:
            //      • string name - the name of the medicine
            //      • int dosageMg - dosage in milligrams (e.g., 500)
            //      • string expiryDate - in the format "YYYY-MM-DD"
            //      • string formula - internal formula (should be hidden from outside)

            // 2.Add the following public methods: 
            //      • SetName(string) and GetName()
            //      • SetDosage(int) and GetDosage()
            //          • Dosage must be between 50 and 1000 mg.If invalid, show an error message.
            //      • SetExpiryDate(string) and GetExpiryDate()
            //      • SetFormula(string) - but do not create a GetFormula() method
            //          • This is sensitive information that cannot be accessed from outside.

            // 3.In your Main() method:
            //      • Create an object of MedicineTablet
            //      • Set all the fields using setter methods 
            //      • Try entering an invalid dosage to test validation 
            //      • Print the name, dosage, and expiry date using getter methods
            //      • Try to access the formula directly -what happens?

            Console.WriteLine("=== Pharmaceutical Software - MedicineTablet Demo ===\n");

            // Create an object of MedicineTablet
            MedicineTablet tablet = new MedicineTablet();

            // Set all fields using setter methods
            Console.WriteLine("Setting medicine information...");
            tablet.SetName("Paracetamol");
            tablet.SetDosage(500);
            tablet.SetExpiryDate("2025-12-31");
            //tablet.SetFormula("C8H9NO2"); // Sensitive formula stored internally

            Console.WriteLine("Medicine information set successfully!\n");

            // Print the name, dosage, and expiry date using getter methods
            Console.WriteLine("Retrieving medicine information:");
            Console.WriteLine($"Medicine Name: {tablet.GetName()}");
            Console.WriteLine($"Dosage: {tablet.GetDosage()} mg");
            Console.WriteLine($"Expiry Date: {tablet.GetExpiryDate()}\n");

            // Try entering invalid dosage to test validation
            Console.WriteLine("Testing dosage validation:");
            Console.WriteLine("Attempting to set dosage to 1500 mg (invalid):");
            tablet.SetDosage(1500); // Should show error message

            Console.WriteLine("Attempting to set dosage to 25 mg (invalid):");
            tablet.SetDosage(25); // Should show error message

            Console.WriteLine("Attempting to set dosage to 250 mg (valid):");
            tablet.SetDosage(250); // Should work
            Console.WriteLine($"Updated dosage: {tablet.GetDosage()} mg\n");

            // Try to access the formula directly - what happens?
            Console.WriteLine("Attempting to access formula directly:");
            Console.WriteLine("The following line would cause a COMPILE ERROR if uncommented:");
            Console.WriteLine("// Console.WriteLine(tablet.formula); // ERROR: Cannot access private field");
            Console.WriteLine("// Console.WriteLine(tablet.GetFormula()); // ERROR: Method doesn't exist");

            Console.WriteLine("\nEncapsulation Success:");
            Console.WriteLine("✓ Private fields are protected from direct access");
            Console.WriteLine("✓ Data validation works in setter methods");
            Console.WriteLine("✓ Sensitive formula information remains hidden");
            Console.WriteLine("✓ Only authorized operations are allowed through public methods");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
    public class MedicineTablet
    {
        private string name;
        private int dosageMg;
        private string expiryDate;
        private string formula;

        public void SetName(string medicineName)
        {
            name = medicineName;
        }

        public string GetName()
        {
            return name;
        }
        public void SetDosage(int dosage)
        {
            if (dosage >= 50 && dosage <= 1000)
            {
                dosageMg = dosage;
            }
            else
            {
                Console.WriteLine("Error: Dosage must be between 50 and 1000 mg. Invalid dosage rejected.");
            }
        }
        public int GetDosage()
        {
            return dosageMg;
        }
        public void SetExpiryDate(string expiry)
        {
            expiryDate = expiry;
        }
        public string GetExpiryDate()
        {
            return expiryDate;
        }
        public void setFormula(string medicineFormula)
        {
            formula = medicineFormula;
        }
    }
}
