

//Problem 2. Binary to decimal

//    Write a program to convert binary numbers to their decimal representation.

namespace _02.Binary_to_decimal
{
    using System;
    using _01.Decimal_to_binary;

    class Binary_to_decimal
    {
        
        public static int Bin_to_Dec(bool[] bin)
        {
            bool minus_flag = bin[bin.Length-1] == true;
            if (minus_flag)
            {
                for (int i = 0; i < bin.Length; i++)
                {
                    bin[i] = !bin[i];
                }
            }

            int result = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i])
                    result += (int)Math.Pow(2d, i);
            }

            if(minus_flag)
            {
                result++;
            }
            return result;
        }

        static void Main()
        {
            int dec = Decimal_to_binary.Checked_int_input("Input decimal value:");
            bool[] result = Decimal_to_binary.Dec_to_Bin(dec);
            string print = string.Empty;
            foreach (var item in result)
            {
                print = (item ? '1' : '0') + print;
            }
            Console.WriteLine(print.TrimStart('0'));

            int decAgain = Bin_to_Dec(result);

            Console.WriteLine("Again to Dec: "+ decAgain);
        }
    }
}
