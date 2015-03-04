//Problem 2. Concatenate text files

//    Write a program that concatenates two text files into another text file.

namespace _02.Concatenate_text_files
{
    using System;
    using System.IO;

    class Concatenate_text_files
    {
        static void Concat_2TextFiles(string path_one, string path_two, string path_to)
        {
            StreamReader sr = new StreamReader(path_one);
            StreamWriter sw = new StreamWriter(path_to);

            sw.Write(sr.ReadToEnd());
            sr.Close();
            Console.WriteLine("First file written!");

            sr = new StreamReader(path_two);

            sw.Write(sr.ReadToEnd());
            sr.Close();
            Console.WriteLine("Second file written!");

            sw.Close();
            Console.WriteLine("To file Done!");
        }

        static void Main()
        {
            Concat_2TextFiles(
                @"..\..\TextFile1.txt"
                , @"..\..\TextFile2.txt"
                , @"..\..\TextFile_to.txt"
                );


        }
    }
}
