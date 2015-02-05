using System;

//Problem 13. Binary to Decimal Number

//    Using loops write a program that converts a binary integer number to its decimal form.
//    The input is entered as string. The output should be a variable of type long.
//    Do not use the built-in .NET functionality.

//Examples:
//binary 	decimal
//0 	0
//11 	3
//1010101010101011 	43691
//1110000110000101100101000000 	236476736

class Binary_to_Decimal_Number
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
                
        for (int i = 0; i < inputString.Length; i++) // check for errors in string
        {
            if (inputString[i] != '0')
            {
                if (inputString[i] != '1') 
                {
                    Console.WriteLine("invalid string");
                    return;
                }
            }
        }


        long result = 0;
        long powerOfTwo = 1;
        for (int i = inputString.Length-1; i >= 0; i--) // check for errors in string
        {
            if (inputString[i] == '1') result += powerOfTwo;
            powerOfTwo *= 2;
        }
        Console.WriteLine(result);

    }
}
