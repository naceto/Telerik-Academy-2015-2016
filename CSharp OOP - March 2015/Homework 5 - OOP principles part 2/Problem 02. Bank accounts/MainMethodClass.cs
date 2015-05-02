namespace Problem_02.Bank_accounts
{
    using Problem_02.Bank_accounts.Classes;
    using Problem_02.Bank_accounts.Enumerations;
    using System;

    class MainMethodClass
    {
        static void Main()
        {
            Bank bank = new Bank();

            Deposit ac = new Deposit(1000, 5, new Customer("Petar", CustomerType.Individual), 12);

            ac.DepositAmount(500);
            ac.WithdrawAmount(100);

            bank.AddAccount(ac);
            bank.AddAccount(new Loan(-100, 6, new Customer("BlqBlq", CustomerType.Company), 6));
            bank.AddAccount(new Mortgage(5000, 6, new Customer("gosho", CustomerType.Company), 18));

            var list = bank.GetList();

            foreach (var item in list)
            {
                Console.WriteLine(item.CalculateInterest(6));
            }
        }
    }
}
