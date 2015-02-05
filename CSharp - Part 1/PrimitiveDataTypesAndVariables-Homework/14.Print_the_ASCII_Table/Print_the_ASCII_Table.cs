using System;

//Problem 14.* Print the ASCII Table

//    Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

//Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

//Note: You may need to use for-loops (learn in Internet how).

class Print_the_ASCII_Table
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("CC means Control Character\n");

        Console.WriteLine("ASCII Tabble (16 in row):");
        for (int i = 0; i <= 255; i++)
        {
            if (!Char.IsControl(Convert.ToChar(i)))
            {
                Console.Write("[{0}] ", Convert.ToChar(i));
            }
            else Console.Write("[CC]");
            if ((i+1)% 16 == 0) Console.Write("\n");
        }
    }
}

