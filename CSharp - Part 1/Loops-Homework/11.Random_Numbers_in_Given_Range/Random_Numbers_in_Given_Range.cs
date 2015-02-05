using System;

//Problem 11. Random Numbers in Given Range

//    Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

//Examples:
//n 	min 	max 	random numbers
//5 	0 	1 	1 0 0 1 1
//10 	10 	15 	12 14 12 15 10 12 14 13 13 11

//Note: The above output is just an example. Due to randomness, your program most probably will produce different results.

class Random_Numbers_in_Given_Range
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n: ");
        while (!int.TryParse(Console.ReadLine(), out n)) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(n));

        int min = 0;
        Console.Write("Input min: ");
        while (!int.TryParse(Console.ReadLine(), out min)) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(min));

        int max = min;
        Console.Write("Input max!=min: ");
        while (!int.TryParse(Console.ReadLine(), out max) || max == min) Console.WriteLine("Input {0} number max!=min!", Convert.GetTypeCode(max));

        if(min>max)
        {
            min = min + max;
            max = min - max;
            min = min - max;
        }

        Random rndGen = new Random();
        int rndNumber;
        for (int i = 0; i < n; i++)
        {
            rndNumber = rndGen.Next(min, max + 1);
            //if (rndNumber == max + 1) rndNumber -= 1; // just checking, because rndGen.Next(0, max) dont give the max value;
            if (rndNumber == max + 1) Console.WriteLine("\n\n haha \n\n");
            Console.Write(rndNumber);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
