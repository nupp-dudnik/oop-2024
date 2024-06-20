namespace lab24
{
    partial class Lab24
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
            input_data = new RichTextBox();
            label2 = new Label();
            result_des = new RichTextBox();
            result_md2 = new RichTextBox();
            result_aes = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Input:";
            // 
            // input_data
            // 
            input_data.Location = new Point(12, 32);
            input_data.Name = "input_data";
            input_data.Size = new Size(822, 205);
            input_data.TabIndex = 1;
            input_data.Text = "";
            input_data.TextChanged += UpdateInput;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 240);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "DES";
            // 
            // result_des
            // 
            result_des.Location = new Point(12, 263);
            result_des.Name = "result_des";
            result_des.Size = new Size(256, 148);
            result_des.TabIndex = 3;
            result_des.Text = "";
            // 
            // result_md2
            // 
            result_md2.Location = new Point(295, 263);
            result_md2.Name = "result_md2";
            result_md2.Size = new Size(256, 148);
            result_md2.TabIndex = 4;
            result_md2.Text = "";
            // 
            // result_aes
            // 
            result_aes.Location = new Point(578, 263);
            result_aes.Name = "result_aes";
            result_aes.Size = new Size(256, 148);
            result_aes.TabIndex = 5;
            result_aes.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 240);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 6;
            label3.Text = "MD-2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(578, 240);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 7;
            label4.Text = "AES";
            // 
            // Lab24
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(result_aes);
            Controls.Add(result_md2);
            Controls.Add(result_des);
            Controls.Add(label2);
            Controls.Add(input_data);
            Controls.Add(label1);
            Name = "Lab24";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox input_data;
        private Label label2;
        private RichTextBox result_des;
        private RichTextBox result_md2;
        private RichTextBox result_aes;
        private Label label3;
        private Label label4;
    }
}
