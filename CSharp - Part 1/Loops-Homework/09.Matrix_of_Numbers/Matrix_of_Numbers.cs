using System;

//Problem 9. Matrix of Numbers

//    Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

//Examples:

//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1 2 3 4
//        2 3                 2 3 4               2 3 4 5
//                            3 4 5               3 4 5 6
//                                                4 5 6 7

class Matrix_of_Numbers
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n (0 <= n <= 20): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 20) Console.WriteLine("Input {0} number (0 <= n <= 20)!", Convert.GetTypeCode(n));

        int pad = 2;
        if (n > 5) pad = 3;

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write((j + i).ToString().PadLeft(pad));
            }
            Console.WriteLine();
        }
    }
}
