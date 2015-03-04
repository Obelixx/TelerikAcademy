//Problem 12. Remove words

//    Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

namespace _12.Remove_words
{
    using System;
    using System.IO;

    class Remove_words
    {
        static void ReplaceWholeWord_InFile(string path, string start, string finish)
        {
            try
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
                //Console.WriteLine("Done!");
            }
            catch (System.Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        static void ReplaceFromDictionary(string path, string dictPath)
        {
            try
            {
                var sr = new StreamReader(dictPath);

                string line = string.Empty;
                string finish = null;

                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        ReplaceWholeWord_InFile(path, line, finish);
                    }
                } while (line != null);
                sr.Close();
                Console.WriteLine("Done");
            }
            catch (System.Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
        static void Main()
        {
            // file: az si hodq, a toi me vidq... bla bla bla, a ti vidq li?
            // dict file: az ti toi
            // expected rez:  si hodq, a  me vidq... bla bla bla, a  vidq li?

            string dictPath = @"../../dict.txt";
            string path = @"../../file.txt";
            ReplaceFromDictionary(path, dictPath);

        }
    }
}
