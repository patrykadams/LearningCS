// File: BankRunner.cs
// Role: The main entry point for the CSharp_Masterclass application.
using System;
using Week2_OOP;

namespace CSharp_Masterclass
{
    class BankRunner
    {
                static void Main(string[] args)
        {
            Console.WriteLine("=== Automated Banking System Runner ===");

            try
            {
                RunApp();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Critical Error: {ex.Message}");
            }
        }

        static void RunApp()
        {
            BankAccount account = new BankAccount("Patryk", 1000m);
            account.DisplayBalance();
        }
    }
}