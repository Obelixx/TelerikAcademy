//Problem 5. Parse tags

//    You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//    The tags cannot be nested.

//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace _05.Parse_tags
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Parse_tags
    {
        static string DoUpcaseTag(string text)
        {
            string tagB = "<upcase>";
            string tagE = "</upcase>";

            int lastI = text.LastIndexOf(tagB);
            int i = 0;
            int j = 0;
            var listB = new List<int>();
            var listE = new List<int>();

            while (i <= lastI) // take tags indexes
            {
                int begin = j + tagE.Length;
                i = text.IndexOf(tagB, i);
                j = text.IndexOf(tagE, j);
                listB.Add(i);
                listE.Add(j);
                i++;
                j++;
            }
            if (listB.Count != listE.Count)
            {
                throw new Exception("Error in tags count!");
            }

            var stringsInTags = new List<string>();

            for (int k = 0; k < listB.Count; k++) // make list with text in tags (with tags - see why next comment)
            {
                stringsInTags.Add(text.Substring(listB[k], listE[k] - listB[k] + tagB.Length + 1));
            }

            // assemble new text
            StringBuilder sb = new StringBuilder();

            sb.Append(text);
            for (int k = 0; k < stringsInTags.Count; k++)
            {
                sb.Replace(stringsInTags[k], stringsInTags[k].ToUpper()); //if list is without tags - any repetitionst with same word will be upcased.
            }
            tagB = tagB.ToUpper(); // we change the tags too ..
            tagE = tagE.ToUpper();

            sb.Replace(tagB, null); // .. in order to remove them
            sb.Replace(tagE, null);


            return (sb.ToString());
        }

        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            string result = DoUpcaseTag(text);

            Console.WriteLine(result);

        }
    }
}
