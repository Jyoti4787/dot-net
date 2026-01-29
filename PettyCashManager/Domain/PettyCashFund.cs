using System;

namespace PettyCashManager.Domain
{
    // Represents the petty cash fund with basic operations
    public class PettyCashFund
    {
        // Friendly name for the fund
        public string Name { get; }

        // Current available balance
        public decimal Balance { get; private set; }

        // Constructor sets name and initial balance
        public PettyCashFund(string name, decimal initialBalance)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Fund name is required", nameof(name));

            if (initialBalance < 0)
                throw new ArgumentException("Initial balance cannot be negative", nameof(initialBalance));

            Name = name;
            Balance = initialBalance;
        }

        // Increase the fund balance (e.g., reimburse/top-up)
        public void Increase(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be greater than zero", nameof(amount));
            Balance += amount;
        }

        // Decrease the fund balance (e.g., approved expense)
        // Returns false if insufficient balance
        public bool Decrease(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be greater than zero", nameof(amount));

            if (Balance < amount) return false;

            Balance -= amount;
            return true;
        }
    }
}
