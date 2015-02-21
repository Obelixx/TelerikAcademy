using System;

//Problem 8. Number as array

//    Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//    Each of the numbers that will be added could have up to 10 000 digits.

class Number_as_array
{
    public static byte[] Add_two_arrays_of_digits(byte[] a, byte[] b)
    {
        byte[] c = new byte[Math.Max(a.Length, b.Length) + 1];
        for (int i = 0; i < Math.Min(a.Length, b.Length); i++) // add to new array
        {
            c[i] = (byte)(a[i] + b[i]);
        }

        if (a.Length > b.Length) // add the rest digits from the longer array
            for (int i = b.Length; i < a.Length; i++)
            {
                c[i] = a[i];
            }
        else
            if (a.Length < b.Length)
            {
                for (int i = a.Length; i < b.Length; i++)
                {
                    c[i] = b[i];
                }
            }

        for (int i = 0; i < Math.Max(a.Length, b.Length); i++) // add carries form number > 9 to the next digit.
        {
            c[i + 1] += (byte)(c[i] / 10);
            c[i] %= 10;
        }
        return c;
    }

    public static Random rndGen = new Random();

    static void Main()
    {
        var a = new byte[3];
                //new byte[] { 3, 5, 7 };
                //new byte[rndGen.Next(10001)];
        var b =  new byte[4];
                //new byte[] { 5, 7, 2, 9 };
                //new byte[rndGen.Next(10001)];

        //fill a and b - this can be skipped for inputig numbers by hand.
        for (int i = 0; i < a.Length; i++) 
        {
            a[i] = (byte)rndGen.Next(10);
        }
        for (int i = 0; i < b.Length; i++) 
        {
            b[i] = (byte)rndGen.Next(10);
        }
        //end fill

        byte[] c = Add_two_arrays_of_digits(a, b); // call method

        //printing results

        Array.Reverse(a); //reverse then because in console thay appear from 0 to length
        Array.Reverse(b);
        Array.Reverse(c);

        Console.WriteLine(string.Join(null, c).ToString().TrimStart('0').PadLeft(c.Length)); //jons arrays in strings and trim leading zeros
        Console.WriteLine();

        Console.WriteLine(string.Join(null, a).ToString().TrimStart('0').PadLeft(c.Length));
        Console.WriteLine("+");
        Console.WriteLine(string.Join(null, b).ToString().TrimStart('0').PadLeft(c.Length));
        Console.WriteLine("=");
        Console.WriteLine(string.Join(null, c).ToString().TrimStart('0').PadLeft(c.Length));

    }
}
