using System;

//Problem 12.* Randomize the Numbers 1…N

//    Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

//Examples:
//n 	randomized numbers 1…n
//3 	2 1 3
//10 	3 4 8 2 6 7 9 1 10 5

//Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.

class Randomize_the_Numbers_1__N
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n(n>0): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) Console.WriteLine("Input {0} number!(n>0)", Convert.GetTypeCode(n));

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i+1;
        }

        int rndNumber;
        Random rndGen = new Random();


        for (int i = 0; i < n; i++)
        {
            rndNumber = rndGen.Next(0, n);
            if (rndNumber != i)
            {
                numbers[i] = numbers[i] + numbers[rndNumber];
                numbers[rndNumber] = numbers[i] - numbers[rndNumber];
                numbers[i] = numbers[i] - numbers[rndNumber];
            }
        }

        foreach (var a in numbers)
        {
            Console.Write(a + " ");
        }
        Console.WriteLine();
    }
}