//Problem 10. Unicode characters

//    Write a program that converts a string to a sequence of C# Unicode character literals.
//    Use format strings.

//Example:
//input 	output
//Hi! 	\u0048\u0069\u0021
namespace _10.Unicode_characters
{
    using System;
    using System.Text;

    class Unicode_characters
    {
        static string ConvertToUnicode(string text)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                output.Append(string.Format(@"\n{0:X4}", (int)text[i]));
            }
            return(output.ToString());
        }


        static void Main()
        {
            string input = "Hi!";
            string output = ConvertToUnicode(input);
            Console.WriteLine(output);
        }
    }
}
