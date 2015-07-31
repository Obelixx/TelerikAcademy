using System;
using System.Collections.Generic;
using System.Text;

public class StaticMethods
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr.Length == 0)
        {
            throw new ArgumentException("arr is empty");
        }

        if (startIndex < 0 || startIndex >= arr.Length)
        {
            throw new ArgumentException("bad startIndex");
        }

        if (count < 0)
        {
            throw new ArgumentException("count is <=0");
        }

        if (startIndex + count > arr.Length)
        {
            throw new ArgumentException("startIndex + count is >= arr.Length");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (str == null || str == string.Empty)
        {
            throw new ArgumentException("str is null or empty");
        }

        if (count < 0 || count > str.Length)
        {
            throw new ArgumentException("Invalid count!");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }
}
