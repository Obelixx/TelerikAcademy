
//Problem 4. Hexadecimal to decimal

//    Write a program to convert hexadecimal numbers to their decimal representation.

namespace _04.Hexadecimal_to_decimal
{
    using System;
    using _03.Decimal_to_hexadecimal;

    class Hexadecimal_to_decimal
    {
        public static int Hex_to_Dec(byte[] hex)
        {
            int from_count_system = 16;
            //int to_count_system = 10;
            bool minus_flag = hex[hex.Length - 1] >= from_count_system / 2;
            if (minus_flag)
            {
                for (int i = 0; i < hex.Length; i++)
                {
                    hex[i] = (byte)(from_count_system - 1 - hex[i]);
                }
            }

            int result = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                if (hex[i] != 0)
                    result += (int)(hex[i]*Math.Pow(from_count_system, i));
            }

            if (minus_flag)
            {
                result++;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int dec = Decimal_to_hexadecimal.Checked_int_input("Input decimal value:");
            byte[] result = Decimal_to_hexadecimal.Dec_to_Hex(dec);
            string print = string.Empty;
            foreach (var item in result)
            {
                if (item >= 0 && item <= 9)
                    print = item.ToString() + print;
                else
                {
                    print = (char)('A' + item - 10) + print;
                }
            }
            Console.WriteLine(print.TrimStart('0'));

            int again_to_dec = Hex_to_Dec(result);
            Console.WriteLine("Again to Dec: " + again_to_dec);

        }
    }
}
