using System;


//Problem 11. Binary search

//    Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.


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

    public static void SelectionSort(int[] not_sorted_array_of_ints) // sorts the given array
    {
        int smallest;
        for (int position = 0; position < not_sorted_array_of_ints.Length - 1; position++)
        {
            //Find the smallest element, 
            smallest = position;//assume smallest is first element
            for (int i = position + 1; i < not_sorted_array_of_ints.Length; i++)//check rest of them
            {
                if (not_sorted_array_of_ints[smallest] > not_sorted_array_of_ints[i]) smallest = i;
            }
            if (smallest != position) //if there is smallest in the rest - exchange
            {

                not_sorted_array_of_ints[smallest] = not_sorted_array_of_ints[smallest] + not_sorted_array_of_ints[position];
                not_sorted_array_of_ints[position] = not_sorted_array_of_ints[smallest] - not_sorted_array_of_ints[position];
                not_sorted_array_of_ints[smallest] = not_sorted_array_of_ints[smallest] - not_sorted_array_of_ints[position];
            }
        }
        //return ((int[])not_sorted_array_of_ints.Clone());
    }

    public static int BinarySearch(int[] array_of_ints,int element)
    {
        int index = array_of_ints.Length / 2;
        int begin = 0;
        int end = array_of_ints.Length - 1;
        int position = -1;

        while (index != 0 || index != array_of_ints.Length - 1)
        {
            if (array_of_ints[index] == element)
            {
                position = index;
                break;
            }
            if (element < array_of_ints[index])
            {

                end -= (end - begin) / 2;
                if ((end - begin) / 2 == 0)
                    index--;
                else
                    index -= (end - begin) / 2;
            }
            else
            {
                begin += (end - begin) / 2;
                index += (end - begin) / 2;
            }
            if ((end - begin) / 2 == 0 && begin != 0) break;
        }
        return (position);
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

        //int[] array_of_ints = { 4, 1, 1, 4, -3, 2,-2 ,3, 4, 7, 6, 1, 2, 2, 2, 1, 1, 2, 2, 2, 4, 9, 3, 10, 20, 30, 2 };
        //int arr_size = array_of_ints.Length;

        // end or

        int element = Checked_int_input("Give me element to search: ");

        SelectionSort(array_of_ints);

        int position = BinarySearch(array_of_ints, element);

        //print results
        int pad_i = arr_size.ToString().Length;
        int pad_num = array_of_ints[arr_size - 1].ToString().Length;


        Console.WriteLine("\nSorted array is here(in [] is the index): ");
        for (int index = 0; index < arr_size; index++)
        {
            if (index != arr_size - 1) Console.Write("[" + index.ToString().PadLeft(pad_i) + "]" + array_of_ints[index].ToString().PadLeft(pad_num) + ", ");
            else Console.Write("[" + index.ToString().PadLeft(pad_i) + "]" + array_of_ints[index].ToString().PadLeft(pad_num));
            if ((index + 1) % 5 == 0) Console.WriteLine();
        }
        Console.WriteLine("\n");

        if (position >= 0)
            Console.WriteLine("Element {0} is @ position {1}", element, position);
        else
            Console.WriteLine("Element {0} not found!", element);
        Console.WriteLine();

    }
}
