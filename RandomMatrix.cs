namespace lab18
{
    internal class RandomMatrix
    {
        private double[][] inner;

        public RandomMatrix(int rows, int cols)
        {
            inner = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                inner[i] = new double[cols];
            }
            Generate();
        }

        public void Generate()
        {
            var random = new Random();
            for (int i = 0; i < inner.Length; i++)
                for (int j = 0; j < inner[i].Length; j++)
                    inner[i][j] = random.Next(-20, 20);
        }

        public double[][] OnlyFifthRow() => inner.Where((arr, i) => (i + 1) % 5 == 0).ToArray();

        public double[] OnlySthColumn(int s) => inner.Select(arr => arr.Skip(s > inner.Length ? inner.Length - 1 : s).First()).ToArray();

        public override string ToString()
        {
            return $"[\n\t{string.Join(",\n\t", inner.Select(arr => $"[ {string.Join(", ", arr)} ]"))}\n]";
        }
    }
}
