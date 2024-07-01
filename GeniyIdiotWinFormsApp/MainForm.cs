using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private Game game;
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();

            var user = new User(welcomeForm.userNameTextBox.Text);
            game = new Game(user);

            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var currentQuestion = game.GetNextQuestion();
            questionTextLabel.Text = currentQuestion.Text;

            questionNumberLabel.Text = game.GetQuestionNumberText();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var parsed = InputValidator.TryParseToNumber(userAnswerTextBox.Text, out int userAnswer, out string errorMessage);
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                game.AcceptAnswer(userAnswer);
                if (game.End())
                {
                    var message = game.CalculateDiagnosis();
                    MessageBox.Show(message);
                }
                else
                {
                    ShowNextQuestion();
                }
            }
        }

        private void ‚˚ıÓ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ÂÒÚ‡ÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ÔÓÍ‡Á‡Ú¸œÂ‰˚‰Û˘ËÂ–ÂToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }
    }
}
