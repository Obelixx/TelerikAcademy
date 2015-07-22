namespace Methods
{
    using System;

    public class Methods
    {
        private enum PrintFormat
        {
            floatFormat, percentFormat, padedFormat
        }

        public static void Main()
        {
            Console.WriteLine("Area of Triangle (3,4,5) is: " + TriangleArea(3, 4, 5));

            Console.WriteLine("5 to digit: " + NumberToDigit(5));

            Console.WriteLine("Max between (5, -1, 3, 2, 14, 2, 3) is:" + FindMax(5, -1, 3, 2, 14, 2, 3));

            Console.WriteLine();

            Console.WriteLine("Print 1.3 as float:");
            PrintAsNumber(1.3, PrintFormat.floatFormat);
            Console.WriteLine("Print 0.75 as percent:");
            PrintAsNumber(0.75, PrintFormat.percentFormat);
            Console.WriteLine("Print 2.30 padded right:");
            PrintAsNumber(2.30, PrintFormat.padedFormat);

            Console.WriteLine();

            bool horizontal, vertical;
            Console.WriteLine("Distance between (3;-1) and (3;2.5) is: " + CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Console.WriteLine();

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov", Born = "17.03.1992" };
            peter.OtherInfo = "From Sofia";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova", Born = "03.11.1993" };
            stella.OtherInfo = "From Vidin, gamer, high results";

            Console.WriteLine(
                "{0} older than {1} -> {2}",
                peter.FirstName,
                stella.FirstName,
                peter.IsOlderThan(stella));
        }

        private static double TriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            return area;
        }

        private static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid digit!");
            }
        }

        private static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Elements can not be empty!");
            }

            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        private static void PrintAsNumber(double number, PrintFormat format)
        {
            switch (format)
            {
                case PrintFormat.floatFormat:
                    Console.WriteLine("{0:f2}", number);
                    break;
                case PrintFormat.percentFormat:
                    Console.WriteLine("{0:p0}", number);
                    break;
                case PrintFormat.padedFormat:
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new ArgumentException("Unknown format!");
            }
        }

        private static double CalcDistance(double x1, double y1, double x2, double y2, out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = y1 == y2;
            isVertical = x1 == x2;

            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }
    }
}
