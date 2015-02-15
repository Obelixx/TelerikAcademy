using System;

//Problem 12. Index of letters

//    Write a program that creates an array containing all letters from the alphabet (A-Z).
//    Read a word from the console and print the index of each of its letters in the array.

class Index_of_letters
{

    public static int BinarySearch(int[] array_of_ints, int element)
    {
        int index = array_of_ints.Length / 2;
        int begin = 0;
        int end = array_of_ints.Length - 1;
        int position = -1;

        while (index != 0 || index != array_of_ints.Length - 1)
        {
            if (array_of_ints[index] == element)
            {
                position = index;
                break;
            }
            if (element < array_of_ints[index])
            {

                end -= (end - begin) / 2;
                if ((end - begin) / 2 == 0)
                    index--;
                else
                    index -= (end - begin) / 2;
            }
            else
            {
                begin += (end - begin) / 2;
                index += (end - begin) / 2;
            }
            if ((end - begin) / 2 == 0 && begin != 0) break;
        }
        return (position);
    }

    static void Main()
    {
        int[] alphabet = new int[(int)'Z' - (int)'A' + 1];
        for (int i = 0; i <= (int)'Z' - (int)'A'; i++)
        {
            alphabet[i] = i + (int)'A';
        }

        string word = string.Empty;
        while (word == string.Empty || word == null)
        {
            Console.Write("Input word:");
            word = Console.ReadLine();
            Console.WriteLine();
        }
        word = word.ToUpper(); //If word is with small letters change them..

        for (int i = 0; i < word.Length; i++) //Check for anather simbol in our string. If found - trim it with the rest of the string.
        {
            if (!(word[i] >= 'A' && word[i] <= 'Z'))
            {
                word = word.Substring(0, i);
            }
        }

        if (word.Length == 0) //On empty string - exit. (after trim it may become empty again..)
        {
            Console.WriteLine("Bad word!");
            return;
        }
        //now we have now string to compare

        //do the work

        int index;
        for (int i = 0; i < word.Length; i++)
        {
            index = BinarySearch(alphabet, (int)word[i]);
            Console.Write(word[i] + "[" + index + "]");
            if (i != word.Length - 1) Console.Write(",");
        }
        Console.WriteLine();


    }
}

