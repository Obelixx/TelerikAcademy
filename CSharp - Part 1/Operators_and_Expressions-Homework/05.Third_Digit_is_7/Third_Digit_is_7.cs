using System;

//Problem 5. Third Digit is 7?

//    Write an expression that checks for given integer if its third digit from right-to-left is 7.

//Examples:
//n 	Third digit 7?
//5 	false
//701 	true
//9703 	true
//877 	false
//777877 	false
//9999799 	true

class Third_Digit_is_7
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input integer:");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(n));
        }
        bool isIt7 = (n / 100) % 10 == 7;
        Console.WriteLine("Third digit of {0} is 7. This is {1}.", n , isIt7);

    }
}

