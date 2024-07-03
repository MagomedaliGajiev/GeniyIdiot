using System.Xml.Serialization;

namespace GeniyIdiot.Common
{
    public class XMLConverter : IConvert
    {
        public string Serialize<T>(T item)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, item);
                return textWriter.ToString();
            }
        }
        public T Deserialize<T>(string xml)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var textReader = new StringReader(xml))
            {
                return (T)xmlSerializer.Deserialize(textReader);
            }
        }
    }
}
