using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class JsonConverter : IConvert
    {
        public string Serialize<T>(T item)
        {
            return JsonConvert.SerializeObject(item, Formatting.Indented);
        }
        public T Deserialize<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
