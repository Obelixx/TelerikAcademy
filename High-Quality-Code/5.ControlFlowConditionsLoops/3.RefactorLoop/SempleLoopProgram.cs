namespace _3.RefactorLoop
{
    using System;

    /// <summary>
    /// Sample LoopProgram class - DONT USE IT!
    /// </summary>
    public class SempleLoopProgram
    {
        public static void Main(string[] args)
        {
            const int INDEX_DEVIDEABLE_ON = 10;

            int i;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int expectedValue = 11;

            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                if (i % INDEX_DEVIDEABLE_ON == 0 && array[i] == expectedValue)
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }
        }
    }
}
