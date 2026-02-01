// File: TransactionLogger.cs
// Purpose: Week 5 - Persisting data to the file system.
using System;
using System.IO; // Required for File operations

namespace CSharp_Masterclass
{
    public static class TransactionLogger
    {
        private static string filePath = "TransactionHistory.txt";

        public static void LogTransaction(string owner, string action, decimal amount)
        {
            string logEntry = $"[{DateTime.Now}] {owner} | {action}: {amount:C}{Environment.NewLine}";

            try
            {
                // File.AppendAllText creates the file if it doesn't exist
                // and adds the new line to the end of it.
                File.AppendAllText(filePath, logEntry);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to save log: {ex.Message}");
            }
        }

        public static void ViewLogs()
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("--- Transaction History ---");
                string history = File.ReadAllText(filePath);
                Console.WriteLine(history);
            }
            else
            {
                Console.WriteLine("No transaction history found.");
            }
        }
    }
}