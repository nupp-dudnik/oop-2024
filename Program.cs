
RightTriangle rightTriangle = new RightTriangle(4, 5);
Console.WriteLine($"Area of rigth triangle: {rightTriangle.CalculateArea()}");
Console.WriteLine($"Perimiter of right triangle: {rightTriangle.CalculatePerimeter()}");

IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(5, 6);
Console.WriteLine($"Area of isosceles triangle: {isoscelesTriangle.CalculateArea()}");
Console.WriteLine($"Perimeter of isosceles triangle: {isoscelesTriangle.CalculatePerimeter()}");

EquilateralTriangle equilateralTriangle = new EquilateralTriangle(7);
Console.WriteLine($"Area of equilateral triangle: {equilateralTriangle.CalculateArea()}");
Console.WriteLine($"Perimiter of equilateral triangle: {equilateralTriangle.CalculatePerimeter()}");

public abstract class Triangle(double a, double b, double angle)
{
    protected double a = a;
    protected double b = b;
    protected double angle = angle;

    public virtual double CalculateArea()
    {
        return 0.5 * a * b * Math.Sin(angle * Math.PI / 180);
    }

    public virtual double CalculatePerimeter()
    {
        return a + b + CalculateHypotenuse();
    }

    protected virtual double CalculateHypotenuse()
    {
        return Math.Sqrt(a * a + b * b);
    }
}

public class RightTriangle(double a, double b) : Triangle(a, b, 90)
{
    public override double CalculateArea()
    {
        return 0.5 * a * b;
    }
}

public class IsoscelesTriangle(double equalSide, double baseSide) : Triangle(equalSide, baseSide, CalculateAngle(equalSide, baseSide))
{
    private static double CalculateAngle(double equalSide, double baseSide)
    {
        return Math.Acos(baseSide / (2 * equalSide)) * (180 / Math.PI);
    }

    public override double CalculateArea()
    {
        return 0.25 * CalculatePerimeter() * CalculatePerimeter() / Math.Tan(angle * Math.PI / 180);
    }
}

public class EquilateralTriangle(double a) : Triangle(a, a, 60)
{
    public override double CalculateArea()
    {
        return (Math.Sqrt(3) / 4) * a * a;
    }
}
