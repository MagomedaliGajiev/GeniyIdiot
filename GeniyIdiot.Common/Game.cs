namespace GeniyIdiot.Common
{
    public class Game
    {
        private User user { get; set; }
        private List<Question> questions;
        private Question currentQuestion;
        private int countQuestions;
        private int questionNumber;
        public Game(User user)
        {
            this.user = user;
            questions = QuestionsStorage.GetAll();
            countQuestions = questions.Count;
        }

        public Question GetNextQuestion()
        {
            var random = new Random();
            var randomIndex = random.Next(questions.Count);
            currentQuestion = questions[randomIndex];
            ++questionNumber;
            return currentQuestion;
        }

        public void AcceptAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();
            }
            questions.Remove(currentQuestion);
        }

        public string GetQuestionNumberText()
        {
            return $"{user.Name},Ваш диагноз: {user.Diagnosis}";
        }

        public bool End()
        {
            return questions.Count == 0;
        }

        public string CalculateDiagnosis()
        {
            var diagnosis = DiagnosisCalculator.Calculate(countQuestions, user.CountRightAnswers);
            user.Diagnosis = diagnosis;

            UserResultsStorage.Save(user);

            return $"{user.Name},Ваш диагноз: {user.Diagnosis}";
        }
    }
}
