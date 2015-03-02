
//Problem 9. Forbidden words

//    We are given a string containing a list of forbidden words and a text containing some of these words.
//    Write a program that replaces the forbidden words with asterisks.

//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

namespace _09.Forbidden_words
{
    using System;

    class Forbidden_words
    {
        static void ReplaceForbiddenWords(ref string text, string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                text = text.Replace(words[i], new string('*', words[i].Length));
            }
        }


        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] words = 
            {
                "PHP", "CLR", "Microsoft"
            };
            ReplaceForbiddenWords(ref text, words);
            Console.WriteLine(text);
        }
    }
}
