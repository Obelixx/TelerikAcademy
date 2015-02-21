using System;

//Problem 4. Binary search

//    Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

class Binary_search
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

    public static void Print_array(int[] a)
    {
        int padding = (a.Length.ToString().Length);

        Console.WriteLine();
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i].ToString().PadLeft(padding));
            if (i != a.Length - 1) Console.Write(", ");
            if (i + 1 % 10 == 0) Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;


        //this:

        //int arr_size = Checked_int_input("Input arrays size(size>0): N=", ">", 0);
        //int[] arr_of_ints = new int[arr_size];

        //for (int i = 0; i < arr_of_ints.Length; i++)
        //{
        //    arr_of_ints[i] = Checked_int_input("Input element [" + i + "] of the array:");
        //}

        // or this:

        int[] arr_of_ints = { 6, 1, 4, 3, 0, 3, 6, 4 };
        int arr_size = arr_of_ints.Length;


        // end or

        int k = Checked_int_input("input integer K=");

        Console.Write("Your input:");
        Print_array(arr_of_ints);
        Console.WriteLine();

        Array.Sort<int>(arr_of_ints);//sort
        while (Array.BinarySearch(arr_of_ints, k) < 0) k--;//find

        Console.Write("Sorted Array:");
        Print_array(arr_of_ints);
        Console.WriteLine();

        Console.WriteLine("Largest number in the array which is <= K is: {0}", k);//print result


    }
}

