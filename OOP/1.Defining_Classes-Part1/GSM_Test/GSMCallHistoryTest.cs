namespace GSMTests
{
    using System;
    using GSM_Namespace;

    //Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.

    //Create an instance of the GSM class.
    //Add few calls.
    //Display the information about the calls.
    //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
    //Remove the longest call from the history and calculate the total price again.
    //Finally clear the call history and print it.

    public static class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            var phone = GSM.IPhone4s;
            phone.AddCallToCallhistoryNow("+1231352145", 60);
            phone.AddCallToCallhistory(DateTime.Now.AddMinutes(5d), "+121235", 180);
            phone.AddCallToCallhistory(DateTime.Now.AddMinutes(15d), "+12312412235", 30);
            phone.AddCallToCallhistory(DateTime.Now.AddMinutes(15d), "+12312412235", 30);

            double pricePerMinute = 0.37d; // 1d;
            Console.WriteLine("Full call history:\n {0}\n", phone.CallHistory);
            Console.WriteLine("Total price (priceing is 60/60 with {0} units/min): {1}\n", pricePerMinute, phone.CallPrice(pricePerMinute));

            phone.CallHistoryDeleteLongestCall(); 
            Console.WriteLine("Deleting longest call done!\n");

            Console.WriteLine("Full call history:\n {0}\n", phone.CallHistory);
            Console.WriteLine("Total price (priceing is 60/60 with {0} units/min): {1}\n", pricePerMinute, phone.CallPrice(pricePerMinute));

            phone.CallHistoryClear(); 
            Console.WriteLine("Deleting call history done!\n");

            Console.WriteLine("Full call history:\n {0}\n", phone.CallHistory);
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
            Console.Clear();

        }
    }
}