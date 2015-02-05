using System;

//Problem 7. Sort 3 Numbers with Nested Ifs

//    Write a program that enters 3 real numbers and prints them sorted in descending order.
//        Use nested if statements.

//Note: Don’t use arrays and the built-in sorting functionality.

//Examples:
//a 	b 	c 	result
//5 	1 	2 	5 2 1
//-2 	-2 	1 	1 -2 -2
//-2 	4 	3 	4 3 -2
//0 	-2.5 	5 	5 0 -2.5
//-1.1 	-0.5 	-0.1 	-0.1 -0.5 -1.1
//10 	20 	30 	30 20 10
//1 	1 	1 	1 1 1

class Sort_3_Numbers_with_Nested_Ifs
{

    static void exchange(double a, double b, out double newA, out double newB) //switchs the value of a and b
    {

        a = a + b; //change positions, without third "buffer" value;
        b = a - b;
        a = a - b;

        newA = a;
        newB = b;
    }

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

        if (a < b)
        {
            exchange(a, b, out a, out b);
            if (a < c)
            {
                exchange(a, c, out a, out c);
                exchange(b, c, out b, out c);
            }
            else if (b < c) exchange(b, c, out b, out c);
        }
        else
        {
            if (a < c)
            {
                exchange(a, c, out a, out c);
                exchange(b, c, out b, out c);
            }
            else if (b<c) exchange(b, c, out b, out c);
        }

        Console.WriteLine("{0} {1} {2}", a, b, c);
    }
}

