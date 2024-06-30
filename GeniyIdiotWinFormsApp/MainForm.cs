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
            questions = QuestionsStorage.GetAll();
            countQuestions = questions.Count;
            user = new User("Неизвестно");
            questionNumber = 0;

            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var random = new Random();
            var randomIndex = random.Next(questions.Count);

            currentQuestion = questions[randomIndex];

            questionTextLabel.Text = currentQuestion.Text;
            questionNumberLabel.Text = $"Вопрос № {++questionNumber}";
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
                var diagnosis = DiagnosisCalculator.CalculateDiagnosis(countQuestions, user.CountRightAnswers);
                user.Diagnosis = diagnosis;
                MessageBox.Show($"{user.Name},Ваш диагноз: {user.Diagnosis}");
                return;
            }
            ShowNextQuestion();
        }
    }
}
