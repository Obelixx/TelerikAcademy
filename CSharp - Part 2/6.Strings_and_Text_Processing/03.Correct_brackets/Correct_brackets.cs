
//Problem 3. Correct brackets

//    Write a program to check if in a given expression the brackets are put correctly.

//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

namespace _03.Correct_brackets
{
    using System;
    class Correct_brackets
    {
        static bool Check_brackets(string exp)
        {
            int c1 = 0;
            int c2 = 0;
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(')
                {
                    c1++;
                }
                if (exp[i] == ')')
                {
                    c2++;
                }
            }
            if (c1 == c2) return true;
            else return false;
        }

        static void Main()
        {
            string test_str1 = "((a+b)/5-d)";
            string test_str2 = ")(a+b))";

            if(Check_brackets(test_str1))
            {
                Console.WriteLine("String: {0} is with valid brackets",test_str1);
            }
            else
            {
                Console.WriteLine("String: {0} is with invalid brackets", test_str1);
            }


            if (Check_brackets(test_str2))
            {
                Console.WriteLine("String: {0} is with valid brackets", test_str2);
            }
            else
            {
                Console.WriteLine("String: {0} is with invalid brackets", test_str2);
            }
        }
    }
}
