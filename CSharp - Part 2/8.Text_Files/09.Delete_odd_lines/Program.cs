//Problem 9. Delete odd lines

//    Write a program that deletes from given text file all odd lines.
//    The result should be in the same file.

namespace _09.Delete_odd_lines
{
    using System;
    using System.IO;

    class Program
    {
        static void RemoveOddLines_FromFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string fileLine = string.Empty;
            StreamWriter sw = new StreamWriter(@"./output.tmp");

            do
            {
                fileLine = sr.ReadLine();
                sr.ReadLine();
                if (fileLine != null)
                {
                    sw.WriteLine(fileLine);
                }
            } while (fileLine != null);
            sr.Close();
            sw.Close();

            File.Delete(path);
            File.Move(@"./output.tmp", path);
            File.Delete(@"./output.tmp");
            Console.WriteLine("Done!");

        }

        static void Main()
        {
            string path = @"../../Example.txt";
            RemoveOddLines_FromFile(path);
        }

    }
}
