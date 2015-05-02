namespace Problem_02.Bank_accounts.Classes
{
    using Problem_02.Bank_accounts.Interfaces;
    using System;

    // Deposit accounts are allowed to deposit and with draw money.
    // Deposit accounts have no interest if their balance is positive and less than 1000.
    public class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit(decimal balance, int interest, Customer customer, int interestPeriod)
            : base(balance, interest, customer, interestPeriod)
        {
            if (balance > 0 && balance < 1000)
            {
                this.InterestRate = 0;
            }
        }

        public void DepositAmount(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot deposit negative amount.");
            }
            this.Balance += amount;
        }

        public void WithdrawAmount(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot withdraw negative amount.");
            }
            this.Balance -= amount;
        }
    }
}
