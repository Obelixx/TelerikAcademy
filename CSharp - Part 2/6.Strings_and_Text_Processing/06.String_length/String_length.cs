//Problem 6. String length

//    Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//    Print the result string into the console.

namespace _06.String_length
{
    using System;

    class String_length
    {
        

        static void Main()
        {
            
            string str = string.Empty;
            do
            {
                Console.WriteLine("Input string of maximum 20 characters: ");
                str = Console.ReadLine();

            } while (str.Length > 20);


            if (str.Length < 20)
            {
                str = str.Insert(str.Length, new string('*', 20 - str.Length));
            }
            Console.WriteLine(str);
        }
    }
}
