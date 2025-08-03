using System;
namespace Question02
{
    class BankAccount
    {
        // 1. Private balance field (Encapsulation)
        private double Balance;
        // 2. Constructor with default balance of 500
        public BankAccount()
        {
            Balance = 500;
        }
        // 3. Parameterized constructor
        public BankAccount(double initialBalance)
        {
            if (initialBalance >= 0)
                Balance = initialBalance;
            else
                Balance = 0;
        }
        // 4. Deposit method (with validation)
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        // 5. Withdraw method (with validation)
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}, New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
        // 6. Public method to access balance (Read-only)
        public double GetBalance()
        {
            return Balance;
        }
    }
    // User class with Main method
    class Sanuka
    {
        static void Main(string[] args)
        {
            // Create an object from BankAccount called "savings"
            BankAccount savings = new BankAccount(); // Starts with 500
            savings.Deposit(200);     // Valid deposit
            savings.Deposit(-50);     // Invalid
            savings.Withdraw(100);    // Valid withdrawal
            savings.Withdraw(1000);   // Invalid
            Console.WriteLine($"Final Balance: {savings.GetBalance()}");
        }
    }
}
