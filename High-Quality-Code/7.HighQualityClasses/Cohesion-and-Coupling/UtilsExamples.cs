namespace CohesionAndCoupling
{
    using System;
    using CohesionAndCoupling.Utils;
    using CohesionAndCoupling.Utils.Calculator;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileName.GetExtension("example"));
            Console.WriteLine(FileName.GetFileName("example.pdf"));
            Console.WriteLine(FileName.GetExtension("example.new.pdf"));

            Console.WriteLine(FileName.GetFileName("example"));
            Console.WriteLine(FileName.GetFileName("example.pdf"));
            Console.WriteLine(FileName.GetFileName("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", Distance.CalculateIn2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", Distance.CalculateIn3D(5, 2, -1, 3, -6, 4));

            Parallelepiped paralelepiped = new Parallelepiped(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", paralelepiped.Volume);
            Console.WriteLine("Diagonal XYZ = {0:f2}", paralelepiped.DiagonalXYZ);
            Console.WriteLine("Diagonal XY = {0:f2}", paralelepiped.DiagonalXY);
            Console.WriteLine("Diagonal XZ = {0:f2}", paralelepiped.DiagonalXZ);
            Console.WriteLine("Diagonal YZ = {0:f2}", paralelepiped.DiagonalYZ);
        }
    }
}
