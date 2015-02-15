using System;

//Problem 7. Selection sort

//    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

namespace Selection_sort_namespace
{
    class Selection_sort
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


        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            //this:

            int arr_size = Checked_int_input("(N>1) N = ", ">", 1);
            int[] array_of_ints = new int[arr_size];

            for (int i = 0; i < arr_size; i++)
            {
                array_of_ints[i] = Checked_int_input("Input element [" + i + "] of the array: ");
            }

            // or this:

            //int[] array_of_ints = { 3, 2, 3, 4, 2, 2, 4 };
            //int arr_size = array_of_ints.Length;

            // end or

            SelectionSort(array_of_ints);

            //print them all
            Console.WriteLine();
            Console.Write("Sorted integers: ");
            foreach (var item in array_of_ints)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


        }
    }
}