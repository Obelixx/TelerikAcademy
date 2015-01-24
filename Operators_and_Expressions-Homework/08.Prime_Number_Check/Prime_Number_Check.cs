using System;

//Problem 8. Prime Number Check

//    Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//    Note: You should check if the number is positive

//Examples:
//n 	Prime?
//1 	false
//2 	true
//3 	true
//4 	false
//9 	false
//97 	true
//51 	false
//-3 	false
//0 	false

class Prime_Number_Check
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int n = 0;
        Console.Write("Input number between 1 and 100: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n > 100 || n < 0)
        {
            Console.WriteLine("Input {0} number between 1 and 100!", Convert.GetTypeCode(n));
        }

        bool isPrime = false;
        bool firstDivider = false;
        
        int i;
        for (i = 2; i < n; i++)
        {
            firstDivider = n % i == 0;
            if (firstDivider) break;
        }
        if (i == n) isPrime = true;

        Console.WriteLine("{0}\t{1}", "n", "Prime?");
        Console.WriteLine("{0}\t{1}", n, isPrime);
        //Console.WriteLine("check:{0}", i);

    }
}

