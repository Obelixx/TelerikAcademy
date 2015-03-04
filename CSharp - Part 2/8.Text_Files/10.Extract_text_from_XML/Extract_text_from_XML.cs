//Problem 10. Extract text from XML

//    Write a program that extracts from given XML file all the text without the tags.

//Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

namespace _10.Extract_text_from_XML
{
    using System;
    using System.IO;

    class Extract_text_from_XML
    {
        static string RemoveTags(string input)
        {
            int i;
            int j;
            while ((j = input.IndexOf('>')) >= 0 && (i = input.LastIndexOf('<', j)) >= 0)
            {
                input = input.Replace(input.Substring(i, j - i + 1), null);
            }
            return (input);
        }

        static void Extract(string path_in, string path_out)
        {
            var sr = new StreamReader(path_in);
            var sw = new StreamWriter(path_out);
            string fileLine = string.Empty;
            do
            {
                fileLine = sr.ReadLine();
                if (fileLine != null)
                {
                    fileLine = RemoveTags(fileLine);
                    sw.WriteLine(fileLine.Trim());
                }
            } while (fileLine != null);

            sr.Close();
            sw.Close();
            Console.WriteLine("Done!");

        }
        static void Main()
        {
            string pathInput = "../../input.xml";
            string output = "../../output.txt";
            Extract(pathInput, output);

        }
    }
}
