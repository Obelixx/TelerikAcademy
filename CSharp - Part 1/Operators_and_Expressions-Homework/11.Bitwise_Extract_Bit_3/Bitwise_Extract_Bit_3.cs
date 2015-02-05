using System;

//Problem 11. Bitwise: Extract Bit #3

//    Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//    The bits are counted from right to left, starting from bit #0.
//    The result of the expression should be either 1 or 0.

//Examples:
//n 	binary representation 	bit #3
//5 	00000000 00000101 	0
//0 	00000000 00000000 	0
//15 	00000000 00001111 	1
//5343 	00010100 11011111 	1
//62241 	11110011 00100001 	0

class Bitwise_Extract_Bit_3
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

        uint bit3;
        uint mask = 1 << 3;
        bit3 = n & mask;
        bit3 >>= 3;
        Console.WriteLine("{0}\t{1}\t{2}", "n".PadLeft(10, ' '), "binary representation          _", "bit #3");
        Console.WriteLine("{0}\t{1}\t{2}", n.ToString().PadLeft(10, ' '), Convert.ToString(n, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " "), bit3);
    }
}

