
//Problem 2. Reverse string

//    Write a program that reads a string, reverses it and prints the result at the console.

//Example:
//input 	output
//sample 	elpmas

namespace _02.Reverse_string
{
    using System;
    class Reverse_string
    {
        static void Main()
        {
            Console.Write("Input string here: ");
            string str = Console.ReadLine();

            if (str != string.Empty && str != null)
            {
                char[] chArr = str.ToCharArray();
                Array.Reverse(chArr);
                Console.WriteLine("Reversed string here: {0}", string.Join(null, chArr));
            }
            else
            {
                Console.WriteLine("Null or empty string, cannot be reversed!");
            }

            //using string[]
            Console.Write("Anather solution: ");

            if (str != string.Empty && str != null)
            {
                string revString = string.Empty;
                for (int i = 0; i < str.Length; i++)
                {
                    revString += str[str.Length - 1 - i];
                }
                Console.WriteLine(revString);
            }
            else
            {
                Console.WriteLine("Null or empty string, cannot be reversed!");
            }

        }
    }
}
