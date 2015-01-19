using System;

//Problem 11. Bank Account Data

//    A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//    Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.


class Bank_Account_Data
{
    static void Main()
    {
        string firstName = "FirstName";
        string middleName = "MiddleName";
        string lastName = "LastName";
        string holderName = string.Format("{0} {1} {2}", firstName, middleName, lastName);
        decimal balance = 1000000000.21m;
        string bankName = "Telerik Bank for miracles";
        string iban = "BG80 TBMG 1234 1234 123456";
        int cardPrefix = 43211234;
        int[] cards = new int[3];
        cards[0] = 12341234;
        cards[1] = 12345678;
        cards[2] = 12357777;

        Console.WriteLine("Holder name: {0,35}", holderName);
        Console.WriteLine("Balance:     {0,35}", balance);
        Console.WriteLine("Bank name:   {0,35}", bankName);
        Console.WriteLine("IBAN:        {0,35}", iban);
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine("Credit Card #{0}: {1,32}", i + 1, cardPrefix.ToString("0000 0000 ") + cards[i].ToString("0000 0000"));
        }
    }
}

