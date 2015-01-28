using System;

//Problem 1. Exchange If Greater

//    Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

//Examples:
//a 	b 	result
//5 	2 	2 5
//3 	4 	3 4
//5.5 	4.5 	4.5 5.5

class Exchange_If_Greater
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double a = 0;
        Console.Write("Input a: ");
        while (!double.TryParse(Console.ReadLine(), out a)) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(a));

        double b = 0;
        Console.Write("Input b: ");
        while (!double.TryParse(Console.ReadLine(), out b)) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(b));

        if (a > b)
        {
            a = a + b; //change positions, without third "buffer" value;
            b = a - b;
            a = a - b;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}

