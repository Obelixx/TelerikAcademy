public struct Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    private static readonly Point3D pointO = new Point3D { X = 0, Y = 0, Z = 0 };
    public static Point3D PointO
    {
        get { return Point3D.pointO; }
    }

    public override string ToString()
    {
        return ("{" + X + ";" + Y + ";" + Z + "}");
    }
}
