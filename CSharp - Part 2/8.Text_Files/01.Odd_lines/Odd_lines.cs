//Problem 1. Odd lines

//    Write a program that reads a text file and prints on the console its odd lines.

namespace _01.Odd_lines
{
    using System;
    using System.IO;

    class Odd_lines
    {

        static void PrintOddLines_FromFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string fileLine = string.Empty;
            do
            {
                sr.ReadLine();
                fileLine = sr.ReadLine();
                if (fileLine != null)Console.WriteLine(fileLine);
            } while (fileLine != null);
            sr.Close();
        }

        static void Main()
        {
            string path = @"../../Example.txt";
            PrintOddLines_FromFile(path);
        }
    }
}
