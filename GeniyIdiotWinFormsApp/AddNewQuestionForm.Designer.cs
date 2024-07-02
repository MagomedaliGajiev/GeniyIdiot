namespace GeniyIdiotWinFormsApp
{
    partial class AddNewQuestionForm
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
            questionTextLabel = new Label();
            questionAnswerLabel = new Label();
            questionTextTextBox = new TextBox();
            questionAnswerTextBox = new TextBox();
            AddButton = new Button();
            SuspendLayout();
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionTextLabel.Location = new Point(64, 57);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(240, 45);
            questionTextLabel.TabIndex = 0;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // questionAnswerLabel
            // 
            questionAnswerLabel.AutoSize = true;
            questionAnswerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionAnswerLabel.Location = new Point(64, 132);
            questionAnswerLabel.Name = "questionAnswerLabel";
            questionAnswerLabel.Size = new Size(279, 45);
            questionAnswerLabel.TabIndex = 1;
            questionAnswerLabel.Text = "Ответ на вопрос";
            // 
            // questionTextTextBox
            // 
            questionTextTextBox.Location = new Point(366, 64);
            questionTextTextBox.Name = "questionTextTextBox";
            questionTextTextBox.Size = new Size(731, 39);
            questionTextTextBox.TabIndex = 2;
            // 
            // questionAnswerTextBox
            // 
            questionAnswerTextBox.Location = new Point(366, 132);
            questionAnswerTextBox.Name = "questionAnswerTextBox";
            questionAnswerTextBox.Size = new Size(731, 39);
            questionAnswerTextBox.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(286, 242);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(502, 70);
            AddButton.TabIndex = 4;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AddNewQuestionForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 361);
            Controls.Add(AddButton);
            Controls.Add(questionAnswerTextBox);
            Controls.Add(questionTextTextBox);
            Controls.Add(questionAnswerLabel);
            Controls.Add(questionTextLabel);
            Name = "AddNewQuestionForm";
            Text = "AddNewQuestionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionTextLabel;
        private Label questionAnswerLabel;
        private TextBox questionTextTextBox;
        private TextBox questionAnswerTextBox;
        private Button AddButton;
    }
}