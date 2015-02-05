using System;

//Problem 4. Multiplication Sign

//    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//        Use a sequence of if operators.

//Examples:
//a 	b 	c 	result
//5 	2 	2 	+
//-2 	-2 	1 	+
//-2 	4 	3 	-
//0 	-2.5 	4 	0
//-1 	-0.5 	-5.1 	-

class Multiplication_Sign
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

        if (a == 0 || b == 0 || c == 0) //check for 0
        {
            Console.WriteLine("0");
            return;                     //stop processing - result is given
        }

        bool isMinus = false;   //inputing start value

        isMinus = a < 0 ^ b < 0 ^ c < 0;    //xOR with "true" inverts the bool value.

        if (isMinus) Console.WriteLine("-");
        else Console.WriteLine("+");

        // This is with sequence of "if" operators. May be, clearer to read, but longer to write, xe-xe-xe :).
        isMinus = false;    //start value again
        if (a < 0) isMinus = true;
        if (b < 0) isMinus = !isMinus;
        if (c < 0) isMinus = !isMinus;

        if (isMinus) Console.WriteLine("-");
        else Console.WriteLine("+");

    }
}

