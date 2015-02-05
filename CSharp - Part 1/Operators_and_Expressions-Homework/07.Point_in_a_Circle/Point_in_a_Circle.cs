using System;

//Problem 7. Point in a Circle

//    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

//Examples:
//x 	y 	inside
//0 	1 	true
//-2 	0 	true
//-1 	2 	false
//1.5 	-1 	true
//-1.5 	-1.5 	false
//100 	-30 	false
//0 	0 	true
//0.2 	-0.8 	true
//0.9 	-1.93 	false
//1 	1.655 	true

class Point_in_a_Circle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double x = 0;
        Console.Write("Input x:");
        while (!double.TryParse(Console.ReadLine(), out x) && x == 0)
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(x));
        }
        double y = 0;
        Console.Write("Input y:");
        while (!double.TryParse(Console.ReadLine(), out y) && y == 0)
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(y));
        }

        double circleX = 0;
        double circleY = 0;
        double circleRadius = 2;

        bool isItInside = (x - circleX) * (x - circleX) + (y - circleY) * (y - circleY) <= circleRadius * circleRadius;

        Console.WriteLine("{0}\t{1}\t{2}","x","y","inside");
        Console.WriteLine("{0}\t{1}\t{2}", x,y,isItInside);
    }
}

