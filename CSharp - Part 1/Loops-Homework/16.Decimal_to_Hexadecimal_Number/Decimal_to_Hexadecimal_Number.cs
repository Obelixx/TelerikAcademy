using System;

//Problem 16. Decimal to Hexadecimal Number

//    Using loops write a program that converts an integer number to its hexadecimal representation.
//    The input is entered as long. The output should be a variable of type string.
//    Do not use the built-in .NET functionality.

//Examples:
//decimal 	hexadecimal
//254 	FE
//6883 	1AE3
//338583669684 	4ED528CBB4

class Decimal_to_Hexadecimal_Number
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        long dec = 0;
        Console.Write("Input decimal(dec>=0): ");
        while (!long.TryParse(Console.ReadLine(), out dec) || dec < 0) Console.WriteLine("Input {0} number!(dec>=0)", Convert.GetTypeCode(dec));

        string hex = "";
        long tempHex;
        do
        {
            tempHex = (dec % 16);

            switch(tempHex)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    hex = tempHex.ToString() + hex;
                    break;
                case 10:
                    hex = "A" + hex;
                    break;
                case 11:
                    hex = "B" + hex;
                    break;
                case 12:
                    hex = "C" + hex;
                    break;
                case 13:
                    hex = "D" + hex;
                    break;
                case 14:
                    hex = "E" + hex;
                    break;
                case 15:
                    hex = "F" + hex;
                    break;
                default:
                    Console.WriteLine("invalid string");
                    return;
            }
            dec /= 16;
        } while (dec != 0);
        Console.WriteLine(hex);

    }
}

