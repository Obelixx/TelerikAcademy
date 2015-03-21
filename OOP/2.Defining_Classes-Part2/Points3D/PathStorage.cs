namespace Points3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    static class PathStorage
    {

        public static void Save(Path path, string filePath = @"..\..\pathStorage.txt")
        {
            StreamWriter sw = new StreamWriter(filePath);
            for (int i = 0; i < path.Points.Count; i++)
            {
                sw.WriteLine(path.Points[i].X);
                sw.WriteLine(path.Points[i].Y);
                sw.WriteLine(path.Points[i].Z);
            }
            sw.Close();
        }
        public static Path Load(string filePath = @"..\..\pathStorage.txt")
        {
            var result = new Path();
            StreamReader sr = new StreamReader(filePath);
            while (true)
            {
                try
                {
                    int tempX = int.Parse(sr.ReadLine());
                    int tempY = int.Parse(sr.ReadLine());
                    int tempZ = int.Parse(sr.ReadLine());
                    result.Points.Add(new Point3D() { X = tempX, Y = tempY, Z = tempZ });
                }
                catch (Exception)
                {
                    break;
                }
            }
            sr.Close();
            return (result);
        }

    }
}
