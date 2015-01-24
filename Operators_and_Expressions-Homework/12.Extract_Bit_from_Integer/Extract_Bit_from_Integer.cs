using System;

//Problem 12. Extract Bit from Integer

//    Write an expression that extracts from given integer n the value of given bit at index p.

//Examples:
//n 	binary representation 	p 	bit @ p
//5 	00000000 00000101 	2 	1
//0 	00000000 00000000 	9 	0
//15 	00000000 00001111 	1 	1
//5343 	00010100 11011111 	7 	1
//62241 	11110011 00100001 	11 	0

class Extract_Bit_from_Integer
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
            Console.WriteLine("Input {0} Number! (p>=0 and p<31)", Convert.GetTypeCode(p));
        }



        int bitP;
        int mask = 1 << p;
        bitP = n & mask;
        bitP = bitP >> p;
        Console.WriteLine("{0}\t{1}\t\t\t{2}\t{3}"
            , "n".PadLeft(10, ' ')
            , "binary representation"
            , "p"
            , "bit @ p");
        Console.WriteLine("{0}\t{1}\t{2}\t{3}"
            , n.ToString().PadLeft(10, ' ')
            , Convert.ToString(n, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ")
            , p
            , bitP);

    }
}

