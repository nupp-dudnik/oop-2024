using System.Text;

namespace lab18
{
    public partial class Lab18 : Form
    {
        public Lab18()
        {
            InitializeComponent();
        }

        private void UpdateArray(object sender, EventArgs e)
        {
            var array = new RandomArray((int)array_length.Value);
            var positive = $"Total positives: {array.CountPositive()}";
            var sum = $"Sum of numbers after first zero: {array.SumAfterZero()}";
            var transformed = $"Transaformed array: {array.TransformArray()}";
            richTextBox1.Text = $"{positive}\n{sum}\n{transformed}\n\nOriginal: {array}";
        }

        private void UpdateMatrix(object sender, EventArgs e)
        {
            var matrix = new RandomMatrix((int)matrix_rows.Value, (int)matrix_cols.Value);
            var fifth = $"Every 5th row: ";
            var s = s_column.Value;
            var column = $"Elements from {s}th column: ";
            if (matrix_rows.Value > 4)
            {
                fifth += $"[\n\t{string.Join(",\n\t", matrix.OnlyFifthRow().Select(arr => $"[ {string.Join(", ", arr)} ]"))}\n]";
            }
            else
            {
                fifth += "Not enough rows";
            }
            if (matrix_cols.Value != 0 && matrix_cols.Value >= s)
            {
                column += $"[ {string.Join(", ", matrix.OnlySthColumn((int)s - 1))} ]";
            }
            else
            {
                column += "Not enough columns";
            }
            richTextBox2.Text = $"{fifth}\n{column}\n\n{matrix}";

        }
    }
}
