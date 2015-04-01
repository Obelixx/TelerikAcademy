namespace _2.Bank_accounts.Models.Accounts
{
    using _2.Bank_accounts.Models.Accounts.Interfaces;
    using _2.Bank_accounts.Models.Customers;

    public class LoanAccount : Account, IAccount
    {
        public LoanAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override double CalculateInterestAmount(int periodInMonths)
        {
            if (this.Owner is Individual && periodInMonths <= 3)
            {
                return 0;
            }
            else if (this.Owner is Company && periodInMonths <= 2)
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
