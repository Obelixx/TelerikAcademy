using System;

//Problem 15. Prime numbers

//    Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

class Prime_numbers
{

    //    Input: an integer n > 1

    //Let A be an array of Boolean values, indexed by integers 2 to n,
    //initially all set to true.

    // for i = 2, 3, 4, ..., not exceeding √n:
    //  if A[i] is true:
    //    for j = i2, i2+i, i2+2i, i2+3i, ..., not exceeding n :
    //      A[j] := false

    //Output: all i such that A[i] is true.

    static bool[] Prime_by_Sieve_of_Eratosthenes(ulong n)
    {
        if (n <= 1)
        {
            throw new ArithmeticException("N must be > 1");
        }
        bool[] A = new bool[n]; //default is False - so our result will be: all i such that A[i] is false.
        for (ulong i = 2; i < Math.Sqrt(n); i++)
            if (A[i] == false)
            {
                for (ulong j = i * 2; j < n; j += i)
                {
                    A[j] = true;
                }
            }
        return (A);
    }

    static void Print_results(bool[] A)
    {
        int count = 0;
        for (int i = 2; i < A.Length; i++)
        {
            if (!A[i])
            {
                count++;
            }
        }


        //this is printig, but it is too slow:

        //int subCount = 0;
        //for (int i = 1; i < A.Length; i++)
        //{
        //    if (!A[i])
        //    {
        //        Console.Write(i);
        //        if (subCount!= count) Console.Write(", ");
        //        subCount++;
        //        if (subCount % 10 == 0) Console.WriteLine();
        //    }
        //}

        // so i'll print just thair count:

        Console.WriteLine("Prime numbers in this interval: {0}",count);

        // to check is it correct use this two lïnks:
        // http://www.wolframalpha.com/input/?i=664580th+prime 
        // http://www.wolframalpha.com/input/?i=664579th+prime
    }


    static void Main()
    {
        bool[] array = Prime_by_Sieve_of_Eratosthenes(10000000uL);
        Print_results(array); // I print thair count. // Look in the function why.
        Console.WriteLine();
    }
}

