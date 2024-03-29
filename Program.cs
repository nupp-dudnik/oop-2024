Vector3D vector1 = new(2, 3, 4);
Vector3D vector2 = new(1, -1, 2);

Vector3D sumVector = vector1.Add(vector2);
Console.WriteLine($"Vector sum: {sumVector}");

Vector3D diffVector = vector1.Subtract(vector2);
Console.WriteLine($"Vector difference: {diffVector}");

double dotProduct = vector1.DotProduct(vector2);
Console.WriteLine($"Vector dot product: {dotProduct}");

double magnitude = vector1.Magnitude();
Console.WriteLine($"Vector magnitude: {magnitude}");

double cosAngle = vector1.CosineAngle(vector2);
Console.WriteLine($"Vector cos angle: {cosAngle}");

class Vector3D(double x, double y, double z)
{
    private readonly double x = x;
    private readonly double y = y;
    private readonly double z = z;

    public Vector3D Add(Vector3D other)
    {
        double newX = x + other.x;
        double newY = y + other.y;
        double newZ = z + other.z;
        return new Vector3D(newX, newY, newZ);
    }

    public Vector3D Subtract(Vector3D other)
    {
        double newX = x - other.x;
        double newY = y - other.y;
        double newZ = z - other.z;
        return new Vector3D(newX, newY, newZ);
    }

    public double DotProduct(Vector3D other)
    {
        return (x * other.x) + (y * other.y) + (z * other.z);
    }

    public double Magnitude()
    {
        return Math.Sqrt((x * x) + (y * y) + (z * z));
    }

    public double CosineAngle(Vector3D other)
    {
        double dotProduct = DotProduct(other);
        double magnitudeProduct = Magnitude() * other.Magnitude();

        if (magnitudeProduct == 0)
        {
            throw new DivideByZeroException("Magnitude of one or both vectors is zero.");
        }

        return dotProduct / magnitudeProduct;
    }

    public override string ToString()
    {
        return $"({x}, {y}, {z})";
    }
}
