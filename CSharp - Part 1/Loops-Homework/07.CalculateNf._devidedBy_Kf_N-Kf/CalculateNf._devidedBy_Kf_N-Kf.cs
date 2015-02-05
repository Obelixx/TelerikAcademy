using System;

//Problem 7. Calculate N! / (K! * (N-K)!)

//    In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

//Examples:
//n 	k 	n! / (k! * (n-k)!)
//3 	2 	3
//4 	2 	6
//10 	6 	210
//52 	5 	2598960

class CalculateNf_devidedBy_Kf_N_Kf
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n (n>0): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1) Console.WriteLine("Input {0} number (n>0)!", Convert.GetTypeCode(n));
        int k = 0;
        Console.Write("Input k (k>0): ");
        while (!int.TryParse(Console.ReadLine(), out k) || k < 1) Console.WriteLine("Input {0} number(k>0)!", Convert.GetTypeCode(k));
        
        ulong fakturielN = 1;
        ulong fakturielK = 1;
        
        int bigger = Math.Max(n, k);
        for (int i = 1; i <= bigger; i++)
        {
            if (i <= n && i > n-k) fakturielN *= (ulong)i;
            if (i <= k) fakturielK *= (ulong)i;
            
        }
        Console.WriteLine("n! / (k! * (n-k)!) = {0}", fakturielN / fakturielK);
    }
}

