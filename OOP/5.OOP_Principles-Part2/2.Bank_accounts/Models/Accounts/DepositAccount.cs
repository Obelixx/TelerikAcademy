namespace _2.Bank_accounts.Models.Accounts
{
    using _2.Bank_accounts.Models.Accounts.Interfaces;
    using _2.Bank_accounts.Models.Customers;

    public class DepositAccount : Account, IAccount
    {
        public DepositAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }


        public override double CalculateInterestAmount(int periodInMonths)
        {
            if (this.Balance>=0 && this.Balance<=1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterestAmount(periodInMonths);
            }
        }

    }
}
