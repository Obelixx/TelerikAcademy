using System;

//Problem 3. English digit

//    Write a method that returns the last digit of given integer as an English word.

//Examples:
//input 	output
//512 	two
//1024 	four
//12309 	nine

class English_digit
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
            Console.WriteLine("Input {0} Number (number{1}{2})!", Convert.GetTypeCode(output), operator_in_string, number);
        }
        return (output);
    }

    static string Last_digit_as_word(int digit)
    {
        digit %= 10;
        switch (digit.ToString())
        {
            case "0":
                return ("zero");

            case "1":
                return ("one");

            case "2":
                return ("two");

            case "3":
                return ("three");

            case "4":
                return ("four");

            case "5":
                return ("five");

            case "6":
                return ("six");

            case "7":
                return ("seven");

            case "8":
                return ("eight");

            case "9":
                return ("nine");

            default:
                return ("not a digit");

        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int a = Checked_int_input("Input int n: N=");
        string word = Last_digit_as_word(a);
        Console.WriteLine(word);

    }
}