using System;

//Problem 17.* Subset K with sum S

//    Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//    Find in the array a subset of K elements that have sum S or indicate about its absence.

class Subset_K_with_sum_S
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
        Console.WriteLine();
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i]);
            if (i != a.Length - 1) Console.Write(", ");
            if (i + 1 % 10 == 0) Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void Print_results(int[] a, bool[] b)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (b[i]) Console.Write("[" + a[i] + "]");
            else Console.Write(a[i]);

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
        //int[] array_of_ints = new int[arr_size];

        //for (int i = 0; i < array_of_ints.Length; i++)
        //{
        //    array_of_ints[i] = Checked_int_input("Input element [" + i + "] of the array:");
        //}

        // or this:

        int[] array_of_ints = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int arr_size = array_of_ints.Length;


        // end or
        Console.Write("input is:");
        Print_array(array_of_ints);

        int s = Checked_int_input("Input sum: S=");
        int k = Checked_int_input("Input number of elements(k>0): K=", ">", 0);


        int[] bestSum = new int[0];

        int binCounter = (int)(Math.Pow(2d, Convert.ToDouble(array_of_ints.Length))) - 1; // make mask filld with 1, with length of array_size 
        bool[] binArray = new bool[array_of_ints.Length]; // make bool array with same size

        for (int i = 0; i <= binCounter; i++) // count form 1 to mask
        {
            int bitcount = 0;
            for (int j = 0; j < binArray.Length; j++) // put current count as a mask in the bool array
            {
                binArray[j] = Convert.ToBoolean((1 << j) & i);
                if (Convert.ToBoolean((1 << j) & i)) bitcount++; // count "ture"s
            }

            if (bitcount != k) //if we don't have k "true"s in the bool array - start with next i;
            {
                continue;
            }

            int tempSum = 0;
            for (int j = 0; j < binArray.Length; j++) //calcualte sum from elements in array - where in bool array is "true"
            {
                if (binArray[j] == true)
                {
                    tempSum += array_of_ints[j];
                    bitcount++;

                }
            }


            if (tempSum == s) // if the sum is the same - output the result end end the program
            {
                Console.WriteLine("Sum exist:");
                Print_results(array_of_ints, binArray);
                return;
            }
        }
        Console.WriteLine("No such sum in the array!");

    }
}
