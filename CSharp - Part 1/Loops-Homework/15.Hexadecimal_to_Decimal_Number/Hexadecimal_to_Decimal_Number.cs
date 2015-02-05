using System;

//Problem 15. Hexadecimal to Decimal Number

//    Using loops write a program that converts a hexadecimal integer number to its decimal form.
//    The input is entered as string. The output should be a variable of type long.
//    Do not use the built-in .NET functionality.

//Examples:
//hexadecimal 	decimal
//FE 	254
//1AE3 	6883
//4ED528CBB4 	338583669684

class Hexadecimal_to_Decimal_Number
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;


        string inputString = string.Empty;
        while (inputString == null || inputString == string.Empty)
        {
            Console.Write("Input binary string: ");
            inputString = Console.ReadLine();
        }

        inputString = inputString.ToUpper();

        long decResult = 0;
        long hexPower = 1;
        for (int i = inputString.Length - 1; i >= 0; i--) // checks for errors too
        {
            switch (inputString[i])
            {
                case '0':
                    break;
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    decResult += long.Parse(inputString[i].ToString()) * hexPower;
                    break;
                case 'A':
                    decResult += 10 * hexPower;
                    break;
                case 'B':
                    decResult += 11 * hexPower;
                    break;
                case 'C':
                    decResult += 12 * hexPower;
                    break;
                case 'D':
                    decResult += 13 * hexPower;
                    break;
                case 'E':
                    decResult += 14 * hexPower;
                    break;
                case 'F':
                    decResult += 15 * hexPower;
                    break;
                default:
                    Console.WriteLine("invalid string");
                    return;
            }
            hexPower *= 16;
        }

        Console.WriteLine(decResult);


    }
}
