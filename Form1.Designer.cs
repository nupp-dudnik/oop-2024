namespace lab20
{
    partial class Lab20
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
            label1 = new Label();
            input_a = new NumericUpDown();
            input_b = new NumericUpDown();
            label2 = new Label();
            input_c = new NumericUpDown();
            label3 = new Label();
            result = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)input_a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_c).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 0;
            label1.Text = "a";
            // 
            // input_a
            // 
            input_a.Location = new Point(12, 32);
            input_a.Name = "input_a";
            input_a.Size = new Size(91, 27);
            input_a.TabIndex = 1;
            input_a.ValueChanged += UpdateQuadraticEquation;
            // 
            // input_b
            // 
            input_b.Location = new Point(132, 32);
            input_b.Name = "input_b";
            input_b.Size = new Size(91, 27);
            input_b.TabIndex = 3;
            input_b.ValueChanged += UpdateQuadraticEquation;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 9);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 2;
            label2.Text = "b";
            // 
            // input_c
            // 
            input_c.Location = new Point(252, 32);
            input_c.Name = "input_c";
            input_c.Size = new Size(91, 27);
            input_c.TabIndex = 5;
            input_c.ValueChanged += UpdateQuadraticEquation;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 9);
            label3.Name = "label3";
            label3.Size = new Size(16, 20);
            label3.TabIndex = 4;
            label3.Text = "c";
            // 
            // result
            // 
            result.Location = new Point(12, 91);
            result.Name = "result";
            result.Size = new Size(331, 128);
            result.TabIndex = 6;
            result.Text = "";
            // 
            // Lab20
            // 
            ClientSize = new Size(359, 257);
            Controls.Add(result);
            Controls.Add(input_c);
            Controls.Add(label3);
            Controls.Add(input_b);
            Controls.Add(label2);
            Controls.Add(input_a);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Lab20";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab20";
            ((System.ComponentModel.ISupportInitialize)input_a).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_b).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_c).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown input_a;
        private NumericUpDown input_b;
        private Label label2;
        private NumericUpDown input_c;
        private Label label3;
        private RichTextBox result;
    }
}
