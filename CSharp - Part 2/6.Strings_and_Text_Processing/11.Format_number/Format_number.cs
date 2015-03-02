
//Problem 11. Format number

//    Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//    Format the output aligned right in 15 symbols.

namespace _11.Format_number
{
    using System;
    class Format_number
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15}", input.ToString("d"));
            Console.WriteLine("{0,15}", input.ToString("x"));
            Console.WriteLine("{0,15}", ((double)input/100).ToString("p"));
            Console.WriteLine("{0,15}", input.ToString("g"));
        }
    }
}
