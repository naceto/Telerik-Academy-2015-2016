namespace Problem_02.Bank_accounts.Classes
{
    using Problem_02.Bank_accounts.Enumerations;
    using System;

    public class Customer
    {
        private string name;

        public Customer (string name, CustomerType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name 
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        // Customers could be individuals or companies.
        public CustomerType Type { get; private set; }
    }
}
