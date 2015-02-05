using System;

//Problem 1. Numbers from 1 to N

//    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

//Examples:
//n 	output
//3 	1 2 3
//5 	1 2 3 4 5

class Numbers_from_1_to_N
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n (n>0): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1) Console.WriteLine("Input {0} number (n>0)!", Convert.GetTypeCode(n));

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
        
    }
}

