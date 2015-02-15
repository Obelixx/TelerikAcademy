using System;
using System.Collections.Generic;
using System.Linq;

//Problem 19.* Permutations of set

//    Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

//Example:
//N 	result
//3 	{1, 2, 3}
//{1, 3, 2}
//{2, 1, 3}
//{2, 3, 1}
//{3, 1, 2}
//{3, 2, 1}

class Permutations_of_set
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


    static IEnumerable<IEnumerable<T>> // found on internet
    GetPermutations<T>(IEnumerable<T> list, int length)
    {
        if (length == 1) return list.Select(t => new T[] { t });

        return GetPermutations(list, length - 1)
            .SelectMany(t => list.Where(e => !t.Contains(e)),
                (t1, t2) => t1.Concat(new T[] { t2 }));
    }
    


    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = Checked_int_input("Input n(n>0): N=", ">", 0);

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = i + 1;
        }

        IEnumerable<IEnumerable<int>> result = GetPermutations(Enumerable.Range(1, n), n); // my implementation

        foreach (var items in result)
        {
            Console.Write("{" + string.Join(", ", items) + "}");
            Console.WriteLine();
        }

    }
}
