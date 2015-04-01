namespace _1.Shapes.Models
{
    using System;

    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height) { }

        public override string ToString()
        {
            return ("Rectangle size: [" + Width.ToString() + ":" + Height.ToString() + "]");
        }
    }
}
