//Problem 2. Random numbers

//    Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace _02.Random_numbers
{
    using System;

    class Random_numbers
    {
        //Random rndGen = new Random;

        public static int[] GenNRandoms(int n, int from, int to)
        {
            Random rndGen = new Random();


            if (n < 0 || from < 0 || to < 0)
            {
                throw new IndexOutOfRangeException("Use N>0,from>0 and to>0! (in GenNRandoms(int n, int from, int to); )");
            }
            if (from > to)
            {
                from = from + to;
                to = from - to;
                from = from - to;
            }
            to++;

            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rndGen.Next(from, to);
            }
            return (arr);
        }

        static void Main()
        {
            int[] rndArray;
            rndArray= GenNRandoms(10,100,200);

            for (int i = 0; i < rndArray.Length; i++)
            {
                Console.Write(rndArray[i]);
                if(i!=rndArray.Length-1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

        }


    }
}
