//Problem 8. Extract sentences

//    Write a program that extracts from a given text all sentences containing given word.

//Example:

//The word is: in

//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.

namespace _08.Extract_sentences
{
    using System;
    using System.Collections.Generic;

    class Extract_sentences
    {
        static bool IsLetter(char ch) // method to check for letter
        {
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string ExtractSentancesContaining(string text, string withContent)
        {
            var sentences = new List<string>();
            int lastI = 0;
            for (int i = 0; i < text.Length; i++) //add sentences in list of strings
            {
                if (text[i] == '.')
                {
                    sentences.Add(text.Substring(lastI, i + 1 - lastI));
                    lastI = i + 1;

                }
            }

            for (int i = 0; i < sentences.Count; i++) //check every sentence
            {
                string tempStr = sentences[i].ToString();
                int tempPos = 0;
                int tempLastPos = tempStr.LastIndexOf(withContent);
                bool WordFound = false;

                do
                {
                    tempPos = tempStr.IndexOf(withContent,tempPos+1);
                    if (tempPos != 0)
                    {
                        if (IsLetter(tempStr[tempPos - 1]))
                        {
                            continue;
                        }
                    }
                    if (tempPos != tempStr.Length - 1)
                    {
                        if (IsLetter(tempStr[tempPos + withContent.Length]))
                        {
                            continue;
                        }
                    }
                    WordFound = true;//we fount word!
                    break;
                } while (tempPos < tempLastPos);

                if (!WordFound) //if word is found(or not) do something...
                {
                    sentences.RemoveAt(i);
                    i--;//we removed one sentence, and we need to check the sentence on the same index
                }

            }
            return (string.Join<string>(null, sentences)); // join all sentences witch survived in list
        }

        static void Main()
        {
            string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = "in";
            string result = ExtractSentancesContaining(input, word);
            Console.WriteLine(result);
        }
    }
}
