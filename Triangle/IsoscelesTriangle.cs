namespace lab17.Triangle
{

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
}
