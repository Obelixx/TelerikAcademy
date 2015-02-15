using System;

//problem 3. Compare char arrays

//    Write a program that compares two char arrays lexicographically (letter by letter).


class Compare_char_arrays
{
    static void Main()
    {
        string char_array1 = Console.ReadLine();
        string char_array2 = Console.ReadLine();

        bool areTheSame = true;

        for (int i = 0; i < Math.Min(char_array1.Length,char_array2.Length); i++)
        {
            if (char_array1[i] != char_array2[i])
            {
                areTheSame = false;
                break;
            }
        }

        if (char_array1.Length != char_array2.Length && areTheSame) Console.WriteLine("Length of the arrays are different.");
        if (areTheSame) Console.WriteLine("The shorter array is the begginnig of the longer one.");
        else Console.WriteLine("This arrays are different.");
    }
}

