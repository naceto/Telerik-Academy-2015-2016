namespace Problem_02.Bank_accounts.Classes
{
    using Problem_02.Bank_accounts.Enumerations;
    using Problem_02.Bank_accounts.Interfaces;
    using System;

    // Mortgage account can only deposit money.
    // Mortgage accounts have ½ interest for the first 12 months for 
    // companies and no interest for the first 6 months for individuals.
    public class Mortgage : Account, IWithdrawable
    {
        private int halfInterestPeriod;
        public Mortgage(decimal balance, int interest, Customer customer, int interestPeriod)
            : base(balance, interest, customer, interestPeriod)
        {
        }

        private int HalfInterestPeriod
        {
            get { return this.halfInterestPeriod; }
            set
            {
                if (this.Customer.Type == CustomerType.Company)
                {
                    this.halfInterestPeriod = 12;
                }
                else if (this.Customer.Type == CustomerType.Individual)
                {
                    this.halfInterestPeriod = 6;
                }
            }
        }

        public override decimal CalculateInterest(int numberOfMounts)
        {
            int remainder = numberOfMounts - this.HalfInterestPeriod;

            if (remainder >= 0)
            {
                return (remainder * this.InterestRate) + (numberOfMounts * this.halfInterestPeriod);
            }
            else
            {
                return numberOfMounts * this.halfInterestPeriod;
            }
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
