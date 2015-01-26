using System;

//Problem 9. Sum of n Numbers

//    Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

//Examples:
//numbers 	sum
//3 	90
//20 	
//60 	
//10 	
//5 	6.5
//2 	
//-1 	
//-0.5 	
//4 	
//2 	
//1 	1
//1 	

class Sum_of_n_Numbers
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input n(n>0): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(n));

        double sum = 0;
        double tempNumber = 0;
        for (int i = 1; i <= n; i++)
        {
//            Console.Write("n{0}= ",i);
            while (!double.TryParse(Console.ReadLine(), out tempNumber)) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(tempNumber));
            sum += tempNumber;
        }
        Console.WriteLine("sum = {0}",sum);
    }
}

