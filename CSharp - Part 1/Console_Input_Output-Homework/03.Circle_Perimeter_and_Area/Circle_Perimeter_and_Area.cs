using System;

//Problem 3. Circle Perimeter and Area

//    Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

//Examples:
//r 	perimeter 	area
//2 	12.57 	12.57
//3.5 	21.99 	38.48

class Circle_Perimeter_and_Area
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double r = 0;
        Console.Write("Input r:");
        while (!double.TryParse(Console.ReadLine(), out r))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(r));
        }

        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;
        Console.WriteLine("r\tperimeter\tarea");
        Console.WriteLine("{0}\t{1:0.00}\t\t{2:0.00}",r,perimeter,area);

    }
}

