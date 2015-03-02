
//Problem 4. Triangle surface

//    Write methods that calculate the surface of a triangle by given:
//        Side and an altitude to it;
//        Three sides;
//        Two sides and an angle between them;
//    Use System.Math.

namespace _04.Triangle_surface
{
    using System;
    


    class Triangle_surface
    {
        static double TriangleSurface(double side, double attitudeToIt)
        {
            return ((side * attitudeToIt) / 2);
        }
        static double TriangleSurface(double sideA, double sideB, double sideC)
        {
            // A = koren(p(p-a)(p-b)(p-c))
            // p = (a+b+c)/2
            double p = (sideA + sideB + sideC) / 2;
            return (Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)));
        }
        static double TriangleSurface(double sideA, double sideB, int angleInDegrees) //Gegree meand graduses!
        {
             // c^2 = a^2 + b^2 + 2ab cos(C)
            double angleInRadians = angleInDegrees * Math.PI/180;
            double sideC = Math.Sqrt(sideA * sideA + sideB*sideB + 2*sideA*sideB*(Math.Cos(angleInRadians)));
            return (TriangleSurface(sideA,sideB,sideC));
        }

        static void Main()
        {
            Console.WriteLine("1. side=3  ;           attitudeToIt=4              : area = {0}", TriangleSurface(3d,4d));
            Console.WriteLine("2. sideA=3 ; sideB=4 ; sideC=5                     : area = {0}", TriangleSurface(3d, 4d, 5d));
            Console.WriteLine("3. sideA=3 ; sideB=4 ; angleInDegree/(graduses)=90 : area = {0}", TriangleSurface(3d, 4d, 90));
        }
    }
}
