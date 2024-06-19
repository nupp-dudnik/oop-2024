namespace lab16
{
    public partial class Lab16 : Form
    {

        private Vector3D vector_a = new();
        private Vector3D vector_b = new();

        public Lab16()
        {
            InitializeComponent();
        }

        private void HideResults()
        {
            label_result_a.Visible = false;
            label_result_b.Visible = false;
            label_result_c.Visible = false;
        }

        private static void ShowResult(Label label, string result)
        {
            label.Text = result;
            label.ForeColor = Color.Black;
            label.Visible = true;
        }

        private static void ShowError(Label label, string err)
        {
            label.Text = err;
            label.ForeColor = Color.Red;
            label.Visible = true;
        }

        private void DisplayVector(Vector3D vector)
        {
            ShowResult(label_result_a, $"x: {vector.x}");
            ShowResult(label_result_b, $"y: {vector.y}");
            ShowResult(label_result_c, $"z: {vector.z}");
        }

        private void UpdateVectors(object sender, EventArgs e)
        {
            vector_a = new Vector3D((double)vector_1_x.Value, (double)vector_1_y.Value, (double)vector_1_z.Value);
            vector_b = new Vector3D((double)vector_2_x.Value, (double)vector_2_y.Value, (double)vector_2_z.Value);
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            var result = vector_a.Add(vector_b);
            DisplayVector(result);
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            var result = vector_a.Subtract(vector_b);
            DisplayVector(result);
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            HideResults();
            var result = vector_a.DotProduct(vector_b);
            ShowResult(label_result_a, $"Dot product: {result}");
        }

        private void button_mag_Click(object sender, EventArgs e)
        {
            HideResults();
            var result_a = vector_a.Magnitude();
            var result_b = vector_b.Magnitude();
            ShowResult(label_result_a, $"Magnitude A: {result_a}");
            ShowResult(label_result_b, $"Magnitude B: {result_b}");
        }

        private void button_cos_Click(object sender, EventArgs e)
        {
            HideResults();
            try
            {
                var result = vector_a.CosineAngle(vector_b);
                ShowResult(label_result_a, $"Cosine angle: {result}");

            }
            catch (Exception ex)
            {
                ShowError(label_result_a, ex.Message);
            }
        }
    }
}
