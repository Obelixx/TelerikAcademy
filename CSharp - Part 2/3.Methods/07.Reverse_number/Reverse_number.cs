using System;
using System.Linq;

//Problem 7. Reverse number

//    Write a method that reverses the digits of given decimal number.

//Example:
//input 	output
//256 	652
//123.45 	54.321

class Reverse_number
{
    public static bool Compare_doubles(string op, double x, double y)
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
    public static double Checked_double_input(string what, string operator_in_string = "NoString", double number = 0)
    {
        double output;
        Console.Write(what);
        while (!double.TryParse(Console.ReadLine(), out output) || !Compare_doubles(operator_in_string, output, number))
        {
            if (operator_in_string != "NoString" && operator_in_string != "!NoString")
                Console.WriteLine("Input {0} Number (number{1}{2})!", Convert.GetTypeCode(output), operator_in_string, number);
            else
                Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(output));
        }
        return (output);
    }

    public static double Reverse_decimal_number(double input)
    {
        bool minus_flag = false;
        if (input < 0)
        {
            minus_flag = true;
            input = -input;
        }

        string s = input.ToString();
        char[] c = s.ToCharArray();
        Array.Reverse(c);
        s = string.Join(null, c);

        double output = double.Parse(s);
        if (minus_flag) output = -output;

        return (output);
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double input = Checked_double_input("Input number:");

        double output = Reverse_decimal_number(input);

        Console.WriteLine(output);
    }
}
