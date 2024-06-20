namespace lab23
{
    partial class Lab23
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            canvas = new PictureBox();
            input_a = new NumericUpDown();
            label_a = new Label();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_a).BeginInit();
            SuspendLayout();
            // 
            // canvas
            // 
            canvas.BackColor = Color.White;
            canvas.Location = new Point(0, 0);
            canvas.Margin = new Padding(3, 4, 3, 4);
            canvas.Name = "canvas";
            canvas.Size = new Size(891, 619);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            // 
            // input_a
            // 
            input_a.Location = new Point(52, 627);
            input_a.Margin = new Padding(3, 4, 3, 4);
            input_a.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            input_a.Name = "input_a";
            input_a.Size = new Size(120, 27);
            input_a.TabIndex = 2;
            input_a.Value = new decimal(new int[] { 10, 0, 0, 0 });
            input_a.ValueChanged += UpdateCanvas;
            // 
            // label_a
            // 
            label_a.AutoSize = true;
            label_a.Location = new Point(8, 630);
            label_a.Name = "label_a";
            label_a.Size = new Size(20, 20);
            label_a.TabIndex = 3;
            label_a.Text = "a:";
            // 
            // Lab23
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 670);
            Controls.Add(label_a);
            Controls.Add(input_a);
            Controls.Add(canvas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Lab23";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab23";
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_a).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private NumericUpDown input_a;
        private Label label_a;
    }
}
