namespace GeniyIdiot
{
    public class UserResultsStorage
    {
        public static void Save(User user)
        {
            var value = $"{user.Name}#{user.CountRightAnswers}#{user.Diagnosis}";
            FileProvider.Append("userResults.txt", value);
        }
        public static List<User> GetUserResults()
        {
            var value = FileProvider.GetValue("userResults.txt");
            var lines = value.Split('\n');
            var results = new List<User>();
            foreach (var line in lines)
            {
                var values = line.Split('#');
                var name = values[0];
                var countRightAnswers = Convert.ToInt32(values[1]);
                var diagnosis = values[2];

                var user = new User(name);
                user.CountRightAnswers = countRightAnswers;
                user.Diagnosis = diagnosis;

                results.Add(user);
            }
            return results;
        }
    }
}
