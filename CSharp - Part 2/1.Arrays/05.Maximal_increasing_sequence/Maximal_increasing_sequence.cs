using System;

//Problem 5. Maximal increasing sequence

//    Write a program that finds the maximal increasing sequence in an array.

//Example:
//input 	result
//3, 2, 3, 4, 2, 2, 4 	2, 3, 4

class Maximal_increasing_sequence
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


    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;


        //this:

        int arr_size = Checked_int_input("Input arrays size(size>0): ", ">", 0);
        int[] array_of_ints = new int[arr_size];

        for (int i = 0; i < arr_size; i++)
        {
            array_of_ints[i] = Checked_int_input("Input element [" + i + "] of the array:");
        }

        // or this:

        //int[] array_of_ints = { 3, 2, 3, 4, 2, 2, 4 };
        //int arr_size = array_of_ints.Length;

        // end or

        int last_int = array_of_ints[0];
        int count = 1;
        int best_count = 1;
        for (int i = 1; i < arr_size; i++)
        {
            if (array_of_ints[i] > last_int)
            {
                count++;
                last_int = array_of_ints[i];
            }
            else
            {
                count = 1;
                last_int = array_of_ints[i];
            }
            if (best_count < count) best_count = count;
        }
        foreach (var item in array_of_ints)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Maximal increasing sequence: " + best_count);
    }
}
