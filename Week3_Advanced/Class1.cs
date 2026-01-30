// File: Week3_Advanced/Program.cs
// Description: Mastering LINQ for data filtering and sorting.

using System;
using System.Collections.Generic;
using System.Linq; // CRUCIAL: This enables LINQ methods
using Week2_OOP;   // Reference your Week 2 classes

namespace Week3_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Setup a list of accounts
            List<BankAccount> accountList = new List<BankAccount>
            {
                new BankAccount("Patryk", 1500m),
                new SavingsAccount("Emergency Fund", 5000m, 0.05m),
                new BankAccount("Daily Spending", 200m),
                new SavingsAccount("Vacation", 1200m, 0.02m)
            };

            Console.WriteLine("--- All Accounts ---");
            accountList.ForEach(a => a.DisplayBalance());

            // 2. LINQ: Filter accounts with balance > 1000
            // This is much faster than writing 'foreach' and 'if' manually.
            var highValueAccounts = accountList.Where(acc => acc.GetBalance() > 1000).ToList();

            Console.WriteLine("\n--- High Value Accounts (> 1000) ---");
            foreach (var acc in highValueAccounts)
            {
                Console.WriteLine($"Found: {acc.Owner}");
            }

            // 3. LINQ: Sort by balance descending
            var sortedAccounts = accountList.OrderByDescending(acc => acc.GetBalance());

            Console.WriteLine("\n--- Accounts Sorted by Wealth ---");
            foreach (var acc in sortedAccounts)
            {
                acc.DisplayBalance();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}