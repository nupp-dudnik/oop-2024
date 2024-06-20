using System.Text;

namespace lab19
{
    public partial class Lab19 : Form
    {
        public Lab19()
        {
            InitializeComponent();
        }

        private void UpdateText(object sender, EventArgs e)
        {
            var repeating_words = string.Join("", original.Text.Select(c => char.IsPunctuation(c) ? ' ' : c)).Split(' ').Where(s => s.Length > 0)
                .GroupBy(w => w).Where(o => o.Count() > 1).ToDictionary(x => x.Key, y => y.Count());
            repeating.Text = $"Repeating words:\n - {string.Join("\n - ", repeating_words.Select(rw => $"`{rw.Key}` repeats {rw.Value} times"))}";
            if (word_to_remove.Text.Length > 0)
                word_removed.Text = original.Text.Replace($" {word_to_remove.Text}", "");
        }

        private void UpdateRemovedWord(object sender, EventArgs e)
        {
            if (word_to_remove.Text.Length > 0)
                word_removed.Text = original.Text.Replace($" {word_to_remove.Text}", "");
        }
    }
}
