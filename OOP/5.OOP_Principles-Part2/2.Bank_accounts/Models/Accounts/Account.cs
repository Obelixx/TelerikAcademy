namespace _2.Bank_accounts.Models.Accounts
{
    using _2.Bank_accounts.Models.Accounts.Interfaces;
    using _2.Bank_accounts.Models.Customers;
    using System;

    abstract public class Account : IAccount
    {
        private Customer owner;
        internal Customer Owner
        {
            get { return owner; }
            private set { owner = value; }
        }

        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        //customer, balance and interest rate (monthly based). 

        private double interestRate;
        public double InterestRate
        {
            get { return interestRate; }
            private set
            {
                interestRate = value;
            }
        }

        public void DepositMoney(decimal depositSize)
        {
            this.balance += depositSize;
        }

        public Account(Customer customer, decimal balance, double interestRate)
        {
            this.Owner = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        virtual public double CalculateInterestAmount(int periodInMonths)
        {
            return periodInMonths * this.InterestRate;
        }

    }
}
