namespace lab23
{
    public partial class Lab23 : Form
    {
        double a = 10;
        Graphics graphic;
        static SolidBrush font_brush = new(Color.Black);
        static Pen axis_pen = new(Color.Black, 1f);

        public Lab23()
        {
            InitializeComponent();
            graphic = canvas.CreateGraphics();
        }

        private void UpdateCanvas(object sender, EventArgs e)
        {
            graphic.Clear(Color.White);

            DrawAxis();

            a = (double)input_a.Value;
            DrawFnX(a);
            DrawFnY(a);
            graphic.Flush();
        }

        private void DrawAxis()
        {
            var y_start = new Point(canvas.Width / 2, 0);
            var y_end = new Point(canvas.Width / 2, canvas.Height);
            graphic.DrawLine(axis_pen, y_start, y_end);

            var x_start = new Point(0, canvas.Height / 2);
            var x_end = new Point(canvas.Width, canvas.Height / 2);
            graphic.DrawLine(axis_pen, x_start, x_end);

            Font font = new Font("Roboto", 14, FontStyle.Bold);

            var x_pos = new Point(canvas.Width - 30, canvas.Height / 2 + 30);
            var y_pos = new Point(canvas.Width / 2, 0);
            graphic.DrawString("X", font, font_brush, x_pos);
            graphic.DrawString("Y", font, font_brush, y_pos);
        }

        private void DrawFnX(double a)
        {
            double x_offset = canvas.Width / 2.0;
            double y_offset = canvas.Height / 2.0;

            for (double y = -canvas.Height / 2; y < canvas.Width / 2; y += 0.5)
            {
                var x = a * (y - Math.Sin(y));
                graphic.FillEllipse(Brushes.Red, (float)(x + x_offset), (float)(-y + y_offset), 5, 5);
            }
        }

        private void DrawFnY(double a)
        {
            double x_offset = canvas.Width / 2.0;
            double y_offset = canvas.Height / 2.0;

            for (double x = -canvas.Width / 2; x < canvas.Width / 2; x += 0.5)
            {
                var y = a * (x - Math.Cos(x));
                graphic.FillEllipse(Brushes.Green, (float)(x + x_offset), (float)(-y + y_offset), 5, 5);
            }
        }
    }
}
