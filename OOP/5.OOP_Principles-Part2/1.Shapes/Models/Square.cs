namespace _1.Shapes.Models
{
    using System;

    public class Square : Shape
    {
        private double side;
        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        #region overriding Width and Height properties
        public override double Width
        {
            get { return side; }
            set { side = value; }
        }

        public override double Height
        {
            get { return side; }
            set { side = value; }
        }
        #endregion

        public Square(double side)
            : base(side, side) { }

        public override string ToString()
        {
            return ("Square size: [" + Width.ToString() + ":" + Height.ToString() + "]");
        }
    }
}
