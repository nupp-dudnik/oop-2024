namespace lab29
{
    partial class Lab29
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
            input_name = new TextBox();
            input_multicast = new TextBox();
            label2 = new Label();
            button_disconnect = new Button();
            button_connect = new Button();
            chat_log = new RichTextBox();
            button_send = new Button();
            input_message = new RichTextBox();
            button_save_log = new Button();
            label3 = new Label();
            input_local_port = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // input_name
            // 
            input_name.Location = new Point(12, 32);
            input_name.Name = "input_name";
            input_name.Size = new Size(125, 27);
            input_name.TabIndex = 1;
            input_name.Text = "0x07C0";
            // 
            // input_multicast
            // 
            input_multicast.Location = new Point(143, 32);
            input_multicast.Name = "input_multicast";
            input_multicast.Size = new Size(125, 27);
            input_multicast.TabIndex = 2;
            input_multicast.Text = "235.1.1.1:6666";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 3;
            label2.Text = "Multicast:port";
            // 
            // button_disconnect
            // 
            button_disconnect.Enabled = false;
            button_disconnect.Location = new Point(503, 30);
            button_disconnect.Name = "button_disconnect";
            button_disconnect.Size = new Size(94, 29);
            button_disconnect.TabIndex = 4;
            button_disconnect.Text = "Disconnect";
            button_disconnect.UseVisualStyleBackColor = true;
            button_disconnect.Click += Disconnect;
            // 
            // button_connect
            // 
            button_connect.Location = new Point(403, 30);
            button_connect.Name = "button_connect";
            button_connect.Size = new Size(94, 29);
            button_connect.TabIndex = 5;
            button_connect.Text = "Connect";
            button_connect.UseVisualStyleBackColor = true;
            button_connect.Click += Connect;
            // 
            // chat_log
            // 
            chat_log.Location = new Point(12, 65);
            chat_log.Name = "chat_log";
            chat_log.ReadOnly = true;
            chat_log.Size = new Size(685, 332);
            chat_log.TabIndex = 6;
            chat_log.Text = "";
            // 
            // button_send
            // 
            button_send.Enabled = false;
            button_send.Location = new Point(666, 403);
            button_send.Name = "button_send";
            button_send.Size = new Size(31, 35);
            button_send.TabIndex = 7;
            button_send.Text = "S";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += SendMessage;
            // 
            // input_message
            // 
            input_message.Location = new Point(12, 403);
            input_message.Name = "input_message";
            input_message.Size = new Size(648, 35);
            input_message.TabIndex = 8;
            input_message.Text = "";
            // 
            // button_save_log
            // 
            button_save_log.Location = new Point(603, 30);
            button_save_log.Name = "button_save_log";
            button_save_log.Size = new Size(94, 29);
            button_save_log.TabIndex = 9;
            button_save_log.Text = "Save log";
            button_save_log.UseVisualStyleBackColor = true;
            button_save_log.Click += SaveLogs;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 9);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 11;
            label3.Text = "Local port";
            // 
            // input_local_port
            // 
            input_local_port.Location = new Point(272, 32);
            input_local_port.Name = "input_local_port";
            input_local_port.Size = new Size(125, 27);
            input_local_port.TabIndex = 10;
            input_local_port.Text = "6666";
            // 
            // Lab29
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 450);
            Controls.Add(label3);
            Controls.Add(input_local_port);
            Controls.Add(button_save_log);
            Controls.Add(input_message);
            Controls.Add(button_send);
            Controls.Add(chat_log);
            Controls.Add(button_connect);
            Controls.Add(button_disconnect);
            Controls.Add(label2);
            Controls.Add(input_multicast);
            Controls.Add(input_name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Lab29";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab29";
            FormClosing += Lab29_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input_name;
        private TextBox input_multicast;
        private Label label2;
        private Button button_disconnect;
        private Button button_connect;
        private RichTextBox chat_log;
        private Button button_send;
        private RichTextBox input_message;
        private Button button_save_log;
        private Label label3;
        private TextBox input_local_port;
    }
}
