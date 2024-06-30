using System.Text;

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
                var questions = QuestionsStorage.GetAll();

                var countQuestions = questions.Count();

                var countRightAnswers = 0;

                var random = new Random();

                for (int i = 0; i < countQuestions; i++)
                {
                    Console.WriteLine($"Вопрос №{i + 1}");
                    var questionIndex = random.Next(questions.Count);
                    Console.WriteLine(questions[questionIndex].Text);
                    var userAnswer = GetUserAnswer();
                    
                    var rightAnswer = questions[questionIndex].Answer;

                    if (userAnswer == rightAnswer)
                    {
                        ++countRightAnswers;
                    }
                    questions.RemoveAt(questionIndex);
                }
                Console.WriteLine($"Количество правильных ответов: {countRightAnswers}");

                var diagnosis = CalculateDiagnosis(countQuestions, countRightAnswers);

               
                Console.WriteLine($"{userName},Ваш диагноз: {diagnosis}");

                SaveUserResult(userName, countRightAnswers, diagnosis);
                var userChoice = GetUserChoice("Хотите посмотреть предыдущие результаты игры?");
                if (userChoice)
                {
                    ShowUserResults();
                }

                userChoice = GetUserChoice("Хотите начать сначала?");
                if (!userChoice)
                {
                    break;
                }

            }
        }

        static void ShowUserResults()
        {
            var reader = new StreamReader("userResults.txt", Encoding.UTF8);

            Console.WriteLine("{0,-20}{1,18}{2,15}", "Имя", "Кол-во правильных ответов", "Диагноз");

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split('#');
                var name = values[0];
                var countRightAnswers = Convert.ToInt32(values[1]);
                var diagnosis = values[2];

                Console.WriteLine("{0,-20}{1,18}{2,15}", name, countRightAnswers, diagnosis);
            }
            reader.Close();
        }

        static void SaveUserResult(string? userName, int countRightAnswers, string diagnosis)
        {
            var value = $"{userName}#{countRightAnswers}#{diagnosis}";
            AppendToFile("userResults.txt", value);
        }

        static void AppendToFile(string fileName, string value)
        {
            var writer = new StreamWriter(fileName, true, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();
        }

        static string CalculateDiagnosis(int countQuestions, int countRightAnswers)
        {
            var diagnoses = GetDiagnoses();

            var percentRightAnswers = countRightAnswers * 100 / countQuestions;

            return diagnoses[percentRightAnswers / 20];
        }

        static int GetUserAnswer()
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
    }
}
