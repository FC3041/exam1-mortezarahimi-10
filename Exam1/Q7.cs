using System.Dynamic;

public interface IShape
{
    public double GetArea();
    public double GetPerimeter();
}


public class Q7Circle : IShape
{
    public double radius { get; set; }

    public Q7Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    { return Math.PI * radius * radius; }

    public double GetPerimeter()
    { return Math.PI * 2 * radius; }
}
public class Q7Rectangle : IShape
{
    public double width { get; set; }
    public double height { get; set; }

    public Q7Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double GetArea()
    { return width * height; }

    public double GetPerimeter()
    { return 2 * (width + height); }
}

public class ShapeUtils
{
    public static double Q7TotalArea(IShape[] shapes)
    {
        double sumArea = 0;
        foreach(var shape in shapes)
        {
            sumArea += shape.GetArea();
        }
        return sumArea;
    }
}