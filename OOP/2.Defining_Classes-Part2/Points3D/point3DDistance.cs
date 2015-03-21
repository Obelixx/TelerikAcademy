namespace Points3D
{
    using System;

    static class Point3DDistance
    {
        public static double Distance(Point3D a, Point3D b)
        {
            //        −−−−−−−−−−−−−−−−−−−−−−−−−−−−
            //|P1P2|=√(x2−x1)^2+(y2−y1)^2+(z2−z1)^2
            return (Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2)));
        }

    }
}
