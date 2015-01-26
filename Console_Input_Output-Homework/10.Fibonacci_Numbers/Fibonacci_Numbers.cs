using System;

//Problem 10. Fibonacci Numbers

//    Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

//Note: You may need to learn how to use loops.

//Examples:
//n 	comments
//1 	0
//3 	0 1 1
//10 	0 1 1 2 3 5 8 13 21 34

class Fibonacci_Numbers
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n (n>0): "); //max is about 47 for int
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 47) Console.WriteLine("Input {0} number (n>0)!", Convert.GetTypeCode(n));
        int fibLast = 0;
        int fib = 0;
        int fibNext = 1;
        for (int i = 1; i <= n; i++)
        {
            if (i != n) Console.Write("{0}, ", fib);
            else Console.Write("{0}\n", fib);
            fib = fibNext;
            fibNext += fibLast;
            fibLast = fib;
        }
    }
}

