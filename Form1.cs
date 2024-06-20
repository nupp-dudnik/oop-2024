namespace lab20
{
    public partial class Lab20 : Form
    {
        public Lab20()
        {
            InitializeComponent();
        }

        private void UpdateQuadraticEquation(object sender, EventArgs e)
        {

            try
            {
                var roots = SolveQuadraticEquation((double)input_a.Value, (double)input_b.Value, (double)input_c.Value);
                result.Text = $"Equation roots: {string.Join(", ", roots)}";
            }
            catch (Exception ex)
            {
                result.Text = $"Failed solving the equation: {ex.Message}";
            }
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
    }
}
