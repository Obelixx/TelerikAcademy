using System;

//Problem 14. Decimal to Binary Number

//    Using loops write a program that converts an integer number to its binary representation.
//    The input is entered as long. The output should be a variable of type string.
//    Do not use the built-in .NET functionality.

//Examples:
//decimal 	binary
//0 	0
//3 	11
//43691 	1010101010101011
//236476736 	1110000110000101100101000000

class Decimal_to_Binary_Number
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        long dec = 0;
        Console.Write("Input decimal(dec>=0): ");
        while (!long.TryParse(Console.ReadLine(), out dec) || dec < 0) Console.WriteLine("Input {0} number!(dec>=0)", Convert.GetTypeCode(dec));

        string bin = "";
        do
        {
            bin = (dec % 2).ToString() + bin;
            dec /= 2;
        } while (dec != 0);
        Console.WriteLine(bin);
    }
}

