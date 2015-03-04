//Problem 4. Compare text files

//    Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//    Assume the files have equal number of lines.

namespace _04.Compare_text_files
{
    using System;
    using System.IO;

    class Compare_text_files
    {
        static void Compare_2Files(string path_one, string path_two, out ulong same, out ulong different)
        {
            StreamReader file_one = new StreamReader(path_one);
            StreamReader file_two = new StreamReader(path_two);
            string fileOneLine = string.Empty;
            string fileTwoLine = string.Empty;
            same = 0;
            different = 0;

            do
            {
                fileOneLine = file_one.ReadLine();
                fileTwoLine = file_two.ReadLine();
                if (fileOneLine != null || fileTwoLine != null)
                {
                    if (fileOneLine == fileTwoLine)
                    {
                        same++;
                    }
                    else
                    {
                        different++;
                    }
                }
            } while (fileOneLine != null || fileTwoLine != null); //Assume the files have equal number of lines.

            file_one.Close();
            file_two.Close();
            //Console.WriteLine("Files closed!");

        }

        static void Main()
        {
            string pathOne = @"..\..\TextFile1.txt";
            string pathTwo = @"..\..\TextFile2.txt";
            ulong same;
            ulong different;

            Compare_2Files(pathOne, pathTwo, out same, out different);
            Console.WriteLine("Same lines count is: {0}", same);
            Console.WriteLine("Different lines count is: {0}", different);
        }
    }
}
