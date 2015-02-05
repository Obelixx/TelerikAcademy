using System;

//Problem 6. Calculate N! / K!

//    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//    Use only one loop.

//Examples:
//n 	k 	n! / k!
//5 	2 	60
//6 	5 	6
//8 	3 	6720

class Calculate_N_fakturiel_devidedBy_K_fakturiel
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n (n>0): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1) Console.WriteLine("Input {0} number (n>1)!", Convert.GetTypeCode(n));
        int k = 0;
        Console.Write("Input k (k>0): ");
        while (!int.TryParse(Console.ReadLine(), out k) || k < 1) Console.WriteLine("Input {0} number(k>0)!", Convert.GetTypeCode(k));

        long fakturielN = 1;
        long fakturielK = 1;
        int bigger = Math.Max(n, k);
        for (int i = 1; i <= bigger ; i++)
        {
            if (i <= n) fakturielN *= i;
            if (i <= k) fakturielK *= i;
        }
        Console.WriteLine("n! / k! = {0}", fakturielN / fakturielK);
    }
}