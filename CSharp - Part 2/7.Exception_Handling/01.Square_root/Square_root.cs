//Problem 1. Square root

//    Write a program that reads an integer number and calculates and prints its square root.
//        If the number is invalid or negative, print Invalid number.
//        In all cases finally print Good bye.
//    Use try-catch-finally block.

namespace _01.Square_root
{
    using System;

    class Square_root
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            int number;
            double output;

            try
            {
                Console.Write("Input Number: ");
                number = int.Parse(Console.ReadLine());
                output = Math.Sqrt(number);
                Console.WriteLine("Square root of {0} is: {1}",number, output);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
