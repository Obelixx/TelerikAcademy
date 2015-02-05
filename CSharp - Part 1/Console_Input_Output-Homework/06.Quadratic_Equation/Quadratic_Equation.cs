using System;

//Problem 6. Quadratic Equation

//    Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

//Examples:
//a 	b 	c 	roots
//2 	5 	-3 	x1=-3; x2=0.5
//-1 	3 	0 	x1=3; x2=0
//-0.5 	4 	-8 	x1=x2=4
//5 	2 	8 	no real roots

class Quadratic_Equation
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double a = 0;
        Console.Write("Input a: ");
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(a));
        }

        double b = 0;
        Console.Write("Input b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(b));
        }

        double c = 0;
        Console.Write("Input c: ");
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(c));
        }

        double x1 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        double x2 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

        if (double.IsNaN(x1) || double.IsNaN(x2)) Console.WriteLine("no real roots");
        else Console.WriteLine(x1 == x2 ? "x1=x2=" + x1 : "x1=" + x1 + "; x2=" + x2);
    }
}
