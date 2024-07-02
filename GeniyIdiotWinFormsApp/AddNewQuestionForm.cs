using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class AddNewQuestionForm : Form
    {
        public AddNewQuestionForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var parsed = InputValidator.TryParseToNumber(questionAnswerTextBox.Text, out int userAnswer, out string errorMessage);
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
            }

            var newQuestion = new Question(questionTextTextBox.Text, userAnswer);
            QuestionsStorage.Add(newQuestion);

            Close();
        }
    }
}
