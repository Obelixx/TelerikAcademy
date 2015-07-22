namespace Task1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class MathProblem
    {
        public static void Task1Main()
        {
            string[] inputStrings = Console.ReadLine().Split(' ');
            List<int[]> numbers = new List<int[]>();

            foreach (var item in inputStrings)
            {
                numbers.Add(StringToIntArray(item));
            }

            BigInteger[] sums = new BigInteger[numbers.Count];

            for (int i = 0; i < sums.Length; i++)
            {
                sums[i] = AnyToDec(numbers[i]);
            }

            BigInteger sumOfSums = 0;
            foreach (var sum in sums)
            {
                sumOfSums += sum;
            }

            string to19 = IntArrayToString(DecToAny(sumOfSums)); ////.TrimStart('0');
            Console.Write("{0} = {1}", to19, sumOfSums);
        }

        private static int[] DecToAny(BigInteger dec, int toCountSystem = 19)
        {
            var result = new List<int>();
            int i = 0;
            while (dec != 0)
            {
                result.Add((int)(dec % toCountSystem));
                dec /= toCountSystem;
                i++;
            }

            int[] result_arr = result.ToArray();
            Array.Reverse(result_arr);
            return result_arr;
        }

        private static BigInteger AnyToDec(int[] hex, int fromCountSystem = 19)
        {
            Array.Reverse(hex);
            BigInteger result = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                if (hex[i] != 0)
                {
                    result += (int)(hex[i] * Math.Pow(fromCountSystem, i));
                }
            }

            return result;
        }

        private static int[] StringToIntArray(string str)
        {
            int[] arr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = str[i] - 'a';
            }

            return arr;
        }

        private static string IntArrayToString(int[] arr)
        {
            string str = string.Empty;
            foreach (var item in arr)
            {
                str += (char)(item + 'a');
            }

            return str;
        }
    }
}
