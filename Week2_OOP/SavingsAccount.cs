using System;

namespace Week2_OOP
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal initialBalance, decimal interestRate)
            : base(owner, initialBalance)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(decimal amount)
        {
            const decimal penalty = 5.00m;
            Console.WriteLine("Savings: Applying $5 penalty.");
            base.Withdraw(amount + penalty);
        }
    }
}