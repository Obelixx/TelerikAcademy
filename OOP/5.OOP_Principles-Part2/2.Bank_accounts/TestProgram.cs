namespace _2.Bank_accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using _2.Bank_accounts.Models;
    using _2.Bank_accounts.Models.Customers;
    using _2.Bank_accounts.Models.Accounts;
    using _2.Bank_accounts.Models.Accounts.Extensions;

    class TestProgram
    {
        static void Main()
        {
            var kasichka = new Bank();
            kasichka.Customers.Add(new Company());
            kasichka.Customers[0].Accounts.Add(new DepositAccount(kasichka.Customers[0], 1000, 0.2));
            kasichka.Customers[0].Accounts.Add(new LoanAccount(kasichka.Customers[0], 1000, 0.2));
            kasichka.Customers[0].Accounts.Add(new MortgageAccount(kasichka.Customers[0], 1000, 0.2));


            foreach (var acc in kasichka.Customers[0].Accounts)
            {
                Console.WriteLine(acc.CalculateInterestAmount(12));
            }
            Console.WriteLine("---");

            kasichka.Customers[0].Accounts[0].DepositMoney(1); // doing deposit to Any Account
            kasichka.Customers[0].Accounts[1].DepositMoney(1);
            kasichka.Customers[0].Accounts[2].DepositMoney(1);
            foreach (var acc in kasichka.Customers[0].Accounts)
            {
                Console.WriteLine("Interest: " + acc.CalculateInterestAmount(12));
                Console.WriteLine("Balance: " + acc.Balance);
            }
            Console.WriteLine("---");

            // doing WithDraw from Deposit Account
            DepositAccount depositAcc = (DepositAccount)kasichka.Customers[0].Accounts[0]; // doing this becouse we keep accounts in list of base class
            depositAcc.WithDrawMoney(12);
            foreach (var acc in kasichka.Customers[0].Accounts)
            {
                Console.WriteLine("Interest: " + acc.CalculateInterestAmount(13)); // anather amount of mouths ( to test company calculation)
                Console.WriteLine("Balance: " + acc.Balance);
            }
            Console.WriteLine("---");

            var notDepositAcc = kasichka.Customers[0].Accounts[1]; //tring to do WithDraw from non Deposit Account
            //notDepositAcc.WithDrawMoney(12); // cant even compile
            foreach (var acc in kasichka.Customers[0].Accounts)
            {
                Console.WriteLine("Interest: " + acc.CalculateInterestAmount(12));
                Console.WriteLine("Balance: " + acc.Balance);
            }
            Console.WriteLine("---");

        }

    }
}
