
//Problem 4. Sub-string in text

//    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9

namespace _04.Sub_string_in_text
{
    using System;
    class Program
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

        static void Main(string[] args)
        {
            string str = "in";
            string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            int result = StringInText(str, text, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(result);

        }
    }
}
