using System;

//Problem 5. Larger than neighbours

//    Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
namespace Larger_than_neighbours_namespace
{
    public class Larger_than_neighbours
    {
        public static bool Larger_than_neighbours_method(int[] arr, int pos)
        {
            if (pos >= arr.Length || pos < 0)
            {
                Console.WriteLine("No such position in array.");
                return false;
            }

            if (pos == 0)
            {
                if (arr[pos] > arr[pos + 1])
                    return true;
            }
            else
                if (pos == arr.Length - 1)
                {
                    if (arr[pos] > arr[pos - 1])
                        return true;
                }
                else
                    if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1])
                        return true;

            return false;
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
            int[] arr_of_ints = { 2, 8, 2, 4, 3, 5, 2, 6, 200 };
            int position = 1; //try with otrer poitions too! For example: -3,0,1,8,10

            bool isIt = Larger_than_neighbours_method(arr_of_ints, position);

            Console.WriteLine(" - Is it larger then its neighbours?");
            if (isIt) Console.WriteLine(" - Yes!");
            else Console.WriteLine(" - No!");

            Console.WriteLine();
            Console.WriteLine(" - If you dont believe, look alone into your Array:");
            Print_array_with_1_highlight(arr_of_ints, position);


        }
    }
}