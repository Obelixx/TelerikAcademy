//Problem 8. Replace whole word

//    Modify the solution of the previous problem to replace only whole words (not strings).

namespace _08.Replace_whole_word
{
    using System;
    using System.IO;

    class Replace_whole_word
    {
        static void ReplaceWholeWord_InFile(string path, string start, string finish)
        {
            StreamReader sr = new StreamReader(path);
            StreamWriter sw = new StreamWriter(@"./output.tmp");
            string line = null;
            do
            {
                line = sr.ReadLine();

                if (line != null)
                {
                    int i = 0;
                    while (i >= 0)
                    {
                        if (line != string.Empty)
                        {
                            if ((i = line.IndexOf(start, i)) >= 0)
                            {
                                if (i == 0)
                                {
                                    if (!char.IsLetter(line[i + start.Length]))
                                    {
                                        line = finish + line.Substring(i + start.Length);
                                    }
                                }
                                else if (i == line.Length - start.Length)
                                {
                                    if (!char.IsLetter(line[i - 1]))
                                    {
                                        line = line.Substring(0, i) + finish;
                                    }
                                }
                                else
                                {
                                    if (!char.IsLetter(line[i + start.Length]) && !char.IsLetter(line[i - 1]))
                                    {
                                        line = line.Substring(0, i) + finish + line.Substring(i + start.Length);
                                    }
                                }
                            }
                            if (i != -1)
                            {
                                i++;
                            } //012345
                        }     //123456
                        else
                        {
                            i = -1;
                        }
                    }

                    sw.WriteLine(line);
                }
            } while (line != null);
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
            ReplaceWholeWord_InFile(path, start, finish);
        }
    }
}
