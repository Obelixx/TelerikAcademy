namespace PrintNamespace
{
    using System;

    /// <summary>
    /// Print class for refactoring homework - DONT USE IT!
    /// </summary>
    public class Print
    {
        public void Statistics(double[] array, int count)
        {
            if (count > array.Length)
            {
                throw new IndexOutOfRangeException("There is no 'count' elements in the 'array'");
            }

            if (array.Length < 1)
            {
                return;
            }

            double max = array[0];
            double min = array[0];
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < max)
                {
                    min = array[i];
                }

                sum += array[i];
            }

            // PrintMax(max);
            // PrintMin(min);
            // PrintAvg(sum / count);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            double avr = sum / count;
            Console.WriteLine("Avg: " + avr);
        }
    }
}