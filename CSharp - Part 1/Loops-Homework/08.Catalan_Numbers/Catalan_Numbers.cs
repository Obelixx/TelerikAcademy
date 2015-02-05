using System;
using System.Numerics;//this exist inf .net Framework >= 4.5 // if not working for you - use long type and choose n<=30

//Problem 8. Catalan Numbers

//    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//    Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

//Examples:
//n 	Catalan(n)
//0 	1
//5 	42
//10 	16796
//15 	9694845

class Catalan_Numbers
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n (0 <= n <= 100): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 100) Console.WriteLine("Input {0} number (0 <= n <= 100)!", Convert.GetTypeCode(n));


        BigInteger cn = 1; // if not working for you - use ulong type and choose n<=30

        if (n > 1)
            for (int i = n * 2, j = 1; j <= n; i--, j++)
            {
                checked
                {
                    if (i > n + 1) cn *= i;
                    if (j <= n) cn /= j;
                }
            }
        Console.WriteLine("Cn[{0}]={1}",n,cn);
    }
}
