using System;

//Problem 6. Four-Digit Number

//    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//        Prints on the console the number in reversed order: dcba (in our example 1102).
//        Puts the last digit in the first position: dabc (in our example 1201).
//        Exchanges the second and the third digits: acbd (in our example 2101).

//The number has always exactly 4 digits and cannot start with 0.

//Examples:
//n 	sum of digits 	reversed 	last digit in front 	second and third digits exchanged
//2011 	4 	1102 	1201 	2101
//3333 	12 	3333 	3333 	3333
//9876 	30 	6789 	6987 	9786

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input four-digit number:");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1000 || n > 9999)
        {
            Console.WriteLine("Input four-digit {0} Number!", Convert.GetTypeCode(n));
        }
        int tempN = n;
        byte[] digits = new byte[4];
        for (int i = 0; i < 4; i++)
        {
            digits[i] = (byte)(tempN % 10);
            tempN /= 10;
        }

        byte sum = 0;
        for (int i = 0; i < 4; i++)
        {
            sum += digits[i];
        }

        int reversed = 0;
        for (int i = 0; i < 4; i++)
        {
            reversed = reversed * 10 + digits[i];
        }

        int lastdigitFront = digits[0];
        for (int i = 3; i > 0; i--)
        {
            lastdigitFront = lastdigitFront * 10 + digits[i];
        }

        int secondAndThird = 0;
        secondAndThird += digits[3];
        secondAndThird = secondAndThird * 10 + digits[1];
        secondAndThird = secondAndThird * 10 + digits[2];
        secondAndThird = secondAndThird * 10 + digits[0];

        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", "n", "sum", "reversed", "last digit in front", "second and third");
        Console.WriteLine("{0:0000}\t{1}\t{2:0000}\t\t{3:0000}\t\t\t{4:0000}", n, sum, reversed, lastdigitFront, secondAndThird);
    }
}

