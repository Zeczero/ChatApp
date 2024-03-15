namespace Client
{
    partial class Form1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LoginBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            msg = new TextBox();
            snd = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            UsernamePrivate = new TextBox();
            ChatBoxPrivate = new ListBox();
            label4 = new Label();
            PrivateMessage = new TextBox();
            PrivateMsgSend = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(175, 27);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 23);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 44);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // msg
            // 
            msg.Location = new Point(12, 317);
            msg.Name = "msg";
            msg.Size = new Size(218, 23);
            msg.TabIndex = 6;
            // 
            // snd
            // 
            snd.Location = new Point(236, 317);
            snd.Name = "snd";
            snd.Size = new Size(75, 23);
            snd.TabIndex = 7;
            snd.Text = "button1";
            snd.UseVisualStyleBackColor = true;
            snd.Click += snd_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 146);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(208, 154);
            listBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 12);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 9;
            label3.Text = "Private Messaging";
            // 
            // UsernamePrivate
            // 
            UsernamePrivate.Location = new Point(538, 36);
            UsernamePrivate.Name = "UsernamePrivate";
            UsernamePrivate.Size = new Size(100, 23);
            UsernamePrivate.TabIndex = 10;
            // 
            // ChatBoxPrivate
            // 
            ChatBoxPrivate.FormattingEnabled = true;
            ChatBoxPrivate.ItemHeight = 15;
            ChatBoxPrivate.Location = new Point(491, 83);
            ChatBoxPrivate.Name = "ChatBoxPrivate";
            ChatBoxPrivate.Size = new Size(208, 154);
            ChatBoxPrivate.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 39);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 12;
            label4.Text = "Username";
            // 
            // PrivateMessage
            // 
            PrivateMessage.Location = new Point(491, 243);
            PrivateMessage.Name = "PrivateMessage";
            PrivateMessage.Size = new Size(218, 23);
            PrivateMessage.TabIndex = 13;
            // 
            // PrivateMsgSend
            // 
            PrivateMsgSend.Location = new Point(715, 243);
            PrivateMsgSend.Name = "PrivateMsgSend";
            PrivateMsgSend.Size = new Size(75, 23);
            PrivateMsgSend.TabIndex = 14;
            PrivateMsgSend.Text = "Send";
            PrivateMsgSend.UseVisualStyleBackColor = true;
            PrivateMsgSend.Click += PrivateMsgSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PrivateMsgSend);
            Controls.Add(PrivateMessage);
            Controls.Add(label4);
            Controls.Add(ChatBoxPrivate);
            Controls.Add(UsernamePrivate);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(snd);
            Controls.Add(msg);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button LoginBtn;
        private Label label1;
        private Label label2;
        private TextBox msg;
        private Button snd;
        private ListBox listBox1;
        private Label label3;
        private TextBox UsernamePrivate;
        private ListBox ChatBoxPrivate;
        private Label label4;
        private TextBox PrivateMessage;
        private Button PrivateMsgSend;
    }
}
