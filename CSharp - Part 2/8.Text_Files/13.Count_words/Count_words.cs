//Problem 13. Count words

//    Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//    The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. -> descending - nizhodq6t
//    Handle all possible exceptions in your methods.

namespace _13.Count_words
{
    using System;
    using System.Collections.Generic;
    using System.IO;



    class Count_words
    {

        static int StringInText(string str, string text, StringComparison strComp)
        {
            int count = 0;

            int lastI = text.LastIndexOf(str);
            int i = 0;
            while (i <= lastI)
            {
                i = text.IndexOf(str, i, strComp) + 1;
                count++;
            }

            return count;
        }

        static void CountWords(string dictPath, string path, string res)
        {
            try
            {
                var srd = new StreamReader(dictPath);
                var sr = new StreamReader(path);
                string text = sr.ReadToEnd();
                sr.Close();

                string line = string.Empty;

                var list = new List<Tuple<string, int>>();

                do
                {
                    line = srd.ReadLine();
                    if (line != null)
                    {
                        list.Add(Tuple.Create(line, StringInText(line, text, StringComparison.CurrentCulture)));
                    }
                } while (line != null);
                srd.Close();


                //var locations = new List<Tuple<DataRow, double>>();
                //locations.Add(Tuple.Create(row, distance));
                //locations.Sort((x, y) => x.Item2.CompareTo(y.Item2));

                list.Sort((x, y) => y.Item2.CompareTo(x.Item2));

                var sw = new StreamWriter(res);
                foreach (var item in list)
                {
                    sw.WriteLine(item.Item1 + "\t" + item.Item2);
                }
                sw.Close();
                Console.WriteLine("Done!");

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

            string dictPath = @"../../words.txt";
            string path = @"../../test.txt";
            string res = @"../../result.txt";
            CountWords(dictPath, path, res);

        }
    }
}
