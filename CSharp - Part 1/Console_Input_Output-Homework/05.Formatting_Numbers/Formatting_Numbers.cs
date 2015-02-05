using System;

//Problem 5. Formatting Numbers

//    Write a program that reads 3 numbers:
//        integer a (0 <= a <= 500)
//        floating-point b
//        floating-point c
//    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//        The number a should be printed in hexadecimal, left aligned
//        Then the number a should be printed in binary form, padded with zeroes
//        The number b should be printed with 2 digits after the decimal point, right aligned
//        The number c should be printed with 3 digits after the decimal point, left aligned.

//Examples:
//a 	b 	c 	result
//254 	11.6 	0.5 	FE |0011111110| 11.60|0.500 |
//499 	-0.5559 	10000 	1F3 |0111110011| -0.56|10000.000 |
//0 	3 	-0.1234 	0 |0000000000| 3|-0.123 |

class Formatting_Numbers
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int a = 0;
        Console.Write("Input a (0 <= a <= 500): ");
        while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 500)
        {
            Console.WriteLine("Input {0} Number (0 <= a <= 500)!", Convert.GetTypeCode(a));
        }

        float b = 0;
        Console.Write("Input b: ");
        while (!float.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(b));
        }

        float c = 0;
        Console.Write("Input c: ");
        while (!float.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(c));
        }

        //Console.WriteLine(@"a 	b 	c 	result");
        Console.WriteLine("{0}|{1}|{2}|{3}|"
            ,a.ToString("x").PadRight(10).ToUpper()
            ,Convert.ToString(a,2).PadLeft(10,'0')
            ,b.ToString("0.00").PadLeft(10)
            ,c.ToString("0.000").PadRight(10));

    }
}

