//Problem 11. Prefix "test"

//    Write a program that deletes from a text file all words that start with the prefix test.
//    Words contain only the symbols 0…9, a…z, A…Z, _.

namespace _11.Prefix_test
{
    using System;
    using System.IO;

    class Prefix_test
    {
        static bool IsWordSimbol(char ch)
        {
            if (ch >= '0' && ch <= '9')
            {
                return true;
            }
            if (ch >= 'a' && ch <= 'z')
            {
                return true;
            }
            if (ch >= 'A' && ch <= 'Z')
            {
                return true;
            }
            if (ch == '_')
            {
                return true;
            }
            return false;

        }

        static int findJ(string input, int i)
        {
            for (int j = i; j < input.Length; j++)
            {
                if (!IsWordSimbol(input[j]))
                {
                    return (j);
                }
                if (j == input.Length-1)
                {
                    return (j+1);
                }
            }
            return (-1);
        }

        static string RemoveTestWords_FromString(string input)
        {
            string output = input;
            int i = 0;
            int j = 0;
            while ((i = input.IndexOf("test", i)) >= 0)
            {
                if (i == 0)
                {
                    //find j;
                    //if not found i++ and continue
                    j = findJ(input, i);
                    if(j==-1)
                    {
                        i++;
                        continue;
                    }
                    output = input.Substring(j, input.Length - j);

                }
                else
                {
                    if (IsWordSimbol(input[i - 1]))
                    {
                        i++;
                        continue;
                    }
                    //find j;
                    //if not found i++ and continue
                    j = findJ(input, i);
                    if (j == -1)
                    {
                        i++;
                        continue;
                    }
                    output = input.Substring(0,i) + input.Substring(j, input.Length - j);
                }
                i++;
            }
            return (output);
        }

        static void RemoveTestWords(string path_in, string path_out)
        {
            var sr = new StreamReader(path_in);
            var sw = new StreamWriter(path_out);
            string fileLine = string.Empty;
            int i;
            int j;
            do
            {
                fileLine = sr.ReadLine();
                if (fileLine != null)
                {
                    fileLine = RemoveTestWords_FromString(fileLine);
                    sw.WriteLine(fileLine.Trim());
                }
            } while (fileLine != null);

            sr.Close();
            sw.Close();
            Console.WriteLine("Done!");

        }
        static void Main()
        {
            string pathInput = "../../input.txt";
            string output = "../../output.txt";
            RemoveTestWords(pathInput, output);

        }
    }
}
