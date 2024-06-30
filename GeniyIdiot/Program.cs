using GeniyIdiot.Common;

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
                var user = new User(userName);
                var questions = QuestionsStorage.GetAll();
                var countQuestions = questions.Count();

                var random = new Random();

                for (int i = 0; i < countQuestions; i++)
                {
                    Console.WriteLine($"Вопрос №{i + 1}");
                    var randomIndex = random.Next(questions.Count);
                    Console.WriteLine(questions[randomIndex].Text);
                    var userAnswer = GetNumber();

                    var rightAnswer = questions[randomIndex].Answer;
                    if (userAnswer == rightAnswer)
                    {
                        user.AcceptRightAnswer();
                    }
                    questions.RemoveAt(randomIndex);
                }
                Console.WriteLine($"Количество правильных ответов: {user.CountRightAnswers}");

                var diagnosis = DiagnosisCalculator.Calculate(countQuestions, user.CountRightAnswers);
                user.Diagnosis = diagnosis;
                Console.WriteLine($"{user.Name},Ваш диагноз: {user.Diagnosis}");

                UserResultsStorage.Save(user);

                var userChoice = GetUserChoice("Хотите посмотреть предыдущие результаты игры?");
                if (userChoice)
                {
                    ShowUserResults();
                }

                userChoice = GetUserChoice("Хотите добавить новый вопрос?");
                if (userChoice)
                {
                    AddNewQuestion();
                }

                userChoice = GetUserChoice("Хотите удалить существующий вопрос?");
                if (userChoice)
                {
                    RemoveQuestion();
                }

                userChoice = GetUserChoice("Хотите начать сначала?");
                if (!userChoice)
                {
                    break;
                }

            }
        }

        static void RemoveQuestion()
        {
            Console.WriteLine("Введите номер удаляемого вопроса");
            var questions = QuestionsStorage.GetAll();
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {questions[i].Text}");
            }

            var removeQuestionNumber = GetNumber();
            while (removeQuestionNumber < 1 || removeQuestionNumber > questions.Count)
            {
                Console.WriteLine($"Введите число от 1 до {questions.Count}");
                removeQuestionNumber = GetNumber();
            }

            var removeQuestion = questions[removeQuestionNumber - 1];
            QuestionsStorage.Remove(removeQuestion);
        }

        static void AddNewQuestion()
        {
            Console.WriteLine("Введите текст вопроса");
            var text = Console.ReadLine();
            Console.WriteLine("Введите ответ на вопрос");
            var answer = GetNumber();

            var newQuestion = new Question(text, answer);

            QuestionsStorage.Add(newQuestion);
        }

        static void ShowUserResults()
        {
            var result = UserResultsStorage.GetUserResults();
            Console.WriteLine("{0,-20}{1,18}{2,15}", "Имя", "Кол-во правильных ответов", "Диагноз");
            foreach (var user in result)
            {
                Console.WriteLine("{0,-20}{1,18}{2,15}", user.Name, user.CountRightAnswers, user.Diagnosis);
            }
        }

        static int GetNumber()
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
    }
}
