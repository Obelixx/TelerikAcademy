using System;

//Problem 2. Compare arrays

//    Write a program that reads two integer arrays from the console and compares them element by element.




class Compare_arrays
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

        int arrs_size = Checked_int_input("Input arrays size(size>0): ", ">", 0);


        int[] arr1 = new int[arrs_size];
        int[] arr2 = new int[arrs_size];

        for (int i = 0; i < arrs_size; i++)
        {
            arr1[i] = Checked_int_input("Input element [" + i + "] of the first array:");
        }

        for (int i = 0; i < arrs_size; i++)
        {
            arr2[i] = Checked_int_input("Input element [" + i + "] of the second array:");
        }

        bool areTheSame = true;
        for (int i = 0; i < arrs_size; i++)
        {
            if (arr1[i]!=arr2[i])
            {
                areTheSame = false;
                break;
            }
        }
        Console.WriteLine("First array is equal to second array is: {0}", areTheSame);

    }


}
