using System;
namespace c__inclass_code
{
    public class BankAccount
    {
        // Properties
        public int AccountNumber;
        public double Balance;
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Develop a console program that models a simple bank account.
            // Create a class named 'BankAccount' with properties AccountNumber and Balance.
            // Implement a method 'Deposit' that allows the user to deposit money into the account.
            // Instantiate an object, perform a deposit, and display the updated balance.
            BankAccount account = new BankAccount();
            account.AccountNumber = 345678;
            account.Balance = 1000.00;
            Console.WriteLine("Enter the amount to deposit: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            account.Deposit(depositAmount);
            Console.WriteLine("Account Balance: " + account.Balance);
            Console.ReadKey();
        }
    }
}
