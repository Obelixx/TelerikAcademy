namespace _2.Bank_accounts.Models.Customers
{
    using _2.Bank_accounts.Models.Accounts;
    using System.Collections.Generic;


    abstract public class Customer
    {
        private List<Account> accounts = new List<Account>();

        public List<Account> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }



    }
}
