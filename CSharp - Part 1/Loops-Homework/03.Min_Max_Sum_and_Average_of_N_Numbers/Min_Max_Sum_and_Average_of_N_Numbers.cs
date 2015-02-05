using System;

//Problem 3. Min, Max, Sum and Average of N Numbers

//    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//    The output is like in the examples below.

//Example 1:
//input 	output
//3
//2
//5
//1 	min = 1
//max = 5
//sum = 8
//avg = 2.67

//Example 2:
//input 	output
//2
//-1
//4 	min = -1
//max = 4
//sum = 3
//avg = 1.50

class Min_Max_Sum_and_Average_of_N_Numbers
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n (n>0): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1) Console.WriteLine("Input {0} number (n>0)!", Convert.GetTypeCode(n));

        int[] numbers = new int[n];
        int sum = 0;
        int min = 0;
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Input n{0}:", i);
            while (!int.TryParse(Console.ReadLine(), out numbers[i])) Console.WriteLine("Input {0} number (n>0)!", Convert.GetTypeCode(numbers[i]));
            if (i == 0)
            {
                min = numbers[i];
                max = numbers[i];
            }
            if (min > numbers[i]) min = numbers[i];
            if (max < numbers[i]) max = numbers[i];
            sum += numbers[i];
        }
        double avg = 0;
        avg = sum / (double)n;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:0.00}", avg);
    }
}

