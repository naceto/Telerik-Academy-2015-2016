namespace Problem_02.Bank_accounts.Classes
{
    using System;
    using System.Collections.Generic;

    // bank holds different types of accounts for its customers: deposit accounts, 
    // loan accounts and mortgage accounts. Customers could be individuals or companies.
    public class Bank
    {
        private HashSet<Account> accounts;

        public Bank ()
        {
            accounts = new HashSet<Account>();
        }

        public Bank(HashSet<Account> accounts)
        {
            this.accounts = accounts;
        }

        public void AddAccount (Account account)
        {
            this.accounts.Add(account);
        }

        public void RemoveAccount (Account account)
        {
            this.accounts.Remove(account);
        }

        public HashSet<Account> GetList ()
        {
            return this.accounts;
        }
    }
}
