namespace _2.Bank_accounts.Models.Accounts.Interfaces
{
    public interface IAccount
    {
        //customer, balance and interest rate (monthly based). 

        void DepositMoney(decimal depositSize);
        double CalculateInterestAmount(int periodInMonths);

    }
}
