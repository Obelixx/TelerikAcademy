namespace Task2
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class SumOfDifferences
    {
        public static void Task2Main()
        {
            string input = Console.ReadLine();
            string[] inputStrings = input.Split(' ');

            BigInteger[] numbers = new BigInteger[inputStrings.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = BigInteger.Parse(inputStrings[i]);
            }

            var absDif = new List<BigInteger>();

            int j = 1;
            int absCount = 0;
            while (j < numbers.Length)
            {
                absDif.Add(AbsoluteDifference(numbers[j], numbers[j - 1]));
                if (absDif[absCount] % 2 == 0)
                {
                    j += 2;
                }
                else
                {
                    j++;
                }

                absCount++;
            }

            BigInteger sum = 0;
            foreach (var item in absDif)
            {
                if (item % 2 != 0)
                {
                    sum += item;
                }
            }

            Console.WriteLine(sum);
        }

        private static BigInteger AbsoluteDifference(BigInteger a, BigInteger b)
        {
            if (a > b)
            {
                return a - b;
            }
            else
            {
                return b - a;
            }
        }
    }
}