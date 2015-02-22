
//Problem 3. Decimal to hexadecimal

//    Write a program to convert decimal numbers to their hexadecimal representation.


namespace _03.Decimal_to_hexadecimal
{
    using System;

    public class Decimal_to_hexadecimal
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

        public static byte[] Dec_to_Hex(int dec)
        {
            int to_count_system = 16;
            bool minus_flag = dec < 0;
            if (minus_flag)
            {
                dec = -dec;
                dec -= 1;
            }
            byte[] result = new byte[to_count_system/2];
            int i = 0;
            while (dec != 0)
            {
                result[i] = (byte)(dec % 16);
                dec /= 16;
                i++;
            }

            if (minus_flag)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    result[j] = (byte)(to_count_system - 1 - result[j]);
                }
            }
            return result;
        }


        static void Main()
        {
            int dec = Checked_int_input("Input decimal value:");
            byte[] result = Dec_to_Hex(dec);
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
        }
    }
}
