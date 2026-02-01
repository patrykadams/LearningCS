// File: BankRunner.cs
// Purpose: Week 4 - Defensive Programming & Exception Handling
using System;
using Week2_OOP;

namespace CSharp_Masterclass
{
    class BankRunner
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Secure Banking Portal ===");
            BankAccount myAccount = new BankAccount("Patryk", 1000m);

            try
            {
                Console.Write("Enter withdrawal amount: ");
                string input = Console.ReadLine();

                // Potential Error: User enters "ABC"
                decimal amount = decimal.Parse(input);

                if (amount <= 0)
                {
                    // Manually throwing an error for bad logic
                    throw new ArgumentException("Amount must be a positive number.");
                }
                // NEW: Log the success
                JsonTransactionLogger.SaveTransaction(myAccount.Owner, "Withdrawal", amount);
                Console.WriteLine("Transaction saved to JSON successfully.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a numeric value only.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Validation Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // General safety net for anything we didn't expect
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nTransaction process complete. Have a nice day!");
            }
            TransactionLogger.ViewLogs();

            Console.ReadKey();
        }
    }
}