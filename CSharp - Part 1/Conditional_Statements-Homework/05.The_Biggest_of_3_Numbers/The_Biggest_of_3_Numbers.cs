using System;

//Problem 5. The Biggest of 3 Numbers

//    Write a program that finds the biggest of three numbers.

//Examples:
//a 	b 	c 	biggest
//5 	2 	2 	5
//-2 	-2 	1 	1
//-2 	4 	3 	4
//0 	-2.5 	5 	5
//-0.1 	-0.5 	-1.1 	-0.1

class The_Biggest_of_3_Numbers
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

        double c = 0;
        Console.Write("Input c: ");
        while (!double.TryParse(Console.ReadLine(), out c)) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(c));

        double biggest;
        if (a > b) biggest = a;
        else biggest = b;
        if (biggest < c) biggest = c;

        Console.WriteLine(biggest);
    }
}

