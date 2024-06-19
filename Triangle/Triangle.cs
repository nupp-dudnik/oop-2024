namespace lab17.Triangle
{
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
}
