namespace lab18
{
    partial class Lab18
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
            array_length = new NumericUpDown();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            matrix_rows = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            matrix_cols = new NumericUpDown();
            label6 = new Label();
            s_column = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)array_length).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matrix_rows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matrix_cols).BeginInit();
            ((System.ComponentModel.ISupportInitialize)s_column).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Array";
            // 
            // array_length
            // 
            array_length.Location = new Point(72, 43);
            array_length.Name = "array_length";
            array_length.Size = new Size(150, 27);
            array_length.TabIndex = 1;
            array_length.ValueChanged += UpdateArray;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 74);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(210, 201);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 46);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "Rows";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(308, 74);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(309, 201);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = "";
            // 
            // matrix_rows
            // 
            matrix_rows.Location = new Point(368, 43);
            matrix_rows.Name = "matrix_rows";
            matrix_rows.Size = new Size(81, 27);
            matrix_rows.TabIndex = 5;
            matrix_rows.ValueChanged += UpdateMatrix;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 9);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 4;
            label4.Text = "Matrix";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 46);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 9;
            label5.Text = "Columns";
            // 
            // matrix_cols
            // 
            matrix_cols.Location = new Point(536, 43);
            matrix_cols.Name = "matrix_cols";
            matrix_cols.Size = new Size(81, 27);
            matrix_cols.TabIndex = 8;
            matrix_cols.ValueChanged += UpdateMatrix;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 9);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 11;
            label6.Text = "S column";
            // 
            // s_column
            // 
            s_column.Location = new Point(536, 6);
            s_column.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            s_column.Name = "s_column";
            s_column.Size = new Size(81, 27);
            s_column.TabIndex = 10;
            s_column.Value = new decimal(new int[] { 1, 0, 0, 0 });
            s_column.ValueChanged += UpdateMatrix;
            // 
            // Lab18
            // 
            ClientSize = new Size(692, 420);
            Controls.Add(label6);
            Controls.Add(s_column);
            Controls.Add(label5);
            Controls.Add(matrix_cols);
            Controls.Add(label3);
            Controls.Add(richTextBox2);
            Controls.Add(matrix_rows);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(array_length);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Lab18";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab18";
            ((System.ComponentModel.ISupportInitialize)array_length).EndInit();
            ((System.ComponentModel.ISupportInitialize)matrix_rows).EndInit();
            ((System.ComponentModel.ISupportInitialize)matrix_cols).EndInit();
            ((System.ComponentModel.ISupportInitialize)s_column).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown array_length;
        private RichTextBox richTextBox1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox2;
        private NumericUpDown matrix_rows;
        private Label label4;
        private Label label5;
        private NumericUpDown matrix_cols;
        private Label label6;
        private NumericUpDown s_column;
    }
}
