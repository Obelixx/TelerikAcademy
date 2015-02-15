using System;

//Problem 18.* Remove elements from array

//    Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
//    Print the remaining sorted array.

//Example:
//input 	result
//6, 1, 4, 3, 0, 3, 6, 4, 5 	1, 3, 3, 4, 5

class Remove_elements_from_array
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

    public static bool Check_is_sorted(int[] a)
    {
        int tempElement = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < tempElement)
            {
                return false;
            }
            tempElement = a[i];
        }
        return true;
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

        int[] array_of_ints = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        int arr_size = array_of_ints.Length;


        // end or

        Console.Write("input is:");
        Print_array(array_of_ints);

        int bestCount = 0;
        bool[] bestBinArr = new bool[0];

        int binCounter = (int)(Math.Pow(2d, Convert.ToDouble(array_of_ints.Length))) - 1; // make mask filld with 1, with length of array_size 


        for (int i = 0; i <= binCounter; i++) // count form 1 to mask
        {
            bool[] binArray = new bool[array_of_ints.Length]; // make bool array with same size

            int bitcount = 0;
            for (int j = 0; j < binArray.Length; j++) // put current count as a mask in the bool array
            {
                binArray[j] = Convert.ToBoolean((1 << j) & i);
                if (Convert.ToBoolean((1 << j) & i)) bitcount++; // count "ture"s
            }

            int[] tempArray = new int[bitcount];
            int tempArrayCounter = 0;
            for (int j = 0; j < binArray.Length; j++) //construct temp array holding true values
            {
                if (binArray[j])
                {
                    tempArray[tempArrayCounter] = array_of_ints[j];
                    tempArrayCounter++;
                }
            }

            //check is sorted
            if (tempArrayCounter != 0)
            {
                if (Check_is_sorted(tempArray))
                {
                    //update best count & best arr
                    if (bestCount < tempArray.Length)
                    {
                        bestCount = tempArray.Length;
                        bestBinArr = binArray;
                    }
                }
            }
        }



        //print results
        Console.WriteLine();
        Console.WriteLine("Best Count: " + bestCount);
        Print_results(array_of_ints, bestBinArr);

        //remove elements - and print array again

        int[] bestArray = new int[bestCount];
        int bestArrayCount = 0;
        for (int i = 0; i < array_of_ints.Length; i++)
        {
            if (bestBinArr[i])
            {
                bestArray[bestArrayCount] = array_of_ints[i];
                bestArrayCount++;
            }
        }
        Console.WriteLine();
        Console.Write("Best array:");
        Print_array(bestArray);

    }
}

