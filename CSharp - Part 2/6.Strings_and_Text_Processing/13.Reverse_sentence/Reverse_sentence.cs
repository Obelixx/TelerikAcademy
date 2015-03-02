//Problem 13. Reverse sentence

//    Write a program that reverses the words in given sentence.

//Example:
//input 	output
//C# is not C++, not PHP and not Delphi! 	Delphi not and PHP, not C++ not is C#!

namespace _13.Reverse_sentence
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Reverse_sentence
    {
        static bool IsPunctoation(char ch)
        {
            switch (ch)
            {
                case '!':
                case '?':
                case '.':
                case ',':
                    return true;
                default:
                    return false;
            }
        }

        static string ReverseSentence(string str)
        {
            var lst = new List<string>();

            string[] tmpStr = str.Split(' '); //add words into list -split by space
            for (int i = 0; i < tmpStr.Length; i++)
            {
                lst.Add(tmpStr[i]);
            }

            for (int i = 0; i < lst.Count; i++) //move punctuations in the end of the words to new list member
            {
                if (IsPunctoation(lst[i].ToString()[lst[i].ToString().Length - 1]))
                {
                    char tempchar = lst[i].ToString()[lst[i].ToString().Length - 1];
                    lst[i] = lst[i].Remove(lst[i].ToString().Length - 1);
                    lst.Insert(i + 1, tempchar.ToString());
                    i++;
                }
            }

            var lstRev = new List<string>();

            for (int i = lst.Count - 1; i >= 0; i--) // add only words to new list
            {
                if (!IsPunctoation(lst[i].ToString()[0]))
                {
                    lstRev.Add(lst[i]);
                }
            }

            for (int i = 0; i < lst.Count; i++)// add punctuations on the same places;
            {
                if (IsPunctoation(lst[i].ToString()[0]))
                {
                    lstRev.Insert(i, lst[i].ToString());
                }
            }

            //build new string
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < lstRev.Count; i++)
            {
                sb.Append(lstRev[i].ToString());
                sb.Append(' ');
            }

            for (int i = 0; i < sb.Length; i++) // remove spaces befor punctuation, and in the end.
            {
                if (IsPunctoation(sb[i]))
                {
                    sb.Remove(i - 1, 1);
                }
            }
            if (sb[sb.Length - 1] == ' ')
            {
                sb.Remove(sb.Length - 1, 1);
            }


            // // well, this is not in the problem definition, but here is code to:
            // //First letter -> to Upper ; And First letter of the last word -> to Lower
            //sb[0] = sb[0].ToString().ToUpper()[0];
            //sb[sb.ToString().LastIndexOf(' ') + 1] = sb[sb.ToString().LastIndexOf(' ') + 1].ToString().ToLower()[0];

            return (sb.ToString());
        }

        static void Main()
        {
            string input = "C# is not C++, not PHP and not Delphi!";
            string output = ReverseSentence(input);
            Console.WriteLine(output);

        }
    }
}
