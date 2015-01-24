using System;

//Problem 9. Trapezoids

//    Write an expression that calculates trapezoid's area by given sides a and b and height h.

//Examples:
//a 	b 	h 	area
//5 	7 	12 	72
//2 	1 	33 	49.5
//8.5 	4.3 	2.7 	17.28
//100 	200 	300 	45000
//0.222 	0.333 	0.555 	0.1540125

class Trapezoids
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double a = 0;
        Console.Write("Input a: ");
        while (!double.TryParse(Console.ReadLine(), out a) || a < 0)
        {
            Console.WriteLine("Input {0} number > 0!", Convert.GetTypeCode(a));
        }

        double b = 0;
        Console.Write("Input b: ");
        while (!double.TryParse(Console.ReadLine(), out b) || b < 0)
        {
            Console.WriteLine("Input {0} number > 0!", Convert.GetTypeCode(b));
        }

        double h = 0;
        Console.Write("Input h: ");
        while (!double.TryParse(Console.ReadLine(), out h) || h < 0)
        {
            Console.WriteLine("Input {0} number > 0!", Convert.GetTypeCode(h));
        }

        double area = (a + b) / 2d * h;

        Console.WriteLine("{0}\t{1}\t{2}\t{3}", "a", "b", "h", "area");
        Console.WriteLine("{0}\t{1}\t{2}\t{3}", a, b, h, area);

    }
}

