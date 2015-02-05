using System;

//Problem 8. Numbers from 1 to n

//    Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

//Note: You may need to use a for-loop.

//Examples:
//input 	output
//3 	1
//    2
//    3
//5 	1
//    2
//    3
//    4
//    5
//1 	1

class Numbers_from_1_to_n
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n (n>0): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
        {
            Console.WriteLine("Input {0} number (n>0)!", Convert.GetTypeCode(n));
        }
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }

    }
}

