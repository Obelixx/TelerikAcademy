using System;

//Problem 9. Exchange Variable Values

//    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//    Print the variable values before and after the exchange.

class Exchange_Variable_Values
{
    static void Main()
    {
        int a = 5; // 5*2=10
        int b = 10; // 10/2=5
        Console.WriteLine("Before the exchange a={0} and b={1}", a, b);
        a <<= 1;
        b >>= 1;
        Console.WriteLine("After the exchange a={0} and b={1}", a, b);
    }
}
