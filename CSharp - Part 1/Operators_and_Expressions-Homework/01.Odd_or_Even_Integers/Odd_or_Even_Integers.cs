using System;

//Problem 1. Odd or Even Integers

//    Write an expression that checks if given integer is odd or even.

//Examples:
//n 	Odd?
//3 	true
//2 	false
//-2 	false
//-1 	true
//0 	false

class Odd_or_Even_Integers
{
    static void Main()
    {
        int n = 0;
        Console.Write("Input number:");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(n));
        }
        bool isOdd = n % 2 != 0;
        Console.WriteLine("Odd?: {0}", isOdd);
        Console.WriteLine("Number {0} is {1}", n, !isOdd ? "Even!" : "Odd!");
    }
}

