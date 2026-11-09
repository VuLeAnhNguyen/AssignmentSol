//Define an interface
public interface Geometry
{
    double Perimeter();//Chu vi
    double Area();
}
//
public class Circle : Geometry
{
    double radius;
    public Circle(double _radius)
    {
        radius = _radius;
    }
    public double Perimeter()
    {
        return radius * 2 * Math.PI;
    }
    public double Area()
    {
        return radius * radius * Math.PI;
    }
}

public class Triangle : Geometry
{
    double a, b, c;
    public Triangle(double _a, double _b, double _c)
    {
        a = _a;
        b = _b;
        c = _c;
    }
    public double Perimeter()
    {
        return a + b + c;
    }
    public double Area()
    {
        double semiPerimeter = Perimeter() / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

    }
}
class Program
{
    static void Main()
    {
        Triangle tamgiac1 = new Triangle(2, 4, 5.3);
        Console.WriteLine(tamgiac1.Area());
        Console.WriteLine(tamgiac1.Perimeter());
    }
}


    