using System;

//Problem 1. Sum of 3 Numbers

//    Write a program that reads 3 real numbers from the console and prints their sum.

//Examples:
//a 	b 	c 	sum
//3 	4 	11 	18
//-2 	0 	3 	1
//5.5 	4.5 	20.1 	30.1

    class Sum_of_3_Numbers
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            float a = 0;
            Console.Write("Input n:");
            while (!float.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(a));
            }

            float b = 0;
            Console.Write("Input n:");
            while (!float.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(b));
            }

            float c = 0;
            Console.Write("Input n:");
            while (!float.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(c));
            }

            float sum = a + b + c;

            Console.WriteLine("{0}\t{1}\t{2}\t\t{3}","a", "b", "c", "sum");
            Console.WriteLine("{0}\t{1}\t{2}\t\t{3}", a, b, c, sum);


        }
    }
