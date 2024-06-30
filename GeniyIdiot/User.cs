namespace GeniyIdiot
{
    public class User
    {
        public string Name { get; set; }
        public int CountRightAnswers { get; set; }
        public string Diagnosis { get; set; }

        public User(string name)
        {
            Name = name;
            Diagnosis = "Неизвестно";
        }

        public void AcceptRightAnswer()
        {
            ++CountRightAnswers;
        }
    }
}
