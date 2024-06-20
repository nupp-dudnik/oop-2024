namespace lab19
{
    partial class Lab19
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab19));
            original = new RichTextBox();
            repeating = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            word_removed = new RichTextBox();
            word_to_remove = new TextBox();
            SuspendLayout();
            // 
            // original
            // 
            original.Location = new Point(12, 12);
            original.Name = "original";
            original.Size = new Size(591, 183);
            original.TabIndex = 0;
            original.Text = resources.GetString("original.Text");
            original.TextChanged += UpdateText;
            // 
            // repeating
            // 
            repeating.Location = new Point(12, 232);
            repeating.Name = "repeating";
            repeating.ReadOnly = true;
            repeating.Size = new Size(199, 120);
            repeating.TabIndex = 1;
            repeating.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 209);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Repeating";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 209);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 4;
            label2.Text = "Remove word";
            // 
            // word_removed
            // 
            word_removed.Location = new Point(231, 232);
            word_removed.Name = "word_removed";
            word_removed.ReadOnly = true;
            word_removed.Size = new Size(372, 120);
            word_removed.TabIndex = 3;
            word_removed.Text = "";
            // 
            // word_to_remove
            // 
            word_to_remove.Location = new Point(338, 202);
            word_to_remove.Name = "word_to_remove";
            word_to_remove.Size = new Size(152, 27);
            word_to_remove.TabIndex = 5;
            word_to_remove.TextChanged += UpdateRemovedWord;
            // 
            // Lab19
            // 
            ClientSize = new Size(615, 364);
            Controls.Add(word_to_remove);
            Controls.Add(label2);
            Controls.Add(word_removed);
            Controls.Add(label1);
            Controls.Add(repeating);
            Controls.Add(original);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Lab19";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox original;
        private RichTextBox repeating;
        private Label label1;
        private Label label2;
        private RichTextBox word_removed;
        private TextBox word_to_remove;
    }
}
