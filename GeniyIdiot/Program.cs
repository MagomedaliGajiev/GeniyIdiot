namespace GeniyIdiot
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Здравствуйте! Как вас зовут?");
                var userName = Console.ReadLine();

                var countQuestions = 5;
                var questions = GetQuestions(countQuestions);

                var answers = GetAnswers(countQuestions);

                var countRightAnswers = 0;

                Shuffle(questions, answers);

                for (int i = 0; i < countQuestions; i++)
                {
                    Console.WriteLine($"Вопрос №{i + 1}");

                    Console.WriteLine(questions[i]);
                    var userAnswer = GetUserAnswer();


                    var rightAnswer = answers[i];

                    if (userAnswer == rightAnswer)
                    {
                        ++countRightAnswers;
                    }
                }
                Console.WriteLine($"Количество правильных ответов: {countRightAnswers}");

                var diagnosis = CalculateDiagnosis(countQuestions, countRightAnswers);

               
                Console.WriteLine($"{userName},Ваш диагноз: {diagnosis}");

                var userChoice = GetUserChoice("Хотите начать сначала?");
                if (!userChoice)
                {
                    break;
                }

            }
        }

        private static string CalculateDiagnosis(int countQuestions, int countRightAnswers)
        {
            var diagnoses = GetDiagnoses();

            var percentRightAnswers = countRightAnswers * 100 / countQuestions;

            return diagnoses[percentRightAnswers / 20];
        }

        private static int GetUserAnswer()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {

                    Console.WriteLine("Пожалуйста, введите число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Пожалуйста, введите число от -2*10^9 до 2*10^9");
                }
            }
        }
        static string[] GetQuestions(int countQuestions)
        {
            var questions = new string[countQuestions];
            questions[0] = "Сколько будет два плюс два умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?";
            questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?";
            questions[4] = "Пять свечей горело, две потухли. Сколько свечей осталось?";

            return questions;
        }

        static int[] GetAnswers(int countAnswers)
        {
            var answers = new int[countAnswers];
            answers[0] = 6;
            answers[1] = 9;
            answers[2] = 25;
            answers[3] = 60;
            answers[4] = 2;

            return answers;
        }

        static string[] GetDiagnoses()
        {
            var diagnoses = new string[6];
            diagnoses[0] = "кретин";
            diagnoses[1] = "идиот";
            diagnoses[2] = "дурак";
            diagnoses[3] = "нормальный";
            diagnoses[4] = "талант";
            diagnoses[5] = "гений";

            return diagnoses;
        }

        static bool GetUserChoice(string message)
        {
            while (true)
            {
                Console.WriteLine($"{message} Введите Да или Нет");
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "нет")
                {
                    return false;
                }
                if (userInput.ToLower() == "да")
                {
                    return true;
                }
            }
        }

        static void Shuffle(string[] questions, int[] answers)
        {
            var random = new Random();

            for (int i = questions.Length - 1; i > 1; i--)
            {
                var index = random.Next(0, i);

                var tempQuestion = questions[index];
                questions[index] = questions[i];
                questions[i] = tempQuestion;

                var tempAnswer = answers[index];
                answers[index] = answers[i];
                answers[i] = tempAnswer;
            }
        }
    }
}
