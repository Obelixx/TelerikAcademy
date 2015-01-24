using System;

//Problem 3. Divide by 7 and 5

//    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

//Examples:
//n 	Divided by 7 and 5?
//3 	false
//0 	false
//5 	false
//7 	false
//35 	true
//140 	true

class Divide_by_7_and_5
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input number:");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(n));
        }
        bool isDivideable = false;
        if (n != 0) isDivideable = n % (7 * 5) == 0;
        Console.WriteLine("Saying {0} can be divided by 7 and 5 at the same time is: {1}", n , isDivideable);
    }
}
