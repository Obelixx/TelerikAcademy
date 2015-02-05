using System;

//Problem 11.* Numbers in Interval Dividable by Given Number

//    Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

//Examples:
//start 	end 	p 	comments
//17 	25 	2 	20, 25
//5 	30 	6 	5, 10, 15, 20, 25, 30
//3 	33 	6 	5, 10, 15, 20, 25, 30
//3 	4 	0 	-
//99 	120 	5 	100, 105, 110, 115, 120
//107 	196 	18 	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195

class Numbers_in_Interval_Dividable_by_Given_Number
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int start = 0;
        Console.Write("Input start (start>0): ");
        while (!int.TryParse(Console.ReadLine(), out start) || start < 1) Console.WriteLine("Input {0} number (n>0)!", Convert.GetTypeCode(start));

        int end = 0;
        Console.Write("Input end (end>0): ");
        while (!int.TryParse(Console.ReadLine(), out end) || end < 1) Console.WriteLine("Input {0} number (n>0)!", Convert.GetTypeCode(end));

        if (start > end)
        {
            Console.WriteLine("Error: Start is bigger then end!");
            return;
        }

        int p = 0;
        for (int i = start; i <= end; i++) if (i % 5 == 0) p++;
        Console.WriteLine(p);
    }
}

