using System;

//Problem 2. Numbers Not Divisible by 3 and 7

//    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.

//Examples:
//n 	output
//3 	1 2
//10 	1 2 4 5 8 10

class Numbers_Not_Divisible_by_3_and_7
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
            if (!(i % 3 == 0 || i % 7 == 0)) Console.Write("{0} ", i);

            //or this:
            //if (i % 3 == 0)
            //    continue;
            //if (i % 7 == 0)
            //    continue;
            //Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}

