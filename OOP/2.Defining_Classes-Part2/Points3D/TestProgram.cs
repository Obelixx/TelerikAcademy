namespace TestProgram_namespace
{
    using System;
    using Points3D;
    using GenericList;
    using Matrix;
    using CustomAttribute;

    [CustomAttribute.Version(1.22)]
    class TestProgram
    {
        static void Main(string[] args)
        {
            var pointO = Point3D.PointO;
            Console.WriteLine(pointO);
            var point1 = new Point3D();
            point1.X = 0;
            point1.Y = 0;
            point1.Z = 10;
            Console.WriteLine(point1);
            Console.WriteLine("Distance is: " + Point3DDistance.Distance(pointO, point1));

            var path = new Path();
            path.Points.Add(pointO);
            path.Points.Add(point1);

            //PathStorage.Save(path);
            //Console.WriteLine("Path saved in file!");

            Console.WriteLine(new string('-', 10));

            var path2 = PathStorage.Load();
            Console.WriteLine("Path loaded from file!");

            foreach (var point in path2.Points)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine(new string('-', 20));


            var gList = new GenericList<string>(10);
            gList.Add("1");
            gList.Add("2");
            Console.WriteLine("List: {0}", gList);

            gList.Add(gList[0] + gList[1]);
            Console.WriteLine("List: {0}", gList);

            gList.InsertAt("start", 0);
            Console.WriteLine("List: {0}", gList);

            gList.Remove(0);
            Console.WriteLine("List: {0}", gList);

            Console.WriteLine(new string('-', 10));


            gList.Add("asd");
            gList.Add("1asd");
            gList.Add("2asd");
            Console.WriteLine("List: {0}", gList);

            Console.WriteLine("Min: {0}", gList.Min());
            Console.WriteLine("Max: {0}", gList.Max());

            Console.WriteLine(new string('-', 10));

            gList.Clean();
            Console.WriteLine("List cleard!");
            Console.WriteLine("List: {0}", gList);

            //Console.WriteLine(gList[1]); //custom error msg in exeption, when accessing clear list

            Console.WriteLine(new string('-', 20));

            var matrixOne = new Matrix<decimal>(2, 3);
            matrixOne.FillMatrix(1);
            var matrixTwo = new Matrix<decimal>(2, 3);
            matrixTwo.FillMatrix(2);

            Console.WriteLine("Matrix one:");
            Console.WriteLine(matrixOne);
            Console.WriteLine("Matrix two:");
            Console.WriteLine(matrixTwo);

            var matrixResult = matrixOne + matrixTwo;
            Console.WriteLine("Matrix one + matrix two:");
            Console.WriteLine(matrixResult);

            matrixResult = matrixResult - matrixTwo;
            Console.WriteLine("Matrix one - matrix two:");
            Console.WriteLine(matrixResult);

            Console.WriteLine(new string('-', 10));

            matrixTwo = new Matrix<decimal>(3, 1);
            matrixTwo.FillMatrix(2);
            Console.WriteLine("Matrix one:");
            Console.WriteLine(matrixOne);
            Console.WriteLine("Matrix two:");
            Console.WriteLine(matrixTwo);

            matrixResult = matrixOne * matrixTwo;
            Console.WriteLine("Matrix one * matrix two:");
            Console.WriteLine(matrixResult);

            Console.WriteLine(new string('-', 10));


            matrixTwo.FillMatrix(0);
            Console.WriteLine("Matrix one:");
            Console.WriteLine(matrixOne);
            Console.WriteLine("Matrix two:");
            Console.WriteLine(matrixTwo);


            Console.WriteLine("Matrix one is:");
            Console.WriteLine(matrixOne.IsTrue);

            Console.WriteLine("Matrix two is:");
            Console.WriteLine(matrixTwo.IsTrue);

            //Console.WriteLine(matrixResult = matrixOne * matrixResult); //custom error msg in exeption, when the operation that cannot be performed..

            Console.WriteLine(new string('-', 20));


            System.Reflection.MemberInfo info = typeof(TestProgram);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }

        }
    }
}
