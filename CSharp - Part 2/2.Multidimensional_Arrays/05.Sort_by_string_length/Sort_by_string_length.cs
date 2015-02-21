using System;
using System.Linq;

//Problem 5. Sort by string length

//    You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).


class Sort_by_string_length
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

    public static void Print_array(string[] a, int padding = 0)
    {
        //int padding = (a.GetLength(0) * a.GetLength(1)).ToString().Length;

        Console.WriteLine();
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i].ToString().PadLeft(padding));
            if (i != a.Length - 1) Console.Write(", ");

        }
        Console.WriteLine();
    }


    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        //this:

        int n = Checked_int_input("Input arrays size(size>0): N=", ">", 0);
        string[] arr = new string[n];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
                Console.WriteLine("Input [{0}] string", i);
                arr[i] = Console.ReadLine().ToString();
        }

        // or this:

        //var arr = new string[] {"ha", 	"fifi", "ho", 	"hi"};
        //                                    
        //int n = arr.Length;

        //end or


        Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
        Print_array(arr);

    }
}

