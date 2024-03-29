using System.Text;

namespace lab15
{
    public partial class Lab15 : Form
    {
        public Lab15()
        {
            InitializeComponent();
        }

        private static double ConvertDouble(string value, RichTextBox result)
        {
            if (value.Length == 0)
            {
                DisplayError("Empty value provided!", result);
                throw new ArgumentException("Empty value provided");
            }
            try
            {
                return Convert.ToDouble(value);
            }
            catch
            {
                DisplayError($"Input value `{value}` is invalid! Provide a valid floating-point number", result);
                throw;
            }
        }

        private static int ConvertInt(string value, RichTextBox result)
        {
            if (value.Length == 0)
            {
                DisplayError("Empty value provided!", result);
                throw new ArgumentException("Empty value provided");
            }
            try
            {
                return Convert.ToInt32(value);
            }
            catch
            {
                DisplayError($"Input value `{value}` is invalid! Provide a valid integer", result);
                throw;
            }
        }

        private static List<int> ConvertArray(string value, RichTextBox result)
        {
            if (value.Length == 0)
            {
                DisplayError("Empty array provided!", result);
                throw new ArgumentException("Empty array provided");
            }
            try
            {
                var vals = value.Split(',');
                var list = new List<int>();
                foreach (var v in vals)
                {
                    list.Add(Convert.ToInt32(v));
                }
                return list;
            }
            catch
            {
                DisplayError($"Input value `{value}` is invalid! Provide a valid integer array separated by commas (1,2,3)", result);
                throw;
            }
        }

        private static void DisplayResult(string text, RichTextBox result)
        {
            result.ForeColor = Color.Black;
            result.Text = text;

        }

        private static void DisplayError(string err, RichTextBox result)
        {

            result.ForeColor = Color.Red;
            result.Text = err;
        }

        const string TASK_1_EXPR = "( 3 + e^(y - 1) ) / ( 1 - x^2 * | y - tg(x) | )";
        private void task_1_submit_Click(object sender, EventArgs e)
        {
            try
            {
                var result = task_1_result;

                var x_text = task_1_x.Text.Trim();
                var y_text = task_1_y.Text.Trim();
                var x = ConvertDouble(x_text, result);
                var y = ConvertDouble(y_text, result);
                double denom = 1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x));
                if (denom == 0.0)
                {
                    DisplayError("Denominator is zero. Division impossible.", result);
                    return;
                }
                double top = 3 + Math.Pow(Math.E, y - 1);
                double eval_result = top / denom;
                DisplayResult($"{TASK_1_EXPR} =\n{eval_result}", result);
            }
            catch { /* Handeled by ConvertDouble */ }
        }

        private void task_2_submit_Click(object sender, EventArgs e)
        {
            try
            {
                var result = task_2_result;

                var a_text = task_2_a.Text.Trim();
                var b_text = task_2_b.Text.Trim();
                var c_text = task_2_c.Text.Trim();
                var a = ConvertDouble(a_text, result);
                var b = ConvertDouble(b_text, result);
                var c = ConvertDouble(c_text, result);
                if (a + b <= c || a + c <= b || b + c <= a || a <= 0 || b <= 0 || c <= 0)
                {
                    DisplayError("Invalid triangle provided!", result);
                    return;
                }
                double angle_a = Math.Acos((b * b + c * c - a * a) / (2 * b * c));
                double angle_b = Math.Acos((a * a + c * c - b * b) / (2 * a * c));
                double angle_c = Math.Acos((a * a + b * b - c * c) / (2 * a * b));
                DisplayResult($"Radians:\nA: {angle_a:0.00};\nB: {angle_b:0.00};\nC: {angle_c:0.00}\n\n" +
                              $"Degrees:\nA: {angle_a * (180 / Math.PI):0.00};\nB: {angle_b * (180 / Math.PI):0.00};\nC: {angle_c * (180 / Math.PI):0.00}",
                              result
                );
            }
            catch { /* Handeled by ConvertDouble */ }
        }

        private void task_3_submit_Click(object sender, EventArgs e)
        {
            try
            {
                var result = task_3_result;

                var n_text = task_3_N.Text.Trim();
                var n = ConvertInt(n_text, result);
                DisplayResult($"{n % 2 == 0 && n > 9}".ToLower(), result);
            }
            catch { /* Handeled by ConvertInt */ }
        }

        private void task_4_submit_Click(object sender, EventArgs e)
        {
            try
            {
                var result = task_4_result;

                var price_text = task_4_price.Text.Trim();
                var money_text = task_4_money.Text.Trim();
                var price = ConvertDouble(price_text, result);
                var money = ConvertDouble(money_text, result);
                if (money == price)
                {
                    DisplayResult("Thank you", result);
                }
                else if (money > price)
                {
                    DisplayResult($"Take you change: {money - price:0.00} UAH", result);
                }
                else
                {
                    DisplayResult($"Not enough money paid.\nPlease add {price - money:0.00} UAH", result);
                }
            }
            catch { /* Handeled by ConvertDouble */ }
        }

        private void task_5_submit_Click(object sender, EventArgs e)
        {
            try
            {
                var result = task_5_result;

                if (result.Text.Contains("Calculating"))
                {
                    MessageBox.Show("Please wait!", "Calculating...");
                    return;
                }
                var n_text = task_5_n.Text.Trim();
                var n = ConvertInt(n_text, result);
                if (n < 1)
                {
                    DisplayResult("No perfect numbers", result);
                    return;
                }
                else if (n == 1)
                {
                    DisplayResult("Only one perfect numer: 1", result);
                    return;
                }
                DisplayResult("Calculating...", result);
                var thread = new Thread(() =>
                {
                    var list_result = new StringBuilder();
                    for (int i = 1; i < n; i++)
                    {
                        int sum = 1;

                        for (int j = 2; j <= Math.Sqrt(i); j++)
                        {
                            if (i % j == 0)
                            {
                                if (j == (i / j))
                                    sum += j;
                                else
                                    sum += (j + i / j);
                            }
                        }

                        if (sum == i)
                        {
                            if (list_result.Length != 0)
                            {
                                list_result.Append(", ");
                            }
                            list_result.Append($"{i}");
                        }
                        if (i % 1000 == 0)
                        {

                            result.Invoke(new Action(() =>
                            {
                                DisplayResult($"Calculating... {i}", result);
                            }));
                        }
                    }
                    result.Invoke(new Action(() => { DisplayResult($"List of perfect numbers: {list_result}", result); }));
                });
                thread.Start();
            }
            catch { /* Handeled by ConvertInt */ }
        }

        private void task_6_submit_Click(object sender, EventArgs e)
        {
            try
            {
                var result = task_6_result;

                var array_text = task_6_array.Text.Trim();
                var k_text = task_6_k.Text.Trim();
                var array = ConvertArray(array_text, result);
                var k = ConvertDouble(k_text, result);
                var filtered_array = new List<int>();
                foreach (var val in array)
                {
                    if (val % 10 == k)
                    {
                        filtered_array.Add(val);
                    }
                }
                DisplayResult($"Filtered array: {string.Join(", ", filtered_array)}", result);
            }
            catch { /* Handeled by ConvertDouble and ConvertArray */ }
        }

        private void task_7_submit_Click(object sender, EventArgs e)
        {
            try
            {
                var result = task_7_result;

                var text = task_7_text.Text.Trim();
                var clean_text = new string(text.AsEnumerable().Select(c => char.IsPunctuation(c) ? ' ' : c).ToArray());
                var words = clean_text?.Split(' ').Where(str => str.Length > 0).ToArray();
                if (words?.Length == 0)
                {
                    DisplayError("No words found!", result);
                    return;
                }
                var longest_index = 0;
                var shortest_index = 0;

                for (int i = 0; i < words?.Length; i++)
                {
                    if (words[i].Length > words[longest_index].Length)
                    {
                        longest_index = i;
                    }
                    if (words[i].Length < words[shortest_index].Length)
                    {
                        shortest_index = i;
                    }
                }

                DisplayResult($"Longest word: {words?[longest_index]}\nShortest word: {words?[shortest_index]}", result);
            }
            catch { /* Shouldn't panic */ }
        }
    }
}
