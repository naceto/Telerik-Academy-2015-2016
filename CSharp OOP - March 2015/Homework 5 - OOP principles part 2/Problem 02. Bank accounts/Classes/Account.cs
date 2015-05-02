namespace Problem_02.Bank_accounts.Classes
{
    using System;

    // All accounts have customer, balance and interest rate (monthly based).
    public abstract class Account
    {
        public Account(decimal balance, int interest, Customer customer, int interestPeriod)
        {
            this.Balance = balance;
            this.InterestRate = interest;
            this.Customer = customer;
            this.InterestPeriod = interestPeriod;
        }

        public decimal Balance { get; protected set; }
        
        public int InterestRate { get; protected set; }

        public int InterestPeriod { get; protected set; }

        public Customer Customer { get; private set; }

        /* All accounts can calculate their interest amount for a given period 
         * (in months). In the common case its is calculated as follows: 
         * number_of_months * interest_rate. 
         */
        public virtual decimal CalculateInterest(int numberOfMounts)
        {
            if (numberOfMounts < 0)
            {
                throw new ArgumentException("numberOfMounts cannot be negative");
            }

            return numberOfMounts * this.InterestRate;
        }
    }
}
