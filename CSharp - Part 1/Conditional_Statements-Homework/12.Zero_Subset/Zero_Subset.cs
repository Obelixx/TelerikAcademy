using System;

//Problem 12.* Zero Subset

//    We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//    Assume that repeating the same subset several times is not a problem.

//Examples:
//numbers 	result
//3 -2 1 1 8 	-2 + 1 + 1 = 0

//3 1 -7 35 22 	no zero subset

//1 3 -4 -2 -1 	1 + -1 = 0
//    1 + 3 + -4 = 0
//    3 + -2 + -1 = 0

//1 1 1 -1 -1 	1 + -1 = 0
//    1 + 1 + -1 + -1 = 0

//0 0 0 0 0 	0 + 0 + 0 + 0 + 0 = 0

//Hint: you may check for zero each of the 31 subsets with 31 if statements.

class Zero_Subset
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int numbersCount = 5; // program works for the first 5 digits in row. If more imputed, they enter in numbers[] but not used by this program!

        string inputString = string.Empty;
        while (inputString == null || inputString == string.Empty)
        {
            Console.Write("Input 5 numbers: ");
            inputString = Console.ReadLine();
        }

        string[] numbersString = new string[numbersCount];
        numbersString = inputString.Split(' ');

        int[] numbers = new int[numbersCount];

        try //check for errors in inportation 
        {
            for (int i_import = 0; i_import < numbersCount; i_import++)
            {
                numbers[i_import] = int.Parse(numbersString[i_import]);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid string!");
            return;   //stop if string is invalid
        }


        int zeroSubsetsCount = 0;
        //1+1=2;
        int i = 0; // start conditions
        int j = i + 1;

        for (i = 0; i < numbersCount - 1; i++)
        {
            for (j = i + 1; j < numbersCount; j++)
            {
                if (numbers[i] + numbers[j] == 0)
                {
                    Console.WriteLine("Number n{0} + n{1} is 0:\t{2} + {3} = 0", i + 1, j + 1, numbersString[i], numbersString[j]);
                    zeroSubsetsCount++;
                }
            }
        }

        //1+1+1=3
        i = 0;
        j = i + 1;
        int k = j + 1;
        for (i = 0; i < numbersCount - 2; i++)
        {
            for (j = i + 1; j < numbersCount - 1; j++)
            {
                for (k = j + 1; k < numbersCount; k++)
                {
                    if (numbers[i] + numbers[j] + numbers[k] == 0)
                    {
                        Console.WriteLine("Number n{0} + n{1} + n{2} = 0:\t{3} + {4} + {5} = 0", i + 1, j + 1, k + 1, numbersString[i], numbersString[j], numbersString[k]);
                        zeroSubsetsCount++;
                    }
                }
            }
        }

        //1+1+1+1=4
        i = 0;
        j = i + 1;
        k = j + 1;
        int l = k + 1;

        for (i = 0; i < numbersCount - 3; i++)
        {
            for (j = i + 1; j < numbersCount - 2; j++)
            {
                for (k = j + 1; k < numbersCount - 1; k++)
                {
                    for (l = k + 1; l < numbersCount; l++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] + numbers[l] == 0) 
                        { 
                            Console.WriteLine("Number n{0} + n{1} + n{2} + n{3} = 0:\t{4} + {5} + {6} + {7} = 0", i + 1, j + 1, k + 1, l + 1, numbersString[i], numbersString[j], numbersString[k], numbersString[l]);
                            zeroSubsetsCount++;
                        }
                    }
                }
            }
        }

        //1+1+1+1+1=5 // all 5
        i = 0;
        j = i + 1;
        k = j + 1;
        l = k + 1;
        if (numbers[i] + numbers[j] + numbers[k] + numbers[l] + numbers[l + 1] == 0) 
        {
            Console.WriteLine("Number n{0} + n{1} + n{2} + n{3} + n{4} = 0:\t{5} + {6} + {7} + {8} + {9} = 0", i + 1, j + 1, k + 1, l + 1, l + 2, numbersString[i], numbersString[j], numbersString[k], numbersString[l], numbersString[l + 1]);
            zeroSubsetsCount++;
        }

        if (zeroSubsetsCount == 0) Console.WriteLine("no zero subset");
        else Console.WriteLine("Zero subsets count: {0}",zeroSubsetsCount);
    }
}

