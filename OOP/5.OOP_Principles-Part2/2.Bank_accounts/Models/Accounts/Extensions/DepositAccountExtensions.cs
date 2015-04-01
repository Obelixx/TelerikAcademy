namespace _2.Bank_accounts.Models.Accounts.Extensions
{
    public static class DepositAccountExtensions
    {
        public static void WithDrawMoney(this DepositAccount acc, decimal withDrawSize)
        {
            acc.Balance -= withDrawSize;
        }
    }
}
