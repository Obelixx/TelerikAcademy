using System;

//Problem 10. Find sum in array

//    Write a program that finds in given array of integers a sequence of given sum S (if present).

//Example:
//array 	S 	result
//4, 3, 1, 4, 2, 5, 8 	11 	4, 2, 5

class Find_sum_in_array
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

        //int arr_size = Checked_int_input("Input arrays size(size>0): ", ">", 0);
        //int[] array_of_ints = new int[arr_size];

        //for (int i = 0; i < arr_size; i++)
        //{
        //    array_of_ints[i] = Checked_int_input("Input element [" + i + "] of the array:");
        //}

        // or this:

        int[] array_of_ints = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 2, 2, 1, 1, 2, 2, 2, 4, 9, 3,100,200,300,2 };
        int arr_size = array_of_ints.Length;

        // end or

        int S =  Checked_int_input("Input S: ");


        int start_index = 0;
        int end_index = 0;

        int temp_sum = 0;
        bool found_flag = false;

        for (int i = 0; i < arr_size; i++)
        {
            temp_sum = array_of_ints[i];
            if (temp_sum == S)
            {
                start_index = i;
                end_index = i;
                found_flag = true;
                break;
            }
            if (i != arr_size)
                for (int j = i + 1; j < arr_size; j++)
                {
                    temp_sum += array_of_ints[j];
                    if (temp_sum == S)
                    {
                        start_index = i;
                        end_index = j;
                        found_flag = true;
                    }
                }
            if (found_flag) break;
        }


        //print results:
        Console.WriteLine();
        for (int i = 0; i < arr_size; i++)
        {
            if (i == start_index && found_flag)
            {
                Console.Write("[");
            }

            if (i != arr_size - 1)
            {
                Console.Write(array_of_ints[i]);
                if (i == end_index && found_flag) Console.Write("]");
                Console.Write(", ");
            }
            else
            {
                Console.Write(array_of_ints[i]);
                if (i == end_index && found_flag) Console.Write("]");
            }

        }
        Console.WriteLine();
        Console.WriteLine("S is: {0} ", S);
        if (!found_flag) Console.WriteLine("Sum not found!");
        


    }
}

