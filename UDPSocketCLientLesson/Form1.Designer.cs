namespace UDPSocketCLientLesson
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
            sendingBox = new TextBox();
            label1 = new Label();
            answerBox = new TextBox();
            label2 = new Label();
            SendButton = new Button();
            button1_click = new Button();
            SuspendLayout();
            // 
            // sendingBox
            // 
            sendingBox.Location = new Point(72, 69);
            sendingBox.Name = "sendingBox";
            sendingBox.Size = new Size(272, 27);
            sendingBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 34);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 1;
            label1.Text = "Sending box";
            label1.Click += label1_Click;
            // 
            // answerBox
            // 
            answerBox.Location = new Point(72, 148);
            answerBox.Name = "answerBox";
            answerBox.Size = new Size(272, 27);
            answerBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 114);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Answer box";
            // 
            // SendButton
            // 
            SendButton.Location = new Point(72, 211);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(94, 29);
            SendButton.TabIndex = 4;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // SendAsync
            // 
            button1_click.Location = new Point(72, 255);
            button1_click.Name = "SendAsync";
            button1_click.Size = new Size(94, 29);
            button1_click.TabIndex = 5;
            button1_click.Text = "Send Async";
            button1_click.UseVisualStyleBackColor = true;
            button1_click.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 450);
            Controls.Add(button1_click);
            Controls.Add(SendButton);
            Controls.Add(label2);
            Controls.Add(answerBox);
            Controls.Add(label1);
            Controls.Add(sendingBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sendingBox;
        private Label label1;
        private TextBox answerBox;
        private Label label2;
        private Button SendButton;
        private Button button1_click;
    }
}
