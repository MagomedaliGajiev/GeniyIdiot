namespace GeniyIdiotWinFormsApp
{
    partial class QuestionListForm
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
            questionsDataGridView = new DataGridView();
            QuestionTextColumn = new DataGridViewTextBoxColumn();
            QuestionAnswerColumn = new DataGridViewTextBoxColumn();
            removeQuestionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { QuestionTextColumn, QuestionAnswerColumn });
            questionsDataGridView.Location = new Point(12, 92);
            questionsDataGridView.MultiSelect = false;
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.RowHeadersWidth = 82;
            questionsDataGridView.Size = new Size(1297, 696);
            questionsDataGridView.TabIndex = 0;
            // 
            // QuestionTextColumn
            // 
            QuestionTextColumn.HeaderText = "Текст";
            QuestionTextColumn.MinimumWidth = 10;
            QuestionTextColumn.Name = "QuestionTextColumn";
            QuestionTextColumn.Width = 118;
            // 
            // QuestionAnswerColumn
            // 
            QuestionAnswerColumn.HeaderText = "Ответ";
            QuestionAnswerColumn.MinimumWidth = 10;
            QuestionAnswerColumn.Name = "QuestionAnswerColumn";
            QuestionAnswerColumn.Width = 123;
            // 
            // removeQuestionButton
            // 
            removeQuestionButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            removeQuestionButton.Location = new Point(1082, 12);
            removeQuestionButton.Name = "removeQuestionButton";
            removeQuestionButton.Size = new Size(213, 58);
            removeQuestionButton.TabIndex = 1;
            removeQuestionButton.Text = "Удалить";
            removeQuestionButton.UseVisualStyleBackColor = true;
            removeQuestionButton.Click += removeQuestionButton_Click;
            // 
            // QuestionListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 800);
            Controls.Add(removeQuestionButton);
            Controls.Add(questionsDataGridView);
            Name = "QuestionListForm";
            Text = "QuestionListForm";
            Load += QuestionListForm_Load;
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView questionsDataGridView;
        private DataGridViewTextBoxColumn QuestionTextColumn;
        private DataGridViewTextBoxColumn QuestionAnswerColumn;
        private Button removeQuestionButton;
    }
}