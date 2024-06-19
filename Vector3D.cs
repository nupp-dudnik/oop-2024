namespace lab16
{
    class Vector3D(double x, double y, double z)
    {
        public readonly double x = x;
        public readonly double y = y;
        public readonly double z = z;

        public Vector3D() : this(0, 0, 0) { }

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

}
