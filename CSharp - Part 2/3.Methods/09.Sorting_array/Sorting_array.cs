using System;

//Problem 9. Sorting array

//    Write a method that return the maximal element in a portion of array of integers starting at given index.
//    Using it write another method that sorts an array in ascending / descending order.

class Sorting_array
{
    public static int Next_max_element(int[] a, int start_position) // returns position of next max element
    {
        int max_position = start_position;
        for (int i = start_position; i < a.Length; i++)
        {
            if (a[max_position] < a[i])
                max_position = i;
        }
        return (max_position);
    }

    public static void Sort(int[] a, bool order = true)
    // call without order or with "true" for ascending, or with "false" for descending order
    {

        for (int i = 0; i < a.Length; i++)
        {
            int next = Next_max_element(a, i);
            Exchange(a[i], a[next], out a[i], out a[next]);
        }

        if (order)
        {
            Array.Reverse(a);
        }

    }

    public static void Exchange(int a, int b, out int outA, out int outB)
    //exchange tow values
    {
        outA = b;
        outB = a;
    }

    public static void Print_array_with_1_highlight(int[] array_of_inst, int? position_to_highlight = null)
    {
        for (int i = 0; i < array_of_inst.Length; i++)
        {
            if (position_to_highlight != null && position_to_highlight >= 0 && position_to_highlight < array_of_inst.Length)
                if (i == position_to_highlight) Console.Write("[" + array_of_inst[i] + "]");
                else Console.Write(array_of_inst[i]);
            else Console.Write(array_of_inst[i]);
            if (i != array_of_inst.Length - 1) Console.Write(", ");
            if (i + 1 % 10 == 0) Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] arr_of_ints = { 2, 8, 2, 4, 3, 200, 5, 2, 6, 9, -2, 15 };

        Console.WriteLine("Your array is:");
        Print_array_with_1_highlight(arr_of_ints);

        Sort(arr_of_ints); // ,true);
        Console.WriteLine("Sorted ascending:");
        Print_array_with_1_highlight(arr_of_ints);

        Sort(arr_of_ints, false);
        Console.WriteLine("Sorted descending:");
        Print_array_with_1_highlight(arr_of_ints);


    }
}

