using System;

//Problem 2. Maximal sum

//    Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class Maximal_sum
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
        int padding = (a.Length.ToString().Length);

        Console.WriteLine();
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i].ToString().PadLeft(padding));
            if (i != a.Length - 1) Console.Write(", ");
            if (i + 1 % 10 == 0) Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void Print_array(int[,] a)
    {
        int padding = (a.GetLength(0) * a.GetLength(1)).ToString().Length;

        Console.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j].ToString().PadLeft(padding));
                Console.Write(", ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void Print_results(int[,] a, int si, int sj)
    {
        int padding = (a.GetLength(0) * a.GetLength(1)).ToString().Length;

        Console.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (j == sj && (i == si || i == si + 1 || i == si + 2)) Console.Write("[");
                else Console.Write(" ");
                Console.Write(a[i, j].ToString().PadLeft(padding));
                if (j == sj + 2 && (i == si || i == si + 1 || i == si + 2)) Console.Write("]");
                else Console.Write(" ");
                Console.Write(", ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;


        //this:

        //int n = Checked_int_input("Input arrays size(size>2): N=", ">", 2);
        //int m = Checked_int_input("Input arrays size(size>2): M=", ">", 2);
        //int[,] matrix = new int[n, m];

        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        matrix[i, j] = Checked_int_input("Input element [" + i + "," + j + "] of the array:");
        //    }
        //}

        // or this:

        int[,] matrix = new int[4, 6]
                                            {   
                                                { 1,1,1,1,1,1},
                                                { 1,2,1,1,1,1},
                                                { 1,1,1,1,1,3},
                                                { 1,1,1,1,1,1}
                                            };
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        // end or

        int sum = 0;
        int bestSum = matrix[0, 0] + matrix[0, 1] + matrix[0, 2]
                    + matrix[1, 0] + matrix[1, 1] + matrix[1, 2]
                    + matrix[2, 0] + matrix[2, 1] + matrix[2, 2];
        int bestIndexI = 0;
        int bestIndexJ = 0;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                    + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                    + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                if (bestSum < sum)
                {
                    bestSum = sum;
                    bestIndexI = i;
                    bestIndexJ = j;
                }
                sum = 0;
            }
        }

        //print results
        Console.WriteLine("Input matrix is:");
        Print_array(matrix);
        Console.WriteLine("Best sum is: " + bestSum);
        Print_results(matrix, bestIndexI, bestIndexJ);




    }
}

