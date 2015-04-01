namespace _1.Shapes.Models
{
    using System;

    abstract public class Shape
    {
        private double width;
        virtual public double Width
        {
            get { return width; }
            set { width = value; }
        }

        private double height;
        virtual public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.height = height;
        }

        //abstract public double CalculateSurface();
        virtual public double CalculateSurface() //this is better - because we can call base method (less writing) (less implementation) (override only in triangle)
        {
            return (this.Width * this.Height);
        }

        public override string ToString()
        {
            return ("Shape size: [" + Width.ToString() + ":" + Height.ToString() + "]");
        }
    }
}
