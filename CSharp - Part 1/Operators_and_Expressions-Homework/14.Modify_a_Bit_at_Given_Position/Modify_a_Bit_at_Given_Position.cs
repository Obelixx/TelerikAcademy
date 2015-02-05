using System;

//Problem 14. Modify a Bit at Given Position

//    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//    Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

//Examples:
//n 	binary representation of n 	p 	v 	binary result 	result
//5 	00000000 00000101 	2 	0 	00000000 00000001 	1
//0 	00000000 00000000 	9 	1 	00000010 00000000 	512
//15 	00000000 00001111 	1 	1 	00000000 00001111 	15
//5343 	00010100 11011111 	7 	0 	00010100 01011111 	5215
//62241 	11110011 00100001 	11 	0 	11110011 00100001 	62241

class Modify_a_Bit_at_Given_Position
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n:");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(n));
        }

        int p = 0;
        Console.Write("Input p:");
        while (!int.TryParse(Console.ReadLine(), out p) || p < 0 || p > 31)
        {
            Console.WriteLine("Input {0} Number! (p>=0 and p<=31)", Convert.GetTypeCode(p));
        }

        int v = 0;
        Console.Write("Input v:");
        while (!int.TryParse(Console.ReadLine(), out v) || v < 0 || v > 1)
        {
            Console.WriteLine("Input {0} Number! (v=0 or v=1)", Convert.GetTypeCode(v));
        }


        int mask = 1 << p;
        int bitP = n & mask;
        bitP >>= p;
        int newN = n;
        if (bitP != v)
        {
            mask = 1 << p;
            newN = n ^ mask;
        }


        Console.WriteLine("{0}\t{1}\t\t\t\t{2}"
            , "n".PadLeft(10, ' ')
            , "binary representation"
            , "p");
        Console.WriteLine("{0}\t{1}\t\t{2}"
            , n.ToString().PadLeft(10, ' ')
            , Convert.ToString(n, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ")
            , p);
        Console.WriteLine();
        Console.WriteLine("{0}\t{1}\t\t\t\t\t{2}"
            , "v".PadLeft(10, ' ')
            , "binary result"
            , "result");
        Console.WriteLine("{0}\t{1}\t\t{2}"
            , v.ToString().PadLeft(10, ' ')
            , Convert.ToString(newN, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ")
            , newN);
    }
}

