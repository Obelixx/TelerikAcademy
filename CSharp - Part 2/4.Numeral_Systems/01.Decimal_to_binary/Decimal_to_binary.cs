

//Problem 1. Decimal to binary

//    Write a program to convert decimal numbers to their binary representation.

namespace _01.Decimal_to_binary
{
    using System;

    public class Decimal_to_binary
    {

        public static bool Compare_ints(string op, int x, int y)
        {
            switch (op)
            {
                case "==": return x == y;
                case "!=": return x != y;
                case ">": return x > y;
                case ">=": return x >= y;
                case "<": return x < y;
                case "<=": return x <= y;
                case "NoString": return true;
                case "!NoString": return false;
                default:
                    throw (new System.ArgumentException("Bad operator - use only: \"==\" \"!=\" \">\" \">=\" \"<\" \"<=\" "));
            }
        }
        public static int Checked_int_input(string what, string operator_in_string = "NoString", int number = 0)
        {
            int output;
            Console.Write(what);
            while (!int.TryParse(Console.ReadLine(), out output) || !Compare_ints(operator_in_string, output, number))
            {
                if (operator_in_string != "NoString")
                    Console.WriteLine("Input {0} Number (number{1}{2})!", Convert.GetTypeCode(output), operator_in_string, number);
                else Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(output));
            }
            return (output);
        }

        public static bool[] Dec_to_Bin(int dec)
        {
            bool minus_flag = dec < 0;
            if (minus_flag)
            {
                dec = -dec;
                dec -= 1;
            }
            bool[] result = new bool[32];
            int i = 0;
            while (dec != 0)
            {
                result[i] = (dec % 2) == 1;
                dec /= 2;
                i++;
            }

            if (minus_flag)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    result[j] = !result[j];
                }
            }
            return result;
        }

        static void Main()
        {
            int dec = Checked_int_input("Input decimal value:");
            bool[] result = Dec_to_Bin(dec);
            string print = string.Empty;
            foreach (var item in result)
            {
                print = (item ? '1' : '0') + print;
            }
            Console.WriteLine(print.TrimStart('0'));
        }
    }
}
