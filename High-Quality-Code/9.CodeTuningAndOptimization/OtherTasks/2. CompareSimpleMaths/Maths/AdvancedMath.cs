namespace Maths.ComparePerformance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AdvancedMath
    {
    //Write a program to compare the performance of:
    //    square root, natural logarithm, sinus
    //for the values:
    //    float, double and decimal
        public static float MySqrt(float a, float b) { return (float)Math.Sqrt(a); }
        public static double MySqrt(double a, double b) { return Math.Sqrt(a); }
        public static decimal MySqrt(decimal a, decimal b) { return (decimal)Math.Sqrt((double)a); }

        public static float MyLog(float a, float b) { return (float)Math.Log(a,b); }
        public static double MyLog(double a, double b) { return Math.Log(a, b); }
        public static decimal MyLog(decimal a, decimal b) { return (decimal)Math.Log((double)a, (double)b); }

        public static float MySin(float a, float b) { return (float)Math.Sin(a); }
        public static double MySin(double a, double b) { return Math.Sin(a); }
        public static decimal MySin(decimal a, decimal b) { return (decimal)Math.Sin((double)a); }
    }
}
