using lab17.Triangles;

namespace lab17
{
    public partial class Lab17 : Form
    {
        public Lab17()
        {
            InitializeComponent();
        }

        private void ShowResult(Label area, Label perimeter, Triangle triangle)
        {
            area.Text = $"Area: {triangle.CalculateArea():.00}";
            perimeter.Text = $"Perimeter: {triangle.CalculatePerimeter():.00}";
            area.Visible = true;
            perimeter.Visible = true;
        }

        public void UpdateRight(object sender, EventArgs e)
        {
            var triangle = new RightTriangle((double)right_a.Value, (double)right_b.Value);
            ShowResult(result_right_area, result_right_perimeter, triangle);
        }

        public void UpdateIsosceles(object sender, EventArgs e)
        {
            var triangle = new IsoscelesTriangle((double)iso_a.Value, (double)iso_b.Value);
            ShowResult(result_iso_area, result_iso_perimeter, triangle);
        }

        public void UpdateEquilateral(object sender, EventArgs e)
        {
            var triangle = new EquilateralTriangle((double)equ_a.Value);
            ShowResult(result_equ_area, result_equ_perimeter, triangle);
        }
    }
}
