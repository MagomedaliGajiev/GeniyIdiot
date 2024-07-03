using System.Runtime.Serialization.Formatters.Binary;

namespace GeniyIdiot.Common
{
    class BinaryConverter : IConvert
    {
        public string Serialize<T>(T item)
        {
            var binaryFormater = new BinaryFormatter();
            using (var memoryStream = new MemoryStream())
            {
                binaryFormater.Serialize(memoryStream, item);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public T Deserialize<T>(string data)
        {
            var dataAsBytes = Convert.FromBase64String(data);
            var binaryFormater = new BinaryFormatter();
            using (var memoryStream = new MemoryStream(dataAsBytes))
            {
                return (T)binaryFormater.Deserialize(memoryStream);
            }
        }
    }
}
