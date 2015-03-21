namespace Points3D
{
    using System;
    using System.Collections.Generic;

    class Path
    {
        private List<Point3D> points = new List<Point3D>();

        public List<Point3D> Points
        {
            get { return points; }
            set { points = value; }
        }
    }
}
