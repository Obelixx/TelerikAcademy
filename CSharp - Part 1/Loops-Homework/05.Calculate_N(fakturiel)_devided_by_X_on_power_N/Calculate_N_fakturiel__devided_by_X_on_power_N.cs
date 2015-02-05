using System;

//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//    Use only one loop. Print the result with 5 digits after the decimal point.

//Examples:
//n 	x 	S
//3 	2 	2.75000
//4 	3 	2.07407
//5 	-4 	0.75781

class Calculate_N_fakturiel__devided_by_X_on_power_N
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n (n>1): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 2) Console.WriteLine("Input {0} number (n>1)!", Convert.GetTypeCode(n));
        int x = 0;
        Console.Write("Input x: ");
        while (!int.TryParse(Console.ReadLine(), out x)) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(x));

        long fakturiel = 1;
        long power = 1;
        double sum = 1.0;
        for (int i = 1; i <= n; i++)
        {
            fakturiel *= i;
            power *= x;
            sum += (double)fakturiel / power;
        }
        Console.WriteLine("S = {0:0.00000}", sum);
    }
}

