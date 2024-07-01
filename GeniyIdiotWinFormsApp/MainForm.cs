using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private int countQuestions;
        private User user;
        private int questionNumber;
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();

            user = new User(welcomeForm.userNameTextBox.Text);
            questions = QuestionsStorage.GetAll();
            countQuestions = questions.Count;
            questionNumber = 0;

            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var random = new Random();
            var randomIndex = random.Next(questions.Count);

            currentQuestion = questions[randomIndex];

            questionTextLabel.Text = currentQuestion.Text;
            questionNumberLabel.Text = $"Âîïðîñ ¹ {++questionNumber}";
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            var rightAnswer = currentQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();
            }
            questions.Remove(currentQuestion);

            var endGame = questions.Count == 0;
            if (endGame)
            {
                var diagnosis = DiagnosisCalculator.Calculate(countQuestions, user.CountRightAnswers);
                user.Diagnosis = diagnosis;

                UserResultsStorage.Save(user);

                var message = $"{user.Name},Âàø äèàãíîç: {user.Diagnosis}";
                MessageBox.Show(message);
            }
            else
            {
                ShowNextQuestion();
            }
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ðåñòàðòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
