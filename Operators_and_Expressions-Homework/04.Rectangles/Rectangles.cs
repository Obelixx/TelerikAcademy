using System;

//Problem 4. Rectangles

//    Write an expression that calculates rectangle’s perimeter and area by given width and height.

//Examples:
//width 	height 	perimeter 	area
//3 	4 	14 	12
//2.5 	3 	11 	7.5
//5 	5 	20 	25

class Rectangles
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double width = 0;
        Console.Write("Input width:");
        while (!double.TryParse(Console.ReadLine(), out width) && width == 0)
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(width));
        }
        double height = 0;
        Console.Write("Input height:");
        while (!double.TryParse(Console.ReadLine(), out height) && height == 0)
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(height));
        }

        double perimeter = width * 2 + height * 2;
        double area = width * height;

        Console.WriteLine("{0,-9} {1,-9} {2,-9} {3,-9}", "width", "height", "perimeter", "area");
        Console.WriteLine("{0,-9} {1,-9} {2,-9} {3,-9}", width, height, perimeter, area);

    }
}

