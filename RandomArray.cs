namespace lab18
{
    internal class RandomArray
    {
        private double[] inner;

        public RandomArray(int length)
        {
            inner = new double[length];
            Generate();
        }

        private RandomArray(double[] array)
        {
            inner = array;
        }

        public void Generate()
        {
            var random = new Random();
            for (int i = 0; i < inner.Length; i++)
                inner[i] = random.Next(-20, 20);
        }

        public int CountPositive() => inner.Where(x => x > 0).Count();

        public double SumAfterZero() => inner.SkipWhile(x => x != 0).Sum();

        public RandomArray TransformArray() => new RandomArray(inner.OrderBy(x => !(x > 0 ? Math.Floor(x) <= 1 : Math.Ceiling(x) >= -1)).ToArray());

        public override string ToString()
        {
            return $"[ {string.Join(", ", inner)} ]";
        }
    }
}
