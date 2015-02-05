using System;

//Problem 10. Odd and Even Product

//    You are given n integers (given in a single line, separated by a space).
//    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

//Examples:
//numbers 	result
//2 1 1 6 3 	yes
//product = 6 	

//3 10 4 6 5 1 	yes
//product = 60 	

//4 3 2 5 2 	no
//odd_product = 16 	
//even_product = 15 	

class Odd_and_Even_Product
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        
        
        string inputString = string.Empty;
        while (inputString == null || inputString == string.Empty)
        {
            Console.Write("Input numbers: ");
            inputString = Console.ReadLine();
        }


        string[] numbersString = inputString.Split(' ');
        int[] numbers = new int[numbersString.Length];
        try //check for errors in inportation
        {
            for (int i_import = 0; i_import < numbersString.Length; i_import++)
            {
                numbers[i_import] = int.Parse(numbersString[i_import]);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid string!");
            return; //stop if string is invalid
        }

        ulong odd_product = 1;
        ulong even_product = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0) //0 odd , 1 even
            {
                odd_product *= (ulong)numbers[i];
            }
            else 
            {
                even_product *= (ulong)numbers[i];
            }
        }

        if (odd_product==even_product)
        {
            Console.WriteLine("Yes!");
            Console.WriteLine("product = {0}",odd_product);
        }
        else 
        {
            Console.WriteLine("No!");
            Console.WriteLine("odd_product = {0}", odd_product);
            Console.WriteLine("even_product = {0}", even_product);
        }
    }
}

