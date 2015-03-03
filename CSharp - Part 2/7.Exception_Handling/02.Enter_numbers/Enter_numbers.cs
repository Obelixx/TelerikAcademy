//Problem 2. Enter numbers

//    Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//        If an invalid number or non-number text is entered, the method should throw an exception.
//    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace _02.Enter_numbers
{
    using System;

    class Enter_numbers
    {
        static int ReadNumber(int start, int end)
        {
            int number;
            try
            {
                Console.Write("Enter number in interval [{0} ... {1} ] here: ", start, end);
                number = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number!");
                throw (new ArgumentOutOfRangeException("You must enter number in the expected range!"));
            }
            return (number);
        }


        static void Main()
        {
            int[] a = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("For a[{0}] ", i + 1);
                if (i != 0)
                {
                    a[i] = ReadNumber(a[i - 1], 100);
                }
                else
                {
                    a[i] = ReadNumber(0, 100);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Your Input:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                if (i != a.Length - 1)
                {
                    Console.Write(" < ");
                }
            }
            Console.WriteLine();
        }
    }
}
