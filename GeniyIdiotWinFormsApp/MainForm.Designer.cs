namespace GeniyIdiotWinFormsApp
{
    partial class MainForm
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
            nextButton = new Button();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            userAnswerTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            показатьПредыдущиеРеToolStripMenuItem = new ToolStripMenuItem();
            рестартToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            вопросыToolStripMenuItem = new ToolStripMenuItem();
            списокВсехВопросовToolStripMenuItem = new ToolStripMenuItem();
            добавитьНовыйВопросToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(25, 327);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(348, 125);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            questionNumberLabel.Location = new Point(25, 62);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(190, 45);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            questionTextLabel.Location = new Point(25, 138);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(230, 45);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(25, 252);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(399, 39);
            userAnswerTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1266, 42);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { показатьПредыдущиеРеToolStripMenuItem, рестартToolStripMenuItem, выходToolStripMenuItem, вопросыToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(90, 38);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // показатьПредыдущиеРеToolStripMenuItem
            // 
            показатьПредыдущиеРеToolStripMenuItem.Name = "показатьПредыдущиеРеToolStripMenuItem";
            показатьПредыдущиеРеToolStripMenuItem.Size = new Size(589, 44);
            показатьПредыдущиеРеToolStripMenuItem.Text = "Показать предыдущие результаты игры";
            показатьПредыдущиеРеToolStripMenuItem.Click += показатьПредыдущиеРеToolStripMenuItem_Click;
            // 
            // рестартToolStripMenuItem
            // 
            рестартToolStripMenuItem.Name = "рестартToolStripMenuItem";
            рестартToolStripMenuItem.Size = new Size(589, 44);
            рестартToolStripMenuItem.Text = "Рестарт";
            рестартToolStripMenuItem.Click += рестартToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(589, 44);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // вопросыToolStripMenuItem
            // 
            вопросыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { списокВсехВопросовToolStripMenuItem, добавитьНовыйВопросToolStripMenuItem, удалитьToolStripMenuItem });
            вопросыToolStripMenuItem.Name = "вопросыToolStripMenuItem";
            вопросыToolStripMenuItem.Size = new Size(589, 44);
            вопросыToolStripMenuItem.Text = "Вопросы";
            // 
            // списокВсехВопросовToolStripMenuItem
            // 
            списокВсехВопросовToolStripMenuItem.Name = "списокВсехВопросовToolStripMenuItem";
            списокВсехВопросовToolStripMenuItem.Size = new Size(497, 44);
            списокВсехВопросовToolStripMenuItem.Text = "Список всех вопросов";
            списокВсехВопросовToolStripMenuItem.Click += списокВсехВопросовToolStripMenuItem_Click;
            // 
            // добавитьНовыйВопросToolStripMenuItem
            // 
            добавитьНовыйВопросToolStripMenuItem.Name = "добавитьНовыйВопросToolStripMenuItem";
            добавитьНовыйВопросToolStripMenuItem.Size = new Size(497, 44);
            добавитьНовыйВопросToolStripMenuItem.Text = "Добавить новый вопрос";
            добавитьНовыйВопросToolStripMenuItem.Click += добавитьНовыйВопросToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(497, 44);
            удалитьToolStripMenuItem.Text = "Удалить существующий вапрос";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 525);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(nextButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Гений Идиот";
            Load += mainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private TextBox userAnswerTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem показатьПредыдущиеРеToolStripMenuItem;
        private ToolStripMenuItem рестартToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem вопросыToolStripMenuItem;
        private ToolStripMenuItem добавитьНовыйВопросToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem списокВсехВопросовToolStripMenuItem;
    }
}
