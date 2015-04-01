namespace _2.Bank_accounts.Models
{
    using _2.Bank_accounts.Models.Customers;
    using System.Collections.Generic;

    public class Bank
    {
        private List<Customer> customers = new List<Customer>();

        internal List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }

    }
}
