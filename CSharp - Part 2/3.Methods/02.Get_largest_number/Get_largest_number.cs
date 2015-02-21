using System;

//Problem 2. Get largest number

//    Write a method GetMax() with two parameters that returns the larger of two integers.
//    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

class Get_largest_number
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

    static int GetMax(int a, int b)
    {
        if (a < b) return b;
        else if (a > b) return a;
        else return a;
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        //this:
        int arr_size = 3;// Checked_int_input("Input arrays size(size>0): N=", ">", 0);
        int[] arr_of_ints = new int[arr_size];
        for (int i = 0; i < arr_of_ints.Length; i++)
        {
            arr_of_ints[i] = Checked_int_input("Input element [" + (i + 1) + "] of the array:");
        }
        // or this:
        //int[] arr_of_ints = { 2, 1, 2, 4, 3, 5, 2, 6 };
        //int arr_size = arr_of_ints.Length;
        // end or

        int bestMax = arr_of_ints[0];
        for (int i = 1; i < arr_of_ints.Length; i++)
        {
            int max = GetMax(arr_of_ints[i - 1], arr_of_ints[i]);
            if (bestMax < max) bestMax = max;
        }
        Console.WriteLine("Max: {0}",bestMax);
    }
}

