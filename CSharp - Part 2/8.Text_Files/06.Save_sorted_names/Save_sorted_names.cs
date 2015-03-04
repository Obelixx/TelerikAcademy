//Problem 6. Save sorted names

//    Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

//Example:
//input.txt 	output.txt
//Ivan
//Peter
//Maria
//George 	George
//          Ivan
//          Maria
//          Peter
namespace _06.Save_sorted_names
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Save_sorted_names
    {
        static void Sort_TextFile(string path_from, string path_to)
        {
            StreamReader sr = new StreamReader(path_from);
            var list = new List<string>();

            string line;
            do
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    list.Add(line);
                }
            } while (line != null);

            sr.Close();


            list.Sort();
            StreamWriter sw = new StreamWriter(path_to);
            foreach (var item in list)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();
            Console.WriteLine("File Written!");

        }

        static void Main()
        {
            string path_from = @"..\..\TextFile_from.txt";
            string path_to = @"..\..\TextFile_to.txt";
            Sort_TextFile(path_from, path_to);

        }
    }
}
