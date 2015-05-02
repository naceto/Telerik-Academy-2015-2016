namespace Problem_02.Bank_accounts.Classes
{
    using Problem_02.Bank_accounts.Enumerations;
    using Problem_02.Bank_accounts.Interfaces;
    using System;

    // Loan account can only deposit money.
    // Loan accounts have no interest for the first 3 months if are held by 
    // individuals and for the first 2 months if are held by a company.

    public class Loan : Account, IWithdrawable
    {
        private int promotionInterestPeriod;

        public Loan(decimal balance, int interest, Customer customer, int interestPeriod)
            : base(balance, interest, customer, interestPeriod)
        { 
            if (customer.Type == CustomerType.Individual)
            {
               this.promotionInterestPeriod = 3;
            }
            else if (customer.Type == CustomerType.Company)
            {
                this.promotionInterestPeriod = 2;
            }
        }

        public override decimal CalculateInterest(int numberOfMounts)
        {
            int remainder = numberOfMounts - this.promotionInterestPeriod;

            if (remainder > 0)
            {
                return remainder * this.InterestRate;
            }
            else
            {
                return 0;
            }
        }

        public void WithdrawAmount(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot withdraw negative amount");
            }
            this.Balance -= amount;
        }
    }
}
