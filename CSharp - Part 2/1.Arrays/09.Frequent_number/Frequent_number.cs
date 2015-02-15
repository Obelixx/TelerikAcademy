using System;

//Problem 9. Frequent number

//    Write a program that finds the most frequent number in an array.

//Example:
//input 	result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	4 (5 times)

class Frequent_number
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

        //int[] array_of_ints = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 2, 2, 1, 1, 2, 2, 2, 4, 9, 3 };
        //int arr_size = array_of_ints.Length;

        // end or


        int most_frequent = array_of_ints[0];
        int most_frequent_count = 0;

        int temp_count = 1;

        for (int i = 0; i < arr_size - 1; i++)
        {
            temp_count = 1;
            for (int j = i+1; j < arr_size; j++)
            {
                if (array_of_ints[i] == array_of_ints[j]) temp_count++;
            }
            if (most_frequent_count < temp_count)
            {
                most_frequent_count = temp_count;
                most_frequent = array_of_ints[i];
            }
        }


        //print results
        for (int i = 0; i < arr_size; i++)
        {
            if (i != arr_size - 1) Console.Write(array_of_ints[i] + ", ");
            else Console.Write(array_of_ints[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Most frequent is: {0} ({1} times)", most_frequent, most_frequent_count);

    }
}
