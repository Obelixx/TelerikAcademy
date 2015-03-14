namespace GSMTests
{
    using System;
    using GSM_Namespace;
    using GSM_Namespace.Components;

    //Problem 7. GSM test

    //    Write a class GSMTest to test the GSM class:
    //        Create an array of few instances of the GSM class.
    //        Display the information about the GSMs in the array.
    //        Display the information about the static property IPhone4S

    public static class GSMTest
    {
        public static void TestGSM()
        {
            var phones = new GSM[5];
            phones[0] = new GSM("Mokia", "Nicrosoft");
            phones[1] = new GSM("Buha-ha-ha", "Free-Hands", 20, new Battery(Battery.BatteryType.NiMh), new Display(20, 3000));
            phones[1].Owner = "Baj Ivan";
            phones[2] = GSM.IPhone4s;
            Console.WriteLine("Array created!");
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < phones.Length; i++)
            {
                if (phones[i] != null)
                {
                    Console.WriteLine("Phone[{0}]:", i);
                    Console.WriteLine(phones[i]);
                }
            }
            Console.WriteLine("Array printed!");
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(GSM.IPhone4s);
            Console.WriteLine("Static property printed!");
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}