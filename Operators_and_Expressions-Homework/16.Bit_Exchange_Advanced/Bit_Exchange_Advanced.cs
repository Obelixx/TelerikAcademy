using System;

//Problem 16.** Bit Exchange (Advanced)

//    Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//    The first and the second sequence of bits may not overlap.

//Examples:
//n 	p 	q 	k 	binary representation of n 	binary result 	result
//1140867093 	3 	24 	3 	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
//4294901775 	24 	3 	3 	11111111 11111111 00000000 00001111 	11111001 11111111 00000000 00111111 	4194238527
//2369124121 	2 	22 	10 	10001101 00110101 11110111 00011001 	01110001 10110101 11111000 11010001 	1907751121
//987654321 	2 	8 	11 	00111010 11011110 01101000 10110001 	- 	overlapping
//123456789 	26 	0 	7 	00000111 01011011 11001101 00010101 	- 	out of range
//33333333333 	-1 	0 	33 	00000111 11000010 11010010 01001101 01010101 	- 	out of range

class Bit_Exchange_Advanced
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        long n = 0;
        Console.Write("Input n:");
        while (!long.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(n));
        }

        int p = 0;
        Console.Write("Input p:");
        while (!int.TryParse(Console.ReadLine(), out p))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(p));
        }

        int q = 0;
        Console.Write("Input q:");
        while (!int.TryParse(Console.ReadLine(), out q))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(q));
        }

        uint k = 0;
        Console.Write("Input k:");
        while (!uint.TryParse(Console.ReadLine(), out k))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(k));
        }


        long? newN = n;
        string result = String.Empty;

        if (p < 0 || p > 31 ||
            q < 0 || q > 31 ||
            p + k - 1 < 0 || p + k - 1 > 31 ||
            q + k - 1 < 0 || q + k - 1 > 31)
        {
            result = "out of range";
            newN = null;
            goto exit;
        }

        if ((Math.Min(p, q) + k - 1) >= Math.Max(p, q))
        {
            result = "overlapping";
            newN = null;
            goto exit;
        }



        uint kInMask = Convert.ToUInt32((Math.Pow(2, k) - 1));

        long mask = kInMask << p;
        long firstBits = n & mask;
        firstBits >>= p;
        newN = newN & (~mask);

        mask = kInMask << q;
        long secondBits = n & mask;
        secondBits >>= q;
        newN = newN & (~mask);

        newN |= firstBits << q;
        newN |= secondBits << p;

        result = Convert.ToString(newN);

    exit:

        Console.WriteLine("{0}\t{1}\t{2}\t{3}"
            , "n".PadLeft(10, ' ')
            , "p"
            , "q"
            , "k");
        Console.WriteLine("{0}\t{1}\t{2}\t{3}"
            , n.ToString().PadLeft(10, ' ')
            , p
            , q
            , k);

        Console.WriteLine();
        Console.WriteLine("{0}"
            , "binary representation of n".PadLeft(10, ' '));
        Console.WriteLine("{0}"
            , Convert.ToString(n, 2).PadLeft(32, '0').Insert(8, " ").Insert(17, " ").Insert(26, " "));

        if (newN != null)
        {
            Console.WriteLine();
            Console.WriteLine("{0}"
                , "binary result");
            Console.WriteLine("{0}"
                , Convert.ToString(Convert.ToUInt32(result), 2).PadLeft(32, '0').Insert(8, " ").Insert(17, " ").Insert(26, " "));
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("{0}"
                , "binary result");
            Console.WriteLine("{0}"
                , "-");
        }

        Console.WriteLine();
        Console.WriteLine("{0}"
            , "result");
        Console.WriteLine("{0}"
            , result);


    }
}

