using System;

//Problem 6. Maximal K sum

//    Write a program that reads two integer numbers N and K and an array of N elements from the console.
//    Find in the array those K elements that have maximal sum.

class Maximal_K_sum
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

        int n = Checked_int_input("(N>1) N = ", ">", 1);
        int k = Checked_int_input("(0<K<N) K = ", ">", 0);

        int[] arr_int = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr_int[i] = Checked_int_input("Input element [" + i + "] of the array: ");
        }

        if (k > n)
        {
            Console.WriteLine("K>N");
            return;
        }

        long sum = 0;
        if (k == n) // if k=n then best sum is sum of all elements
        {
            foreach (var item in arr_int)
            {
                sum += item;
            }
            Console.WriteLine("Max SUM of K elements is: " + sum);
            return;
        }

        int[] arr_buffer_int = new int[k];
        for (int i = 0; i < k; i++) // input first k elements in buffer and take their sum
        {
            arr_buffer_int[i] = arr_int[i];
            sum += arr_int[i];
        }


        long best_sum = sum; //assume best sum is the first one
        for (int i = k; i < arr_int.Length; i++)
        {
            // take one new constant in the buffer
            for (int j = 1; j < k; j++) // shift everything to left
            {
                arr_buffer_int[j - 1] = arr_buffer_int[j];
            }
            arr_buffer_int[k - 1] = arr_int[i]; //take new integer on last position

            sum = 0;
            for (int j = 0; j < k; j++) // calculate sum
            {
                sum += arr_buffer_int[j];
            }

            if (best_sum < sum) best_sum = sum; //check for best sum
        }

        Console.WriteLine("Max SUM of K elements is: " + best_sum);

    }
}
