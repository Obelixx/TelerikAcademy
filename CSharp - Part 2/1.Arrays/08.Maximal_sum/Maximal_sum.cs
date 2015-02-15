using System;

//Problem 8. Maximal sum

//    Write a program that finds the sequence of maximal sum in given array.

//Example:
//input 	result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	2, -1, 6, 4

//    Can you do it with only one loop (with single scan through the elements of the array)?

class Maximal_sum
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

    public static int Kadanes_alg(int[] int_array, out int sum_start, out int sum_end) //Using Kadane's algorithm to do the job with only one loop. In return we get the sum, and in two out parameters - start index and end index.
    {
        int current_sum = int.MinValue;
        int current_start = 0;
        int current_end = 0;
        int max_sum = int.MinValue;
        int max_sum_start = 0;
        int max_sum_end = 0;

        for (int i = 0; i < int_array.Length; i++)
        {
            if (current_sum < 0)
            {
                current_sum = int_array[i];
                current_start = i;
                current_end = i;
            }
            else
            {
                current_sum += int_array[i];
                current_end = i;
            }

            if (current_sum > max_sum)
            {
                max_sum = current_sum;
                max_sum_start = current_start;
                max_sum_end = current_end;
            }
        }
        sum_start = max_sum_start;
        sum_end = max_sum_end;
        return max_sum;
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

        //int[] array_of_ints = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        //int arr_size = array_of_ints.Length;

        // end or

        
        int start_index;
        int end_index;
        int sum = Kadanes_alg(array_of_ints,out start_index,out end_index);



        // now printig results
        Console.WriteLine();
        for (int i = 0; i < arr_size ; i++)
        {
            if (i == start_index)
            {
                Console.Write("[");
            }

            if (i != arr_size-1)
            {
                Console.Write(array_of_ints[i]);
                if (i == end_index) Console.Write("]");
                Console.Write(", ");    
            }
            else
            {
                Console.Write(array_of_ints[i]);
                if (i == end_index) Console.Write("]");
            }

        }
        Console.WriteLine();
        Console.WriteLine("Best sum is: "+ sum);
    }
}
