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
            Console.WriteLine("=== Banking System - BankAccount Demo ===\n");

            // Create a BankAccount object with initial balance
            BankAccount account = new BankAccount(1000.00);
            Console.WriteLine($"Account created with initial balance: ${account.GetBalance():F2}\n");

            // Perform various deposits
            Console.WriteLine("--- DEPOSIT OPERATIONS ---");
            account.Deposit(500.50);
            Console.WriteLine();

            account.Deposit(250.75);
            Console.WriteLine();

            // Test invalid deposit (negative amount)
            Console.WriteLine("Testing invalid deposit:");
            account.Deposit(-100.00);
            Console.WriteLine();

            // Test invalid deposit (zero amount)
            account.Deposit(0);
            Console.WriteLine();

            // Perform various withdrawals
            Console.WriteLine("--- WITHDRAWAL OPERATIONS ---");
            account.Withdraw(200.00);
            Console.WriteLine();

            account.Withdraw(300.50);
            Console.WriteLine();

            // Test invalid withdrawal (negative amount)
            Console.WriteLine("Testing invalid withdrawal:");
            account.Withdraw(-50.00);
            Console.WriteLine();

            // Test overdraw protection
            Console.WriteLine("Testing overdraw protection:");
            account.Withdraw(2000.00); // Should fail - insufficient funds
            Console.WriteLine();

            // Display final balance
            Console.WriteLine("--- FINAL ACCOUNT STATUS ---");
            Console.WriteLine($"Final Balance: ${account.GetBalance():F2}");

            // Demonstrate encapsulation - the following would cause compile errors:
            Console.WriteLine("\n--- ENCAPSULATION DEMONSTRATION ---");
            Console.WriteLine("The following line would cause a COMPILE ERROR if uncommented:");
            Console.WriteLine("// account.balance = 5000; // ERROR: Cannot access private field");
            Console.WriteLine("✓ Balance field is properly encapsulated and protected");
            Console.WriteLine("✓ All access to balance is controlled through public methods");
            Console.WriteLine("✓ Business rules are enforced (no negative deposits, no overdrawing)");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    public class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance = 0)
        {
            if (initialBalance >= 0)
            {
                balance = initialBalance;
            }
            else
            {
                balance = 0;
                Console.WriteLine("Warning: Initial balance cannot be negative. Account Initialized with $0.00");
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited: ${amount:F2}");
                Console.WriteLine($"New balance: ${balance:F2}");
            }
            else
            {
                Console.WriteLine("Warning: Deposit amount must be positive. Transaction rejected."); // Fixed: Added semicolon and corrected spelling
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Successfully withdrawn: ${amount:F2}"); // Fixed: Corrected spelling
                    Console.WriteLine($"New balance: ${balance:F2}"); // Fixed: Changed ${amount:F2} to ${balance:F2}
                }
                else
                {
                    Console.WriteLine($"Warning: Insufficient funds. Available balance: ${balance:F2}"); // Fixed: Corrected "Funds" to "balance"
                    Console.WriteLine("Transaction rejected. You cannot overdraw your account.");
                }
            }
            else
            {
                Console.WriteLine("Error: Withdrawal amount must be positive. Transaction rejected."); // Fixed: Corrected spelling and added period
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}