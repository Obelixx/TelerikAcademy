//Problem 14. Word dictionary

//    A dictionary is stored as a sequence of text lines containing words and their explanations.
//    Write a program that enters a word and translates it by using the dictionary.

//Sample dictionary:
//input 	output
//.NET 	platform for applications from Microsoft
//CLR 	managed execution environment for .NET
//namespace 	hierarchical organization of classes

namespace _14.Word_dictionary
{
    using System;
    using System.Collections.Generic;

    class Word_dictionary
    {
        static string Dictionary(string word)
        {
            var words = new List<string>();
            var explanation = new List<string>();
            words.Add(".NET");
            explanation.Add("platform for applications from Microsoft");
            words.Add("CLR");
            explanation.Add("managed execution environment for .NET");
            words.Add("namespace");
            explanation.Add("hierarchical organization of classes");

            for (int i = 0; i < words.Count; i++)
            {
                if(words[i]==word)
                {
                    return (explanation[i]);
                }
            }
            return ("Word not found in the dictionary!");

        }


        static void Main()
        {
            string input = "CLR";
            Console.WriteLine("{0} is: {1}", input ,Dictionary(input));
            input = "Unknown_word";
            Console.WriteLine("{0} is: {1}", input, Dictionary(input));

        }
    }
}
