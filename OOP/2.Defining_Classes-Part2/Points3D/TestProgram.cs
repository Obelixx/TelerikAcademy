namespace TestProgram_namespace
{
    using System;
    using CustomeAttribute;
    using Points3D;

    [CustomeAttribute.Version(1.22)]
    class TestProgram
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo info = typeof(TestProgram);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }

            var pointO= Point3D.PointO;
            Console.WriteLine(pointO);
            var point1= new Point3D();
            point1.X=0;
            point1.Y=0;
            point1.Z=10;
            Console.WriteLine(point1);
            Console.WriteLine("Distance is: " +  Point3DDistance.Distance(pointO,point1));

            var path = new Path();
            path.Points.Add(pointO);
            path.Points.Add(point1);
            
            //PathStorage.Save(path);
            //Console.WriteLine("Path saved in file!");

            
            var path2 = PathStorage.Load();
            Console.WriteLine("Path loaded from file!");

            
            foreach (var point in path2.Points)
            {
                Console.WriteLine(point);
            }



        }
    }
}
