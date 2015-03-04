//Problem 3. Line numbers

//    Write a program that reads a text file and inserts line numbers in front of each of its lines.
//    The result should be written to another text file.

namespace _03.Line_numbers
{
    using System;
    using System.IO;

    class Line_numbers
    {
        static void Insert_LineNumbers(string path_from, string path_to)
        {
            StreamReader sr = new StreamReader(path_from);
            string fileLine = string.Empty;

            StreamWriter sw = new StreamWriter(path_to);
            ulong ln = 0;
            do
            {
                fileLine = sr.ReadLine();
                if (fileLine != null)
                {
                    sw.Write(ln + "\t");
                    sw.WriteLine(fileLine);
                }
                ln++;
            } while (fileLine != null);
            
            sr.Close();
            sw.Close();
            Console.WriteLine("File written!");
        }



        static void Main()
        {
            string path_from = @"..\..\TextFile_from.txt";
            string path_to = @"..\..\TextFile_to.txt";

            Insert_LineNumbers(path_from, path_to);


        }
    }
}
