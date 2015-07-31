namespace Maths.ComparePerformance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SimpleMaths
    {
        ////Write a program to compare the performance of:
        ////    add, subtract, increment, multiply, divide
        ////for the values:
        ////    int, long, float, double and decimal

        public static int Add(int a, int b) { return a + b; }
        public static long Add(long a, long b) { return a + b; }
        public static float Add(float a, float b) { return a + b; }
        public static double Add(double a, double b) { return a + b; }
        public static decimal Add(decimal a, decimal b) { return a + b; }
        public static int Subtract(int a, int b) { return a - b; }
        public static long Subtract(long a, long b) { return a - b; }
        public static float Subtract(float a, float b) { return a - b; }
        public static double Subtract(double a, double b) { return a - b; }
        public static decimal Subtract(decimal a, decimal b) { return a - b; }
        public static int Increment(int a, int b) { if (a < b) { while (a < b) a++; return a; } else { while (a > b) b++; return b; } }
        public static long Increment(long a, long b) { if (a < b) { while (a < b) a++; return a; } else { while (a > b) b++; return b; } }
        public static float Increment(float a, float b) { if (a < b) { while (a < b) a++; return a; } else { while (a > b) b++; return b; } }
        public static double Increment(double a, double b) { if (a < b) { while (a < b) a++; return a; } else { while (a > b) b++; return b; } }
        public static decimal Increment(decimal a, decimal b) { if (a < b) { while (a < b) a++; return a; } else { while (a > b) b++; return b; } }
        public static int Multiply(int a, int b) { return a * b; }
        public static long Multiply(long a, long b) { return a * b; }
        public static float Multiply(float a, float b) { return a * b; }
        public static double Multiply(double a, double b) { return a * b; }
        public static decimal Multiply(decimal a, decimal b) { return a * b; }
        public static int Divide(int a, int b) { return a / b; }
        public static long Divide(long a, long b) { return a / b; }
        public static float Divide(float a, float b) { return a / b; }
        public static double Divide(double a, double b) { return a / b; }
        public static decimal Divide(decimal a, decimal b) { return a / b; }


    }
}
