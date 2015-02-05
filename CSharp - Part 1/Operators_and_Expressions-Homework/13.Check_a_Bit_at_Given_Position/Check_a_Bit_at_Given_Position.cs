using System;

//Problem 13. Check a Bit at Given Position

//    Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

//Examples:
//n 	binary representation of n 	p 	bit @ p == 1
//5 	00000000 00000101 	2 	true
//0 	00000000 00000000 	9 	false
//15 	00000000 00001111 	1 	true
//5343 	00010100 11011111 	7 	true
//62241 	11110011 00100001 	11 	false

class Check_a_Bit_at_Given_Position //Same as "12.Extract Bit from Integer". Only bool value is added.
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



        int bitP;
        int mask = 1 << p;
        bitP = n & mask;
        bitP = (bitP >> p); 
        bool boolBitP = bitP == 1; // Changed here!
        Console.WriteLine("{0}\t{1}\t\t\t{2}\t{3}"
            , "n".PadLeft(10, ' ')
            , "binary representation"
            , "p"
            , "bit @ p == 1"); // Changed here!
        Console.WriteLine("{0}\t{1}\t{2}\t{3}"
            , n.ToString().PadLeft(10, ' ')
            , Convert.ToString(n, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ")
            , p
            , boolBitP); // Changed here!
    }
}

