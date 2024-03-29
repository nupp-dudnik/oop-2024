var a = 1;
var b = -3;
var c = 2;

try
{
    var roots = SolveQuadraticEquation(a, b, c);
    Console.WriteLine($"Equation roots: {string.Join(", ", roots)}");
}
catch (Exception ex)
{
    Console.WriteLine($"Failed solving the equation: {ex.Message}");
}

static double[] SolveQuadraticEquation(double a, double b, double c)
{
    double discriminant = b * b - 4 * a * c;

    if (discriminant > 0)
    {
        var root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        var root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        return [root1, root2];
    }
    else if (discriminant == 0)
    {
        var root = -b / (2 * a);
        return [root];
    }
    else
    {
        throw new Exception("Equation doesn't have solutions");
    }
}
