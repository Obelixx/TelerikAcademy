
//Problem 6. Sum integers

//    You are given a sequence of positive integer values written into a string, separated by spaces.
//    Write a function that reads these values from given string and calculates their sum.

//Example:
//input 	output
//"43 68 9 23 318" 	461

namespace _06.Sum_integers
{
    using System;

    class Sum_integers
    {
        static int SumString(string input)
        { 
            string[] inputArr = input.Split(' ');
            int sum =0;
            for (int i = 0; i < inputArr.Length; i++)
			{
                int tempInt =0;
                int.TryParse(inputArr[i],out tempInt);
                sum += tempInt;
			}
            return(sum);
        }

        static void Main()
        {
            string inputString = "43 68 9 23 318";
            inputString += " " + "errors more errors"; //adding errors in string :)
            Console.WriteLine("Sum is: {0}", SumString(inputString) );
        }
    }
}
