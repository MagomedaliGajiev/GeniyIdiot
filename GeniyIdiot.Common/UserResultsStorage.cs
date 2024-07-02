using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class UserResultsStorage
    {
        private static string _path = "userResults.json";
        public static void Save(User user)
        {
            var userResults = GetAll();
            userResults.Add(user);
            Save(userResults);
        }
        public static List<User> GetAll()
        {
            if (!FileProvider.Exists(_path))
            {
                return new List<User>();
            }
            var filleData = FileProvider.Get(_path);
            var userResults = JsonConvert.DeserializeObject<List<User>>(filleData);
            return userResults;
        }

        static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace(_path, jsonData);
        }
    }
}
