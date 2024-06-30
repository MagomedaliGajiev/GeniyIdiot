namespace GeniyIdiotWinFormsApp
{
    partial class WelcomeForm
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
            label1 = new Label();
            label2 = new Label();
            userNameTextBox = new TextBox();
            StartButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 52);
            label1.Name = "label1";
            label1.Size = new Size(309, 32);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать в игру!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 139);
            label2.Name = "label2";
            label2.Size = new Size(212, 32);
            label2.TabIndex = 1;
            label2.Text = "Введите свое имя";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(64, 212);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(403, 39);
            userNameTextBox.TabIndex = 2;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(64, 300);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(403, 46);
            StartButton.TabIndex = 3;
            StartButton.Text = "Начать";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(StartButton);
            Controls.Add(userNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox userNameTextBox;
        private Button StartButton;
    }
}