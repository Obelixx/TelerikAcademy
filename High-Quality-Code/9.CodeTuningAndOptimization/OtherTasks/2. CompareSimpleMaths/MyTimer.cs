namespace ComparePerformance
{
    using System;
    using System.Diagnostics;

    public class MyTimer<T>
    {
        public delegate T TasksDelegate(T a, T b);

        public static void Test(TasksDelegate tasks, T a, T b, int times, out long miliseconds, out long ticks)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < times; i++)
            {
                tasks(a, b);
            }
            timer.Stop();
            miliseconds = timer.ElapsedMilliseconds;
            ticks = timer.ElapsedTicks;
        }

    }
}
