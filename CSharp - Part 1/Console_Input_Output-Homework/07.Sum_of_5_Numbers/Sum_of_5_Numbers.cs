using System;

//Problem 7. Sum of 5 Numbers

//    Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

//Examples:
//numbers 	sum
//1 2 3 4 5 	15
//10 10 10 10 10 	50
//1.5 3.14 8.2 -1 0 	11.84

class Sum_of_5_Numbers
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        string[] numbers = new string[5];
        numbers = Console.ReadLine().Split(' ') ;
        double sum = 0.0;
        for (int i = 0; i < 5; i++)
        {
            sum+=Convert.ToDouble(numbers[i]);
        }
        Console.WriteLine(sum);
    }
}
