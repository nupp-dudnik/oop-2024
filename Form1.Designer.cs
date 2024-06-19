namespace lab16
{
    partial class Lab16
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
            label_vector_1 = new Label();
            vector_1_x = new NumericUpDown();
            vector_1_y = new NumericUpDown();
            vector_1_z = new NumericUpDown();
            label_vector_1_x = new Label();
            label_vector_1_y = new Label();
            label_vector_1_z = new Label();
            label_vector_2_z = new Label();
            label_vector_2_y = new Label();
            label_vector_2_x = new Label();
            vector_2_z = new NumericUpDown();
            vector_2_y = new NumericUpDown();
            vector_2_x = new NumericUpDown();
            label_vector_2 = new Label();
            label_result = new Label();
            label_result_c = new Label();
            label_result_b = new Label();
            label_result_a = new Label();
            button_add = new Button();
            button_sub = new Button();
            button_dot = new Button();
            button_mag = new Button();
            button_cos = new Button();
            ((System.ComponentModel.ISupportInitialize)vector_1_x).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vector_1_y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vector_1_z).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vector_2_z).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vector_2_y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vector_2_x).BeginInit();
            SuspendLayout();
            // 
            // label_vector_1
            // 
            label_vector_1.AutoSize = true;
            label_vector_1.Location = new Point(21, 17);
            label_vector_1.Name = "label_vector_1";
            label_vector_1.Size = new Size(65, 20);
            label_vector_1.TabIndex = 0;
            label_vector_1.Text = "Vector A";
            // 
            // vector_1_x
            // 
            vector_1_x.Location = new Point(21, 40);
            vector_1_x.Name = "vector_1_x";
            vector_1_x.Size = new Size(83, 27);
            vector_1_x.TabIndex = 2;
            vector_1_x.ValueChanged += UpdateVectors;
            // 
            // vector_1_y
            // 
            vector_1_y.Location = new Point(110, 40);
            vector_1_y.Name = "vector_1_y";
            vector_1_y.Size = new Size(83, 27);
            vector_1_y.TabIndex = 3;
            vector_1_y.ValueChanged += UpdateVectors;
            // 
            // vector_1_z
            // 
            vector_1_z.Location = new Point(199, 40);
            vector_1_z.Name = "vector_1_z";
            vector_1_z.Size = new Size(83, 27);
            vector_1_z.TabIndex = 4;
            vector_1_z.ValueChanged += UpdateVectors;
            // 
            // label_vector_1_x
            // 
            label_vector_1_x.AutoSize = true;
            label_vector_1_x.Location = new Point(21, 70);
            label_vector_1_x.Name = "label_vector_1_x";
            label_vector_1_x.Size = new Size(16, 20);
            label_vector_1_x.TabIndex = 5;
            label_vector_1_x.Text = "x";
            // 
            // label_vector_1_y
            // 
            label_vector_1_y.AutoSize = true;
            label_vector_1_y.Location = new Point(110, 70);
            label_vector_1_y.Name = "label_vector_1_y";
            label_vector_1_y.Size = new Size(16, 20);
            label_vector_1_y.TabIndex = 6;
            label_vector_1_y.Text = "y";
            // 
            // label_vector_1_z
            // 
            label_vector_1_z.AutoSize = true;
            label_vector_1_z.Location = new Point(199, 70);
            label_vector_1_z.Name = "label_vector_1_z";
            label_vector_1_z.Size = new Size(16, 20);
            label_vector_1_z.TabIndex = 7;
            label_vector_1_z.Text = "z";
            // 
            // label_vector_2_z
            // 
            label_vector_2_z.AutoSize = true;
            label_vector_2_z.Location = new Point(492, 70);
            label_vector_2_z.Name = "label_vector_2_z";
            label_vector_2_z.Size = new Size(16, 20);
            label_vector_2_z.TabIndex = 14;
            label_vector_2_z.Text = "z";
            // 
            // label_vector_2_y
            // 
            label_vector_2_y.AutoSize = true;
            label_vector_2_y.Location = new Point(403, 70);
            label_vector_2_y.Name = "label_vector_2_y";
            label_vector_2_y.Size = new Size(16, 20);
            label_vector_2_y.TabIndex = 13;
            label_vector_2_y.Text = "y";
            // 
            // label_vector_2_x
            // 
            label_vector_2_x.AutoSize = true;
            label_vector_2_x.Location = new Point(314, 70);
            label_vector_2_x.Name = "label_vector_2_x";
            label_vector_2_x.Size = new Size(16, 20);
            label_vector_2_x.TabIndex = 12;
            label_vector_2_x.Text = "x";
            // 
            // vector_2_z
            // 
            vector_2_z.Location = new Point(492, 40);
            vector_2_z.Name = "vector_2_z";
            vector_2_z.Size = new Size(83, 27);
            vector_2_z.TabIndex = 11;
            vector_2_z.ValueChanged += UpdateVectors;
            // 
            // vector_2_y
            // 
            vector_2_y.Location = new Point(403, 40);
            vector_2_y.Name = "vector_2_y";
            vector_2_y.Size = new Size(83, 27);
            vector_2_y.TabIndex = 10;
            vector_2_y.ValueChanged += UpdateVectors;
            // 
            // vector_2_x
            // 
            vector_2_x.Location = new Point(314, 40);
            vector_2_x.Name = "vector_2_x";
            vector_2_x.Size = new Size(83, 27);
            vector_2_x.TabIndex = 9;
            vector_2_x.ValueChanged += UpdateVectors;
            // 
            // label_vector_2
            // 
            label_vector_2.AutoSize = true;
            label_vector_2.Location = new Point(314, 17);
            label_vector_2.Name = "label_vector_2";
            label_vector_2.Size = new Size(65, 20);
            label_vector_2.TabIndex = 8;
            label_vector_2.Text = "Vector A";
            // 
            // label_result
            // 
            label_result.AutoSize = true;
            label_result.Location = new Point(21, 210);
            label_result.Name = "label_result";
            label_result.Size = new Size(49, 20);
            label_result.TabIndex = 15;
            label_result.Text = "Result";
            // 
            // result_c
            // 
            label_result_c.AutoSize = true;
            label_result_c.Location = new Point(21, 270);
            label_result_c.Name = "result_c";
            label_result_c.Size = new Size(16, 20);
            label_result_c.TabIndex = 18;
            label_result_c.Text = "c";
            label_result_c.Visible = false;
            // 
            // result_b
            // 
            label_result_b.AutoSize = true;
            label_result_b.Location = new Point(21, 250);
            label_result_b.Name = "result_b";
            label_result_b.Size = new Size(18, 20);
            label_result_b.TabIndex = 17;
            label_result_b.Text = "b";
            label_result_b.Visible = false;
            // 
            // result_a
            // 
            label_result_a.AutoSize = true;
            label_result_a.Location = new Point(21, 230);
            label_result_a.Name = "result_a";
            label_result_a.Size = new Size(17, 20);
            label_result_a.TabIndex = 16;
            label_result_a.Text = "a";
            label_result_a.Visible = false;
            // 
            // button_add
            // 
            button_add.Location = new Point(21, 107);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 19;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_sub
            // 
            button_sub.Location = new Point(136, 107);
            button_sub.Name = "button_sub";
            button_sub.Size = new Size(94, 29);
            button_sub.TabIndex = 20;
            button_sub.Text = "Subtract";
            button_sub.UseVisualStyleBackColor = true;
            button_sub.Click += button_sub_Click;
            // 
            // button_dot
            // 
            button_dot.Location = new Point(251, 107);
            button_dot.Name = "button_dot";
            button_dot.Size = new Size(94, 29);
            button_dot.TabIndex = 21;
            button_dot.Text = "Dot";
            button_dot.UseVisualStyleBackColor = true;
            button_dot.Click += button_dot_Click;
            // 
            // button_mag
            // 
            button_mag.Location = new Point(366, 107);
            button_mag.Name = "button_mag";
            button_mag.Size = new Size(94, 29);
            button_mag.TabIndex = 22;
            button_mag.Text = "Magnitude";
            button_mag.UseVisualStyleBackColor = true;
            button_mag.Click += button_mag_Click;
            // 
            // button_cos
            // 
            button_cos.Location = new Point(481, 107);
            button_cos.Name = "button_cos";
            button_cos.Size = new Size(94, 29);
            button_cos.TabIndex = 23;
            button_cos.Text = "Angle";
            button_cos.UseVisualStyleBackColor = true;
            button_cos.Click += button_cos_Click;
            // 
            // Lab16
            // 
            ClientSize = new Size(592, 319);
            Controls.Add(button_cos);
            Controls.Add(button_mag);
            Controls.Add(button_dot);
            Controls.Add(button_sub);
            Controls.Add(button_add);
            Controls.Add(label_result_c);
            Controls.Add(label_result_b);
            Controls.Add(label_result_a);
            Controls.Add(label_result);
            Controls.Add(label_vector_2_z);
            Controls.Add(label_vector_2_y);
            Controls.Add(label_vector_2_x);
            Controls.Add(vector_2_z);
            Controls.Add(vector_2_y);
            Controls.Add(vector_2_x);
            Controls.Add(label_vector_2);
            Controls.Add(label_vector_1_z);
            Controls.Add(label_vector_1_y);
            Controls.Add(label_vector_1_x);
            Controls.Add(vector_1_z);
            Controls.Add(vector_1_y);
            Controls.Add(vector_1_x);
            Controls.Add(label_vector_1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Lab16";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab16";
            ((System.ComponentModel.ISupportInitialize)vector_1_x).EndInit();
            ((System.ComponentModel.ISupportInitialize)vector_1_y).EndInit();
            ((System.ComponentModel.ISupportInitialize)vector_1_z).EndInit();
            ((System.ComponentModel.ISupportInitialize)vector_2_z).EndInit();
            ((System.ComponentModel.ISupportInitialize)vector_2_y).EndInit();
            ((System.ComponentModel.ISupportInitialize)vector_2_x).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_vector_1;
        private Label label_vector_2;
        private Label label_result;
        private Label label_result_c;
        private Label label_result_b;
        private Label label_result_a;
        private NumericUpDown vector_1_x;
        private NumericUpDown vector_1_y;
        private NumericUpDown vector_1_z;
        private Label label_vector_1_x;
        private Label label_vector_1_y;
        private Label label_vector_1_z;
        private Label label_vector_2_x;
        private Label label_vector_2_y;
        private Label label_vector_2_z;
        private NumericUpDown vector_2_z;
        private NumericUpDown vector_2_y;
        private NumericUpDown vector_2_x;
        private Button button_add;
        private Button button_sub;
        private Button button_dot;
        private Button button_mag;
        private Button button_cos;
    }
}
