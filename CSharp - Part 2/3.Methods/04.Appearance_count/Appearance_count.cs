using System;

//Problem 4. Appearance count

//    Write a method that counts how many times given number appears in given array.
//    Write a test program to check if the method is workings correctly.

class Appearance_count
{

    static int Number_in_array(int[] arr, int number)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number) count++;
        }
        return count;
    }

    static void Main()
    {
        int[] arr_of_ints = { 2, 1, 2, 4, 3, 5, 2, 6, 200 };

        int count = Number_in_array(arr_of_ints, 2);
        Console.WriteLine(count);


    }

}
