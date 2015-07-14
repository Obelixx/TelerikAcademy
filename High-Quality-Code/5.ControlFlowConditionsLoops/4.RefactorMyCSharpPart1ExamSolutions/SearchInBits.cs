namespace _4.RefactorMyCSharpPart1ExamSolutions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SearchInBits
    {
        public static void Start()
        {
            // This name declarations are by the task description!
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;

            int mask = 15;
            for (int i = 0; i < n; i++)
            {
                int tempNumber = numbers[i];
                //// 2147483647 is 23bit filled with '1' starting with '0'
                tempNumber = tempNumber & 2147483647;
                for (int j = 0; j < 30; j++)
                {
                    if ((tempNumber & mask) == s)
                    {
                        count++;
                    }

                    tempNumber >>= 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}