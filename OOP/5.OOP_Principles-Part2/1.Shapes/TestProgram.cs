namespace _1.Shapes
{
    using System;
    using System.Collections.Generic;

    using Shapes.Models;

    class TestProgram
    {
        static void Main()
        {
            var shapes = new List<Shape>();
            shapes.Add(new Square(4));
            shapes.Add(new Square(2));
            shapes.Add(new Rectangle(4, 2));
            shapes.Add(new Triangle(4, 2));
            foreach (Shape shape in shapes)
            {
                Console.Write(shape);
                Console.WriteLine("Surface: " + shape.CalculateSurface());
            }

            Console.WriteLine(new string('-', 20));

            shapes[0].Height = 1;
            Console.Write(shapes[0]);
            Console.WriteLine("Surface: " + shapes[0].CalculateSurface());

            shapes[0].Width = 2;
            Console.Write(shapes[0]);
            Console.WriteLine("Surface: " + shapes[0].CalculateSurface());

            Console.WriteLine(new string('-', 20));

            #region We cant do this(one by one):
            //Shape newShape = new Shape(2,2);

            Shape newShape = new Square(2);
            //var squareAsRectangle = (Rectangle)(Shape)newShape;
            //var squareAsTriangle = (Triangle)newShape;
            #endregion

        }
    }
}
