using System;

//Problem 18.* Trailing Zeroes in N!

//    Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//    Your program should work well for very big numbers, e.g. n=100000.

//Examples:
//n 	trailing zeroes of n! 	explaination
//10 	2 	3628800
//20 	4 	2432902008176640000
//100000 	24999 	think why

class Trailing_Zeroes_in_Nfakturiel
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n (n>0): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) Console.WriteLine("Input {0} number (n>0)!", Convert.GetTypeCode(n));

        int trailingZeros = 0;
        int powOfFive = 5;
        int devidet;
        do
        {
            devidet = n / powOfFive;
            trailingZeros += devidet;
            powOfFive *= 5;
        } while (devidet >= 1);
        Console.WriteLine("trailing zeroes of {0}! -> {1}",n,trailingZeros);
    }
}
