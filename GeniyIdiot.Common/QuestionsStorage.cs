﻿namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        private static string _path = "questions";
        private static IConvert converter = new JsonConverter();
        public static List<Question> GetAll()
        {
            var questions = new List<Question>();

            if (FileProvider.Exists(_path))
            {
                var value = FileProvider.Get(_path);
                questions = converter.Deserialize<List<Question>>(value);
            }
            else
            {
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
                SaveQuestions(questions);

            }

            return questions;
        }

        private static void SaveQuestions(List<Question> questions)
        {
            var jsonData = converter.Serialize(questions);
            FileProvider.Replace(_path, jsonData);
        }

        public static void Add(Question newQuestion)
        {
            var questions = GetAll();
            questions.Add(newQuestion);
            SaveQuestions(questions);
        }

        public static void Remove(Question removeQuestion)
        {
            var questions = GetAll();
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Text == removeQuestion.Text)
                {
                    questions.RemoveAt(i);
                    break;
                }
            };
            SaveQuestions(questions);
        }

        public static void Remove(string text)
        {
            var questions = GetAll();
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Text == text)
                {
                    questions.RemoveAt(i);
                    break;
                }
            };
            SaveQuestions(questions);
        }
    }
}
