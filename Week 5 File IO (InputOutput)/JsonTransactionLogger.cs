// File: JsonTransactionLogger.cs
// Description: Modern JSON-based data persistence.
// Professional Comments: English

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; // The "Modern" engine

namespace CSharp_Masterclass
{
    // A simple class to represent the data structure
    public class TransactionEntry
    {
        public DateTime Timestamp { get; set; }
        public string Owner { get; set; }
        public string Action { get; set; }
        public decimal Amount { get; set; }
    }

    public static class JsonTransactionLogger
    {
        private const string FileName = "Transactions.json";

        public static void SaveTransaction(string owner, string action, decimal amount)
        {
            List<TransactionEntry> history = LoadAllTransactions();

            // Create the new entry object
            var newEntry = new TransactionEntry
            {
                Timestamp = DateTime.Now,
                Owner = owner,
                Action = action,
                Amount = amount
            };

            history.Add(newEntry);

            // Serialize the list to a "pretty-printed" JSON string
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(history, options);

            File.WriteAllText(FileName, jsonString);
        }

        public static List<TransactionEntry> LoadAllTransactions()
        {
            if (!File.Exists(FileName)) return new List<TransactionEntry>();

            string jsonString = File.ReadAllText(FileName);

            // Deserialize: Turn the text back into a List of Objects!
            return JsonSerializer.Deserialize<List<TransactionEntry>>(jsonString)
                   ?? new List<TransactionEntry>();
        }
    }
}