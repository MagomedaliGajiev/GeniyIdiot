namespace GeniyIdiot.Common
{
    public interface IConvert
    {
        public string Serialize<T>(T item);
        public T Deserialize<T>(string data);
    }
}
