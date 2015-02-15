using System;

//Problem 1. Allocate array

//    Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//    Print the obtained array on the console.

class Allocate_array
{
    static void Main()
    {
        int array_size = 20;
        int[] array = new int[array_size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
        }

        foreach (var item in array)
        {
            Console.Write(item+ " ");
        }
        Console.WriteLine();
    }
}
