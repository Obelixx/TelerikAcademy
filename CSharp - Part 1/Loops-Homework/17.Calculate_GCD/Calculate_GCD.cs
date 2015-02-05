using System;

//Problem 17.* Calculate GCD

//    Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//    Use the Euclidean algorithm (find it in Internet).

//Examples:
//a 	b 	GCD(a, b)
//3 	2 	1
//60 	40 	20
//5 	-15 	5

class Calculate_GCD
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int a = 0;
        Console.Write("Input a: ");
        while (!int.TryParse(Console.ReadLine(), out a)) Console.WriteLine("Input {0} number (n>0)!", Convert.GetTypeCode(a));
        int b = 0;
        Console.Write("Input b: ");
        while (!int.TryParse(Console.ReadLine(), out b)) Console.WriteLine("Input {0} number (b>0)!", Convert.GetTypeCode(b));


        //      function gcd(a, b)
        //while b ≠ 0
        //  var t := b
        //  b := a mod b
        //  a := t
        //return a

        int gnd;
        int temp;
        while (b != 0)
        {
            temp = b;
            b = a % b;
            a = temp;
        }
        gnd = a;
        Console.WriteLine("GND = " + gnd);
    }
}
