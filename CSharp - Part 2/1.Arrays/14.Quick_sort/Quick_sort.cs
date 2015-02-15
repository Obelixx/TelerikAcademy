using System;

//Problem 14. Quick sort

//    Write a program that sorts an array of integers using the Quick sort algorithm.

class Quick_sort
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

    //  quicksort(A, lo, hi):
    //if lo < hi:
    //  p := partition(A, lo, hi)
    //  quicksort(A, lo, p - 1)
    //  quicksort(A, p + 1, hi)

    public static void quicksort(int[] A, int lo, int hi)
    {
        if (lo < hi)
        {
            int p = partition(A, lo, hi);
            quicksort(A, lo, p - 1);
            quicksort(A, p + 1, hi);
        }
    }

    //   // lo is the index of the leftmost element of the subarray
    //// hi is the index of the rightmost element of the subarray (inclusive)
    //partition(A, lo, hi)
    //   pivotIndex := choosePivot(A, lo, hi)
    //   pivotValue := A[pivotIndex]
    //   // put the chosen pivot at A[hi]
    //   swap A[pivotIndex] and A[hi]
    //   storeIndex := lo
    //   // Compare remaining array elements against pivotValue = A[hi]
    //   for i from lo to hi−1, inclusive
    //       if A[i] < pivotValue
    //           swap A[i] and A[storeIndex]
    //           storeIndex := storeIndex + 1
    //   swap A[storeIndex] and A[hi]  // Move pivot to its final place
    //   return storeIndex

    public static int partition(int[] A, int lo, int hi)
    {
        int pivotIndex = choosePivot(A, lo, hi);
        int pivotValue = A[pivotIndex];

        swap(A[pivotIndex], A[hi], out A[pivotIndex], out A[hi]);
        int storeIndex = lo;
        for (int i = lo; i < hi; i++)
        {
            if (A[i] < pivotValue)
            {
                swap(A[i], A[storeIndex], out A[i], out A[storeIndex]);
                storeIndex += 1;
            }
        }
        swap(A[storeIndex], A[hi], out A[storeIndex], out A[hi]);
        return storeIndex;
    }



    public static int choosePivot(int[] A, int lo, int hi)
    {
        Random rnd = new Random();
        int a = rnd.Next(lo, hi + 1);
        return a;
    }


    public static void swap(int a, int b, out int outA, out int outB)
    {
        outA = b;
        outB = a;
    }

    public static void print_int_array(int[] A, int on_line)
    {

        int max = 0;
        for (int i = 0; i < A.Length; i++)
        {

            if (max < A[i].ToString().Length) max = A[i].ToString().Length;
        }


        for (int i = 0; i < A.Length; i++)
        {
            if (i % on_line == 0) Console.WriteLine();
            Console.Write(A[i].ToString().PadLeft(max));
            if (i != A.Length - 1) Console.Write(", ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;


        //this:

        int arr_size = Checked_int_input("Input arrays size(size>0): ", ">", 0);
        int[] array_of_ints = new int[arr_size];

        for (int i = 0; i < array_of_ints.Length; i++)
        {
            array_of_ints[i] = Checked_int_input("Input element [" + i + "] of the array:");
        }

        // or this:

        //int[] array_of_ints = { 4, 12, 9, 3, 100,10,2,8,2,65,8,9, 20, 30, 2, 8 };
        //int arr_size = array_of_ints.Length;

        // end or

        Console.WriteLine("Befor:");
        print_int_array(array_of_ints,6);

        //Sorting the entire array is accomplished by calling quicksort(A, 1, length(A))
        quicksort(array_of_ints, 0, array_of_ints.Length - 1);
        
        Console.WriteLine("After:");
        print_int_array(array_of_ints,6);




    }
}

