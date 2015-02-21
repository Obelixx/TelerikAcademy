using System;

//Problem 10. N Factorial

//    Write a program to calculate n! for each n in the range [1..100].

//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

class N_Factorial
{
    public static int[] Multiplie_array(int[] a, int number) // number will be in the range [1..100]
    {
        int[] b = new int[a.Length + 2];
        for (int i = 0; i < a.Length; i++)
        {
            b[i] = a[i] * number;
        }

        int times = 2;// two times, because maximum carry is 9*100 = 900
        for (int i = 0; i < b.Length - 1; i++) // add carries form number > 9 to the next digit.
        {
            b[i + 1] += b[i] / 10;
            b[i] %= 10;
            if (i == b.Length - 1 && times > 1)
            {
                i = -1;
                times--;
            }
        }
        while (b[b.Length - 1] == 0)//remove leading zeros from array
        {
            int[] c = new int[b.Length - 1];
            Array.Copy(b, c, c.Length);
            b = c;
        }        

        return b;
    }

    static void Main()
    {
        int[] fakruriel = new int[1] { 1 };
        int form_1_to = 100; //if want to change use number >= 1 or it will not return anything

        for (int n = 1; n <= form_1_to; n++)
        {
            fakruriel = Multiplie_array(fakruriel, n);
            Array.Reverse(fakruriel);
            Console.WriteLine("{0}! = {1}", n, string.Join(null, fakruriel));
            Array.Reverse(fakruriel);
        }
    }
}
