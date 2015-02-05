using System;

//Problem 4. Number Comparer

//    Write a program that gets two numbers from the console and prints the greater of them.
//    Try to implement this without if statements.

//Examples:
//a 	b 	greater
//5 	6 	6
//10 	5 	10
//0 	0 	0
//-5 	-2 	-2
//1.5 	1.6 	1.6

class Number_Comparer
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double a = 0;
        Console.Write("Input a:");
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(a));
        }

        double b = 0;
        Console.Write("Input b:");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(b));
        }

        Console.WriteLine("a\tb\tgreater");
        Console.WriteLine("{0}\t{1}\t{2}",a,b,Math.Max(a,b));
        
    }
}

