namespace Task1_ThreeNumbers
{
    using System;

    // Not much to re-factor
    public class ThreeNumbers
    {
        public static void Start()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int biggest = Math.Max(a, b);
            biggest = Math.Max(biggest, c);
            Console.WriteLine(biggest);

            int smallest = Math.Min(a, b);
            smallest = Math.Min(smallest, c);
            Console.WriteLine(smallest);

            double mean = (a + b + c) / 3.0;
            Console.WriteLine("{0:F2}", mean);
        }
    }
}
