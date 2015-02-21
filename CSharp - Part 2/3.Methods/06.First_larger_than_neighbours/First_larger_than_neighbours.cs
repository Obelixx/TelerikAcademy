using System;
using Larger_than_neighbours_namespace; //using project 05. methods - to call this i added a reference into this project, to project 05.

//Problem 6. First larger than neighbours

//    Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//    Use the method from the previous exercise.

class First_larger_than_neighbours
{
    public static int First_larger_than_neighbours_method(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (Larger_than_neighbours.Larger_than_neighbours_method(a, i)) //using project 05. methods - see using section
            {
                return (i);
            }
        }
        return (-1);
    }

    static void Main()
    {
        int[] arr_of_ints =// { 2, 8, 2, 4, 3, 5, 2, 6, 200 };
                           // { 1, 2, 3, 4, 5, 6, 7, 8, 200 };
                            { 1, 2, 3, 4, 5, 6, 7, 8, 8 };

        int result = First_larger_than_neighbours_method(arr_of_ints);

        if (result == -1) Console.WriteLine("No such element.");
        else Console.WriteLine("First element in array that is larger than its neighbours is at position: " + result);

        Console.WriteLine("Check yourself:");
        Larger_than_neighbours.Print_array_with_1_highlight(arr_of_ints, result);

    }
}

