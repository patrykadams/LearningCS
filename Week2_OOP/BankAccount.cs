// File: BankAccount.cs
// Location: Week2_OOP/
// Purpose: Base class demonstrating access modifiers and virtual methods.

using System;

namespace Week2_OOP
{
    public class BankAccount
    {
        public string Owner { get; set; }
        // Protected: Only child classes can access this directly.
        protected decimal Balance { get; set; }

        public BankAccount(string owner, decimal initialBalance)
        {
            Owner = owner;
            Balance = initialBalance;
        }

        // Virtual: Permission for children to override.
        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{Owner} withdrew {amount:C}. New Balance: {Balance:C}");
            }
        }
    }
}