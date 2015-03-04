//Problem 7. Replace sub-string

//    Write a program that replaces all occurrences of the sub-string "start" with the sub-string "finish" in a text file.
//    Ensure it will work with large files (e.g. 100 MB).

namespace _07.Replace_sub_string
{
    using System;
    using System.IO;

    class Replace_substring
    {
        static void ReplaceSubstring_InFile(string path, string start, string finish)
        {
            StreamReader sr = new StreamReader(path);
            StreamWriter sw = new StreamWriter(@"./output.tmp");
            string line = null;
            do
            {
                line = sr.ReadLine();
                
                if (line!=null) 
                {
                    line = line.Replace(start,finish);
                    sw.WriteLine(line);
                }
            } while (line!=null);
            sr.Close();
            sw.Close();

            File.Delete(path);
            File.Move(@"./output.tmp", path);
            File.Delete(@"./output.tmp");
            Console.WriteLine("Done!");
        }
        static void Main()
        {
            string start = "start";
            string finish = "finish";

            //string start = "finish";
            //string finish = "start";

            string path = @"../../100mb.txt";
            ReplaceSubstring_InFile(path, start, finish);
        }
    }
}
