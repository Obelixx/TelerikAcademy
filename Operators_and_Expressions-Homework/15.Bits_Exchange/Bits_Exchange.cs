using System;

//Problem 15.* Bits Exchange

//    Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

//Examples:
//n 	binary representation of n 	binary result 	result
//1140867093 	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
//255406592 	00001111 00111001 00110010 00000000 	00001000 00111001 00110010 00111000 	137966136
//4294901775 	11111111 11111111 00000000 00001111 	11111001 11111111 00000000 00111111 	4194238527
//5351 	00000000 00000000 00010100 11100111 	00000100 00000000 00010100 11000111 	67114183
//2369124121 	10001101 00110101 11110111 00011001 	10001011 00110101 11110111 00101001 	2335569705

class Bits_Exchange
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        uint n = 0;
        Console.Write("Input n:");
        while (!uint.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(n));
        }


        uint newN = n;

        uint mask = (2*2*2-1) << 3;
        uint firstBits = n & mask;
        firstBits >>= 3;
        newN = newN & (~mask);

        mask = (2 * 2 * 2 - 1) << 24;
        uint secondBits = n & mask;
        secondBits >>= 24;
        newN = newN & (~mask);

        newN |= firstBits << 24;
        newN |= secondBits << 3;




        Console.WriteLine("{0}\t{1}"
            , "n".PadLeft(10, ' ')
            , "binary representation of n");
        Console.WriteLine("{0}\t{1}"
            , n.ToString().PadLeft(10, ' ')
            , Convert.ToString(n, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " "));
        Console.WriteLine();
        Console.WriteLine("{0}\t{1}"
            , "result".PadLeft(10, ' ')
            , "binary result");
        Console.WriteLine("{0}\t{1}"
            , newN.ToString().PadLeft(10, ' ')
            , Convert.ToString(newN, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ")            );
    }
}

