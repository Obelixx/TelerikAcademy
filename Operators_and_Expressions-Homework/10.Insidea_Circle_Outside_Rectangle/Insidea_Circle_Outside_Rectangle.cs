using System;


//Problem 10. Point Inside a Circle & Outside of a Rectangle

//    Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

//Examples:
//x 	y 	inside K & outside of R
//1 	2 	yes
//2.5 	2 	no
//0 	1 	no
//2.5 	1 	no
//2 	0 	no
//4 	0 	no
//2.5 	1.5 	no
//2 	1.5 	yes
//1 	2.5 	yes
//-100 	-100 	no

class Insidea_Circle_Outside_Rectangle
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

        float circleX = 1;
        float circleY = 1;
        float circleRadius = 1.5f;

        bool isInCircle = (x - circleX) * (x - circleX) + (y - circleY) * (y - circleY) <= circleRadius * circleRadius;

        //int rectangleTop = 1; //y
        //int rectangleLeft = -1; //x
        //int rectangleWidth = 6; // 6iro4ina
        //int rectangleHeight = 2; // viso4ina

        //int[] rectangleX = new int[4] { rectangleTop, rectangleTop + rectangleHeight, rectangleTop + rectangleHeight, rectangleTop };
        //int[] rectangleY = new int[4] { rectangleLeft, rectangleLeft, rectangleLeft + rectangleWidth, rectangleLeft + rectangleWidth };

        bool isOutRectangle = false;
        if (y > 1) isOutRectangle = true; //this is just for this task :/ Too long to do it for any rectangle..

        bool allConditions = isInCircle && isOutRectangle;

        Console.WriteLine("{0}\t{1}\t{2}", "x", "y", "inside K & outside of R");
        Console.WriteLine("{0}\t{1}\t{2}", x, y, allConditions ? "Yes" : "No");
    }
}

