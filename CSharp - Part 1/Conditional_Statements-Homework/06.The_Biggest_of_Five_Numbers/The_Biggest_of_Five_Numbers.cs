using System;

//Problem 6. The Biggest of Five Numbers

//    Write a program that finds the biggest of five numbers by using only five if statements.

//Examples:
//a 	b 	c 	d 	e 	biggest
//5 	2 	2 	4 	1 	5
//-2 	-22 	1 	0 	0 	1
//-2 	4 	3 	2 	0 	4
//0 	-2.5 	0 	5 	5 	5
//-3 	-0.5 	-1.1 	-2 	-0.1 	-0.1

class The_Biggest_of_Five_Numbers
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int howManyNumbersWillYouAskUsToCompareNow = 5; //Biggest of 5, biggest of 100 ??      >>>works only for more then 3 !!!!<<<
        int numbersCount = howManyNumbersWillYouAskUsToCompareNow; //I try not to use bad identifiers :)
        double[] num = new double[numbersCount];

        for (int i = 0; i < numbersCount; i++)
        {            
            Console.Write("Input number{0}: ",i+1);
            while (!double.TryParse(Console.ReadLine(), out num[i])) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(num[i]));
        }

        double biggest;
        if (num[0] > num[1]) biggest = num[0]; //if 1
        else biggest = num[1];

        for (int i = 2; i < numbersCount; i++)
        {
            if (biggest < num[i]) biggest = num[i];    // if 2,3 and 4 (for 5 numbers)
        }
        
        Console.WriteLine(biggest);
    }
}

