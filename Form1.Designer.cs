namespace lab15
{
    partial class Lab15
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
            label_right = new Label();
            right_a = new NumericUpDown();
            right_b = new NumericUpDown();
            label_right_a = new Label();
            label_right_b = new Label();
            label_iso_b = new Label();
            label_iso_a = new Label();
            iso_b = new NumericUpDown();
            iso_a = new NumericUpDown();
            label_iso = new Label();
            label_equ_a = new Label();
            equ_a = new NumericUpDown();
            label_equ = new Label();
            result_right_area = new Label();
            result_right_perimeter = new Label();
            result_iso_perimeter = new Label();
            result_iso_area = new Label();
            result_equ_perimeter = new Label();
            result_equ_area = new Label();
            ((System.ComponentModel.ISupportInitialize)right_a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)right_b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iso_b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iso_a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)equ_a).BeginInit();
            SuspendLayout();
            // 
            // label_right
            // 
            label_right.AutoSize = true;
            label_right.Location = new Point(15, 9);
            label_right.Name = "label_right";
            label_right.Size = new Size(44, 20);
            label_right.TabIndex = 0;
            label_right.Text = "Right";
            // 
            // right_a
            // 
            right_a.Location = new Point(38, 40);
            right_a.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            right_a.Name = "right_a";
            right_a.Size = new Size(99, 27);
            right_a.TabIndex = 1;
            right_a.ValueChanged += UpdateRight;
            // 
            // right_b
            // 
            right_b.Location = new Point(38, 74);
            right_b.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            right_b.Name = "right_b";
            right_b.Size = new Size(99, 27);
            right_b.TabIndex = 2;
            right_b.ValueChanged += UpdateRight;
            // 
            // label_right_a
            // 
            label_right_a.AutoSize = true;
            label_right_a.Location = new Point(15, 43);
            label_right_a.Name = "label_right_a";
            label_right_a.Size = new Size(17, 20);
            label_right_a.TabIndex = 3;
            label_right_a.Text = "a";
            // 
            // label_right_b
            // 
            label_right_b.AutoSize = true;
            label_right_b.Location = new Point(15, 77);
            label_right_b.Name = "label_right_b";
            label_right_b.Size = new Size(18, 20);
            label_right_b.TabIndex = 4;
            label_right_b.Text = "b";
            // 
            // label_iso_b
            // 
            label_iso_b.AutoSize = true;
            label_iso_b.Location = new Point(191, 77);
            label_iso_b.Name = "label_iso_b";
            label_iso_b.Size = new Size(18, 20);
            label_iso_b.TabIndex = 9;
            label_iso_b.Text = "b";
            // 
            // label_iso_a
            // 
            label_iso_a.AutoSize = true;
            label_iso_a.Location = new Point(191, 43);
            label_iso_a.Name = "label_iso_a";
            label_iso_a.Size = new Size(25, 20);
            label_iso_a.TabIndex = 8;
            label_iso_a.Text = "2a";
            // 
            // iso_b
            // 
            iso_b.Location = new Point(222, 75);
            iso_b.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            iso_b.Name = "iso_b";
            iso_b.Size = new Size(99, 27);
            iso_b.TabIndex = 7;
            iso_b.ValueChanged += UpdateIsosceles;
            // 
            // iso_a
            // 
            iso_a.Location = new Point(222, 41);
            iso_a.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            iso_a.Name = "iso_a";
            iso_a.Size = new Size(99, 27);
            iso_a.TabIndex = 6;
            iso_a.ValueChanged += UpdateIsosceles;
            // 
            // label_iso
            // 
            label_iso.AutoSize = true;
            label_iso.Location = new Point(191, 9);
            label_iso.Name = "label_iso";
            label_iso.Size = new Size(67, 20);
            label_iso.TabIndex = 5;
            label_iso.Text = "Isosceles";
            // 
            // label_equ_a
            // 
            label_equ_a.AutoSize = true;
            label_equ_a.Location = new Point(368, 43);
            label_equ_a.Name = "label_equ_a";
            label_equ_a.Size = new Size(17, 20);
            label_equ_a.TabIndex = 13;
            label_equ_a.Text = "a";
            // 
            // equ_a
            // 
            equ_a.Location = new Point(391, 40);
            equ_a.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            equ_a.Name = "equ_a";
            equ_a.Size = new Size(99, 27);
            equ_a.TabIndex = 11;
            equ_a.ValueChanged += UpdateEquilateral;
            // 
            // label_equ
            // 
            label_equ.AutoSize = true;
            label_equ.Location = new Point(368, 9);
            label_equ.Name = "label_equ";
            label_equ.Size = new Size(80, 20);
            label_equ.TabIndex = 10;
            label_equ.Text = "Equilateral";
            // 
            // result_right_area
            // 
            result_right_area.AutoSize = true;
            result_right_area.Location = new Point(15, 141);
            result_right_area.Name = "result_right_area";
            result_right_area.Size = new Size(40, 20);
            result_right_area.TabIndex = 14;
            result_right_area.Text = "Area";
            result_right_area.Visible = false;
            // 
            // result_right_perimeter
            // 
            result_right_perimeter.AutoSize = true;
            result_right_perimeter.Location = new Point(15, 170);
            result_right_perimeter.Name = "result_right_perimeter";
            result_right_perimeter.Size = new Size(72, 20);
            result_right_perimeter.TabIndex = 15;
            result_right_perimeter.Text = "Perimeter";
            result_right_perimeter.Visible = false;
            // 
            // result_iso_perimeter
            // 
            result_iso_perimeter.AutoSize = true;
            result_iso_perimeter.Location = new Point(191, 170);
            result_iso_perimeter.Name = "result_iso_perimeter";
            result_iso_perimeter.Size = new Size(72, 20);
            result_iso_perimeter.TabIndex = 17;
            result_iso_perimeter.Text = "Perimeter";
            result_iso_perimeter.Visible = false;
            // 
            // result_iso_area
            // 
            result_iso_area.AutoSize = true;
            result_iso_area.Location = new Point(191, 141);
            result_iso_area.Name = "result_iso_area";
            result_iso_area.Size = new Size(40, 20);
            result_iso_area.TabIndex = 16;
            result_iso_area.Text = "Area";
            result_iso_area.Visible = false;
            // 
            // result_equ_perimeter
            // 
            result_equ_perimeter.AutoSize = true;
            result_equ_perimeter.Location = new Point(368, 170);
            result_equ_perimeter.Name = "result_equ_perimeter";
            result_equ_perimeter.Size = new Size(72, 20);
            result_equ_perimeter.TabIndex = 19;
            result_equ_perimeter.Text = "Perimeter";
            result_equ_perimeter.Visible = false;
            // 
            // result_equ_area
            // 
            result_equ_area.AutoSize = true;
            result_equ_area.Location = new Point(368, 141);
            result_equ_area.Name = "result_equ_area";
            result_equ_area.Size = new Size(40, 20);
            result_equ_area.TabIndex = 18;
            result_equ_area.Text = "Area";
            result_equ_area.Visible = false;
            // 
            // Lab15
            // 
            ClientSize = new Size(522, 216);
            Controls.Add(result_equ_perimeter);
            Controls.Add(result_equ_area);
            Controls.Add(result_iso_perimeter);
            Controls.Add(result_iso_area);
            Controls.Add(result_right_perimeter);
            Controls.Add(result_right_area);
            Controls.Add(label_equ_a);
            Controls.Add(equ_a);
            Controls.Add(label_equ);
            Controls.Add(label_iso_b);
            Controls.Add(label_iso_a);
            Controls.Add(iso_b);
            Controls.Add(iso_a);
            Controls.Add(label_iso);
            Controls.Add(label_right_b);
            Controls.Add(label_right_a);
            Controls.Add(right_b);
            Controls.Add(right_a);
            Controls.Add(label_right);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Lab15";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab17";
            ((System.ComponentModel.ISupportInitialize)right_a).EndInit();
            ((System.ComponentModel.ISupportInitialize)right_b).EndInit();
            ((System.ComponentModel.ISupportInitialize)iso_b).EndInit();
            ((System.ComponentModel.ISupportInitialize)iso_a).EndInit();
            ((System.ComponentModel.ISupportInitialize)equ_a).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_right;
        private NumericUpDown right_a;
        private NumericUpDown right_b;
        private Label label_right_a;
        private Label label_right_b;
        private Label label_iso_b;
        private Label label_iso_a;
        private NumericUpDown iso_b;
        private NumericUpDown iso_a;
        private Label label_iso;
        private Label label_equ_a;
        private NumericUpDown equ_a;
        private Label label_equ;
        private Label result_right_area;
        private Label result_right_perimeter;
        private Label result_iso_perimeter;
        private Label result_iso_area;
        private Label result_equ_perimeter;
        private Label result_equ_area;
    }
}
