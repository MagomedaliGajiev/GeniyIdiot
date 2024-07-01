namespace GeniyIdiotWinFormsApp
{
    partial class ResultsForm
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
            resultsDataGridView = new DataGridView();
            UserNameColumn = new DataGridViewTextBoxColumn();
            CountRightAnswersColumn = new DataGridViewTextBoxColumn();
            DiagnosisColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { UserNameColumn, CountRightAnswersColumn, DiagnosisColumn });
            resultsDataGridView.Location = new Point(0, 12);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.RowHeadersWidth = 82;
            resultsDataGridView.Size = new Size(692, 773);
            resultsDataGridView.TabIndex = 0;
            // 
            // UserNameColumn
            // 
            UserNameColumn.HeaderText = "Имя";
            UserNameColumn.MinimumWidth = 10;
            UserNameColumn.Name = "UserNameColumn";
            UserNameColumn.Width = 200;
            // 
            // CountRightAnswersColumn
            // 
            CountRightAnswersColumn.HeaderText = "Кол-во правильных ответов";
            CountRightAnswersColumn.MinimumWidth = 10;
            CountRightAnswersColumn.Name = "CountRightAnswersColumn";
            CountRightAnswersColumn.Width = 200;
            // 
            // DiagnosisColumn
            // 
            DiagnosisColumn.HeaderText = "Диагноз";
            DiagnosisColumn.MinimumWidth = 10;
            DiagnosisColumn.Name = "DiagnosisColumn";
            DiagnosisColumn.Width = 200;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 789);
            Controls.Add(resultsDataGridView);
            Name = "ResultsForm";
            Text = "ResultsForm";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultsDataGridView;
        private DataGridViewTextBoxColumn UserNameColumn;
        private DataGridViewTextBoxColumn CountRightAnswersColumn;
        private DataGridViewTextBoxColumn DiagnosisColumn;
    }
}